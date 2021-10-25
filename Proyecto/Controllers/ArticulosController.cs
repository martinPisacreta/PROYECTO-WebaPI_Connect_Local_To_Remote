using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly CarritoComprasContext _context;

        public class Articulo_Con_Menos_Atributos
        {
            public string id_articulo { get; set; }

            public string path_img { get; set; }
        }

       
        public ArticulosController(CarritoComprasContext context)
        {
            _context = context;
        }

        //A ESTE HTTP SE VA A ACCEDER DESDE UNA TAREA PROGRAMADA DE LA WEB...
        // GET: api/Articulos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Articulo>>> GetArticulo()
        {

            var articulo =  await _context.Articulo
                            //.AsEnumerable()
                            //.Where(x => x.FechaUltModif.GetValueOrDefault().ToShortDateString() == DateTime.Now.ToShortDateString())
                            .ToListAsync();
 
            if (articulo == null)
            {
                return NotFound();
            }

            return  articulo;
        }

       


        //A ESTE HTTP SE VA A ACCEDER DESDE LA WEB -> FUNCION uploadFilesInServer CONTROLLER ArticulosUploadImageController.cs
        [HttpPost]
        public async Task<IActionResult> PostArticulo([FromBody] Articulo_Con_Menos_Atributos articulo)
        {
            try
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {

                      

                        Articulo articulo_db = null;
                        //valido de no registrar un mail ya existente
                        articulo_db = _context.Articulo.FirstOrDefault(a => a.IdArticulo == Convert.ToInt64(articulo.id_articulo));
                        if (articulo_db == null)
                        {
                            throw new Exception("Articulo " + articulo.id_articulo + " inexistente");
                        }

                        string path_img = articulo.path_img;
                        if (path_img != "")
                        {
                            path_img = path_img.Trim();
                            path_img = articulo.path_img.Replace("'", "").Trim();
                               
                        }
                        articulo_db.PathImg = path_img;
                        _context.Update(articulo_db);
                          

                        

                        await _context.SaveChangesAsync();
                        dbContextTransaction.Commit();
                        return Ok("1");


                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        return BadRequest(new { message = ex.Message });

                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });

            }

        }

    }
}
