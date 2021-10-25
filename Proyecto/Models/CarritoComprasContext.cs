using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class CarritoComprasContext : DbContext
    {
       
        public CarritoComprasContext(DbContextOptions<CarritoComprasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<ArticuloHistorico> ArticuloHistorico { get; set; }
        public virtual DbSet<ArticuloTmp> ArticuloTmp { get; set; }
        public virtual DbSet<ArticuloTmpDuplicados> ArticuloTmpDuplicados { get; set; }
        public virtual DbSet<ArticuloTmpErrores> ArticuloTmpErrores { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ClienteCuentaCorriente> ClienteCuentaCorriente { get; set; }
        public virtual DbSet<ClienteDatos> ClienteDatos { get; set; }
        public virtual DbSet<ClienteDir> ClienteDir { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public virtual DbSet<Familia> Familia { get; set; }
        public virtual DbSet<LogTareaProgramada> LogTareaProgramada { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<ProveedorDatos> ProveedorDatos { get; set; }
        public virtual DbSet<ProveedorDir> ProveedorDir { get; set; }
        public virtual DbSet<Tcalle> Tcalle { get; set; }
        public virtual DbSet<Tmunicipio> Tmunicipio { get; set; }
        public virtual DbSet<Tpais> Tpais { get; set; }
        public virtual DbSet<Tprovincia> Tprovincia { get; set; }
        public virtual DbSet<TtipoCalle> TtipoCalle { get; set; }
        public virtual DbSet<TtipoCliente> TtipoCliente { get; set; }
        public virtual DbSet<TtipoCondicionFactura> TtipoCondicionFactura { get; set; }
        public virtual DbSet<TtipoCondicionIva> TtipoCondicionIva { get; set; }
        public virtual DbSet<TtipoCondicionPago> TtipoCondicionPago { get; set; }
        public virtual DbSet<TtipoDato> TtipoDato { get; set; }
        public virtual DbSet<TtipoDir> TtipoDir { get; set; }
        public virtual DbSet<TtipoFactura> TtipoFactura { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioPedido> UsuarioPedido { get; set; }
        public virtual DbSet<UsuarioPedidoDetalle> UsuarioPedidoDetalle { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.IdArticulo);

                entity.ToTable("articulo");

                entity.HasIndex(e => new { e.CodigoArticuloMarca, e.CodigoArticulo })
                    .HasName("cl_articulo");

                entity.Property(e => e.IdArticulo).HasColumnName("id_articulo");

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoArticulo)
                    .HasColumnName("codigo_articulo")
                    .HasMaxLength(100);

                entity.Property(e => e.CodigoArticuloMarca)
                    .HasColumnName("codigo_articulo_marca")
                    .HasMaxLength(100);

                entity.Property(e => e.DescripcionArticulo).HasColumnName("descripcion_articulo");

                entity.Property(e => e.FecBaja)
                    .HasColumnName("fec_baja")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltModif)
                    .HasColumnName("fecha_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdOrden).HasColumnName("id_orden");

                entity.Property(e => e.IdTablaFamilia).HasColumnName("id_tabla_familia");

                entity.Property(e => e.PathImg)
                    .HasColumnName("path_img")
                    .HasMaxLength(200);

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("precio_lista")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SnOferta).HasColumnName("sn_oferta");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.HasOne(d => d.IdTablaFamiliaNavigation)
                    .WithMany(p => p.Articulo)
                    .HasForeignKey(d => d.IdTablaFamilia)
                    .HasConstraintName("FK_articulo_familia");
            });

            modelBuilder.Entity<ArticuloHistorico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("articulo_historico");

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoArticulo)
                    .HasColumnName("codigo_articulo")
                    .HasMaxLength(100);

                entity.Property(e => e.CodigoArticuloMarca)
                    .HasColumnName("codigo_articulo_marca")
                    .HasMaxLength(100);

                entity.Property(e => e.DescripcionArticulo).HasColumnName("descripcion_articulo");

                entity.Property(e => e.FecBaja)
                    .HasColumnName("fec_baja")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltModif)
                    .HasColumnName("fecha_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArticulo).HasColumnName("id_articulo");

                entity.Property(e => e.IdLista).HasColumnName("id_lista");

                entity.Property(e => e.IdOrden).HasColumnName("id_orden");

                entity.Property(e => e.IdTablaFamilia).HasColumnName("id_tabla_familia");

                entity.Property(e => e.PathImg)
                    .HasColumnName("path_img")
                    .HasMaxLength(200);

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("precio_lista")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SnOferta).HasColumnName("sn_oferta");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.HasOne(d => d.IdTablaFamiliaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTablaFamilia)
                    .HasConstraintName("FK_articulo_historico_familia");
            });

            modelBuilder.Entity<ArticuloTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("articulo_tmp");

                entity.Property(e => e.CodigoArticulo)
                    .HasColumnName("codigo_articulo")
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoArticuloMarca)
                    .HasColumnName("codigo_articulo_marca")
                    .HasMaxLength(255);

                entity.Property(e => e.DescripcionArticulo).HasColumnName("descripcion_articulo");

                entity.Property(e => e.IdArticulo).HasColumnName("id_articulo");

                entity.Property(e => e.IdOrden).HasColumnName("id_orden");

                entity.Property(e => e.IdTablaFamilia).HasColumnName("id_tabla_familia");

                entity.Property(e => e.PathImg)
                    .HasColumnName("path_img")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecioFinal).HasColumnName("precio_final");

                entity.Property(e => e.PrecioLista).HasColumnName("precio_lista");

                entity.Property(e => e.SnOferta).HasColumnName("sn_oferta");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<ArticuloTmpDuplicados>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("articulo_tmp_duplicados");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodigoArticulo)
                    .HasColumnName("codigo_articulo")
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoArticuloMarca)
                    .HasColumnName("codigo_articulo_marca")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ArticuloTmpErrores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("articulo_tmp_errores");

                entity.Property(e => e.CodigoArticulo)
                    .HasColumnName("codigo_articulo")
                    .HasMaxLength(255);

                entity.Property(e => e.CodigoArticuloMarca)
                    .HasColumnName("codigo_articulo_marca")
                    .HasMaxLength(255);

                entity.Property(e => e.DescripcionArticulo).HasColumnName("descripcion_articulo");

                entity.Property(e => e.IdArticulo).HasColumnName("id_articulo");

                entity.Property(e => e.IdOrden).HasColumnName("id_orden");

                entity.Property(e => e.IdTablaFamilia).HasColumnName("id_tabla_familia");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnName("observacion")
                    .HasMaxLength(255);

                entity.Property(e => e.PathImg)
                    .HasColumnName("path_img")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecioFinal).HasColumnName("precio_final");

                entity.Property(e => e.PrecioLista).HasColumnName("precio_lista");

                entity.Property(e => e.SnOferta).HasColumnName("sn_oferta");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("accion")
                    .HasMaxLength(100);

                entity.Property(e => e.FecUltModif)
                    .HasColumnName("fec_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCondicionAnteIva).HasColumnName("id_condicion_ante_iva");

                entity.Property(e => e.IdCondicionFactura).HasColumnName("id_condicion_factura");

                entity.Property(e => e.IdCondicionPago).HasColumnName("id_condicion_pago");

                entity.Property(e => e.IdTipoCliente).HasColumnName("id_tipo_cliente");

                entity.Property(e => e.NombreFantasia)
                    .IsRequired()
                    .HasColumnName("nombre_fantasia")
                    .HasMaxLength(100);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razon_social")
                    .HasMaxLength(100);

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.HasOne(d => d.IdCondicionAnteIvaNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdCondicionAnteIva)
                    .HasConstraintName("FK_cliente_ttipo_condicion_iva");

                entity.HasOne(d => d.IdCondicionFacturaNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdCondicionFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente_ttipo_condicion_factura");

                entity.HasOne(d => d.IdCondicionPagoNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdCondicionPago)
                    .HasConstraintName("FK_cliente_ttipo_condicion_pago");

                entity.HasOne(d => d.IdTipoClienteNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente_ttipo_cliente");
            });

            modelBuilder.Entity<ClienteCuentaCorriente>(entity =>
            {
                entity.HasKey(e => e.IdClienteCuentaCorriente);

                entity.ToTable("cliente_cuenta_corriente");

                entity.Property(e => e.IdClienteCuentaCorriente).HasColumnName("id_cliente_cuenta_corriente");

                entity.Property(e => e.CodTipoFacturaVieja)
                    .HasColumnName("cod_tipo_factura_vieja")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.FechaFacturaVieja)
                    .HasColumnName("fecha_factura_vieja")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.ImpFactura)
                    .HasColumnName("imp_factura")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NroFacturaVieja).HasColumnName("nro_factura_vieja");

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasMaxLength(500);

                entity.Property(e => e.Pago1)
                    .HasColumnName("pago_1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pago1Fecha)
                    .HasColumnName("pago_1_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pago2)
                    .HasColumnName("pago_2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pago2Fecha)
                    .HasColumnName("pago_2_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pago3)
                    .HasColumnName("pago_3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pago3Fecha)
                    .HasColumnName("pago_3_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pago4)
                    .HasColumnName("pago_4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pago4Fecha)
                    .HasColumnName("pago_4_fecha")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ClienteDatos>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.CodTipoDato })
                    .HasName("PK_cliente_conta");

                entity.ToTable("cliente_datos");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.CodTipoDato)
                    .HasColumnName("cod_tipo_dato")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("accion")
                    .HasMaxLength(100);

                entity.Property(e => e.FecUltModif)
                    .HasColumnName("fec_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtDatoCliente)
                    .IsRequired()
                    .HasColumnName("txt_dato_cliente")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodTipoDatoNavigation)
                    .WithMany(p => p.ClienteDatos)
                    .HasForeignKey(d => d.CodTipoDato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cliente_c_1730258338");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClienteDatos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente_datos_cliente");
            });

            modelBuilder.Entity<ClienteDir>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.CodTipoDir });

                entity.ToTable("cliente_dir");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.CodTipoDir)
                    .HasColumnName("cod_tipo_dir")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(100);

                entity.Property(e => e.CodCalle)
                    .HasColumnName("cod_calle")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CodClaseDir).HasColumnName("cod_clase_dir");

                entity.Property(e => e.CodMunicipio)
                    .HasColumnName("cod_municipio")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasColumnType("numeric(2, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CodProvincia)
                    .HasColumnName("cod_provincia")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodTipoCalle)
                    .HasColumnName("cod_tipo_calle")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FecUltModif)
                    .HasColumnName("fec_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtApto)
                    .HasColumnName("txt_apto")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TxtCodPostal)
                    .HasColumnName("txt_cod_postal")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TxtDireccion)
                    .HasColumnName("txt_direccion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TxtNumero)
                    .HasColumnName("txt_numero")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TxtPiso)
                    .HasColumnName("txt_piso")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCalleNavigation)
                    .WithMany(p => p.ClienteDir)
                    .HasForeignKey(d => d.CodCalle)
                    .HasConstraintName("FK_cliente_dir_tcalle");

                entity.HasOne(d => d.CodMunicipioNavigation)
                    .WithMany(p => p.ClienteDir)
                    .HasForeignKey(d => d.CodMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente_dir_tmunicipio");

                entity.HasOne(d => d.CodPaisNavigation)
                    .WithMany(p => p.ClienteDir)
                    .HasForeignKey(d => d.CodPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cliente__cod_p__15A53433");

                entity.HasOne(d => d.CodProvinciaNavigation)
                    .WithMany(p => p.ClienteDir)
                    .HasForeignKey(d => d.CodProvincia)
                    .HasConstraintName("FK__cliente__cod_p__178D7CA5");

                entity.HasOne(d => d.CodTipoCalleNavigation)
                    .WithMany(p => p.ClienteDir)
                    .HasForeignKey(d => d.CodTipoCalle)
                    .HasConstraintName("FK_cliente_dir_ttipo_calle");

                entity.HasOne(d => d.CodTipoDirNavigation)
                    .WithMany(p => p.ClienteDir)
                    .HasForeignKey(d => d.CodTipoDir)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cliente___cod_t__3C24A6E0");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClienteDir)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente_dir_cliente");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK_Empresa");

                entity.ToTable("empresa");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnName("celular")
                    .HasMaxLength(50);

                entity.Property(e => e.Cuit)
                    .IsRequired()
                    .HasColumnName("cuit")
                    .HasMaxLength(15);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaInicioActividad)
                    .HasColumnName("fecha_inicio_actividad")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCondicionAnteIva).HasColumnName("id_condicion_ante_iva");

                entity.Property(e => e.NombreFantasia)
                    .IsRequired()
                    .HasColumnName("nombre_fantasia")
                    .HasMaxLength(100);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("razon_social")
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdCondicionAnteIvaNavigation)
                    .WithMany(p => p.Empresa)
                    .HasForeignKey(d => d.IdCondicionAnteIva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_empresa_ttipo_condicion_iva");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("PK_cliente_factura");

                entity.ToTable("factura");

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.CodTipoFactura)
                    .HasColumnName("cod_tipo_factura")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSnEmitida)
                    .HasColumnName("fecha_sn_emitida")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdCondicionFactura).HasColumnName("id_condicion_factura");

                entity.Property(e => e.NroFactura).HasColumnName("nro_factura");

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasMaxLength(500);

                entity.Property(e => e.PathFactura)
                    .HasColumnName("path_factura")
                    .HasMaxLength(1500);

                entity.Property(e => e.PrecioFinal)
                    .HasColumnName("precio_final")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioFinalConPagoMayorA30Dias)
                    .HasColumnName("precio_final_con_pago_mayor_a_30_dias")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioFinalConPagoMenorA30Dias)
                    .HasColumnName("precio_final_con_pago_menor_a_30_dias")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioFinalConPagoMenorA7Dias)
                    .HasColumnName("precio_final_con_pago_menor_a_7_dias")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SnEmitida).HasColumnName("sn_emitida");

                entity.Property(e => e.SnMostrarPagoMayor30Dias).HasColumnName("sn_mostrar_pago_mayor_30_dias");

                entity.Property(e => e.SnMostrarPagoMenor30Dias).HasColumnName("sn_mostrar_pago_menor_30_dias");

                entity.Property(e => e.SnMostrarPagoMenor7Dias).HasColumnName("sn_mostrar_pago_menor_7_dias");

                entity.HasOne(d => d.CodTipoFacturaNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.CodTipoFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_factura_ttipo_factura");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_factura_cliente");

                entity.HasOne(d => d.IdCondicionFacturaNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.IdCondicionFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_factura_ttipo_condicion_factura");
            });

            modelBuilder.Entity<FacturaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdFacturaDetalle)
                    .HasName("PK_cliente_factura_detalle");

                entity.ToTable("factura_detalle");

                entity.Property(e => e.IdFacturaDetalle).HasColumnName("id_factura_detalle");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodigoArticulo)
                    .IsRequired()
                    .HasColumnName("codigo_articulo")
                    .HasMaxLength(100);

                entity.Property(e => e.CodigoArticuloMarca)
                    .IsRequired()
                    .HasColumnName("codigo_articulo_marca")
                    .HasMaxLength(100);

                entity.Property(e => e.DescripcionArticulo)
                    .IsRequired()
                    .HasColumnName("descripcion_articulo");

                entity.Property(e => e.FecBaja)
                    .HasColumnName("fec_baja")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArticulo).HasColumnName("id_articulo");

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.Iva)
                    .HasColumnName("iva")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PrecioListaXCoeficiente)
                    .HasColumnName("precio_lista_x_coeficiente")
                    .HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.IdArticuloNavigation)
                    .WithMany(p => p.FacturaDetalle)
                    .HasForeignKey(d => d.IdArticulo)
                    .HasConstraintName("FK_cliente_factura_detalle_articulo");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.FacturaDetalle)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente_factura_detalle_cliente_factura");
            });

            modelBuilder.Entity<Familia>(entity =>
            {
                entity.HasKey(e => e.IdTablaFamilia);

                entity.ToTable("familia");

                entity.Property(e => e.IdTablaFamilia)
                    .HasColumnName("id_tabla_familia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("accion")
                    .HasMaxLength(100);

                entity.Property(e => e.Algoritmo1)
                    .HasColumnName("algoritmo_1")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo10)
                    .HasColumnName("algoritmo_10")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo2)
                    .HasColumnName("algoritmo_2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo3)
                    .HasColumnName("algoritmo_3")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo4)
                    .HasColumnName("algoritmo_4")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo5)
                    .HasColumnName("algoritmo_5")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo6)
                    .HasColumnName("algoritmo_6")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo7)
                    .HasColumnName("algoritmo_7")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo8)
                    .HasColumnName("algoritmo_8")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Algoritmo9)
                    .HasColumnName("algoritmo_9")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FecUltModif)
                    .HasColumnName("fec_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdFamilia).HasColumnName("id_familia");

                entity.Property(e => e.IdTablaMarca).HasColumnName("id_tabla_marca");

                entity.Property(e => e.PathImg)
                    .HasColumnName("path_img")
                    .HasMaxLength(500);

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtDescFamilia)
                    .IsRequired()
                    .HasColumnName("txt_desc_familia")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdTablaMarcaNavigation)
                    .WithMany(p => p.Familia)
                    .HasForeignKey(d => d.IdTablaMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_familia_marca");
            });

            modelBuilder.Entity<LogTareaProgramada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log_tarea_programada");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnName("observacion")
                    .HasMaxLength(200);

                entity.Property(e => e.Tabla)
                    .IsRequired()
                    .HasColumnName("tabla")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdTablaMarca);

                entity.ToTable("marca");

                entity.Property(e => e.IdTablaMarca)
                    .HasColumnName("id_tabla_marca")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("accion")
                    .HasMaxLength(100);

                entity.Property(e => e.FecUltModif)
                    .HasColumnName("fec_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

                entity.Property(e => e.PathImg)
                    .HasColumnName("path_img")
                    .HasMaxLength(500);

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtDescMarca)
                    .IsRequired()
                    .HasColumnName("txt_desc_marca")
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Marca)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_marca_proveedor");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK__proveedor__79FD19BE");

                entity.ToTable("proveedor");

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("id_proveedor")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("accion")
                    .HasMaxLength(100);

                entity.Property(e => e.FecUltModif)
                    .HasColumnName("fec_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCondicionAnteIva).HasColumnName("id_condicion_ante_iva");

                entity.Property(e => e.IdCondicionPago).HasColumnName("id_condicion_pago");

                entity.Property(e => e.PathImg)
                    .HasColumnName("path_img")
                    .HasMaxLength(500);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("razon_social")
                    .HasMaxLength(100);

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.HasOne(d => d.IdCondicionAnteIvaNavigation)
                    .WithMany(p => p.Proveedor)
                    .HasForeignKey(d => d.IdCondicionAnteIva)
                    .HasConstraintName("FK_proveedor_ttipo_condicion_iva");

                entity.HasOne(d => d.IdCondicionPagoNavigation)
                    .WithMany(p => p.Proveedor)
                    .HasForeignKey(d => d.IdCondicionPago)
                    .HasConstraintName("FK_proveedor_ttipo_condicion_pago");
            });

            modelBuilder.Entity<ProveedorDatos>(entity =>
            {
                entity.HasKey(e => new { e.IdProveedor, e.CodTipoDato });

                entity.ToTable("proveedor_datos");

                entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

                entity.Property(e => e.CodTipoDato)
                    .HasColumnName("cod_tipo_dato")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("accion")
                    .HasMaxLength(100);

                entity.Property(e => e.FecUltModif)
                    .HasColumnName("fec_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtDatoProveedor)
                    .IsRequired()
                    .HasColumnName("txt_dato_proveedor")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodTipoDatoNavigation)
                    .WithMany(p => p.ProveedorDatos)
                    .HasForeignKey(d => d.CodTipoDato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedor_datos_ttipo_dato");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.ProveedorDatos)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedor_datos_proveedor");
            });

            modelBuilder.Entity<ProveedorDir>(entity =>
            {
                entity.HasKey(e => new { e.IdProveedor, e.CodTipoDir });

                entity.ToTable("proveedor_dir");

                entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

                entity.Property(e => e.CodTipoDir)
                    .HasColumnName("cod_tipo_dir")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(100);

                entity.Property(e => e.CodCalle)
                    .HasColumnName("cod_calle")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CodClaseDir).HasColumnName("cod_clase_dir");

                entity.Property(e => e.CodMunicipio)
                    .HasColumnName("cod_municipio")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasColumnType("numeric(2, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CodProvincia)
                    .HasColumnName("cod_provincia")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodTipoCalle)
                    .HasColumnName("cod_tipo_calle")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FecUltModif)
                    .HasColumnName("fec_ult_modif")
                    .HasColumnType("datetime");

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtApto)
                    .HasColumnName("txt_apto")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TxtCodPostal)
                    .HasColumnName("txt_cod_postal")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TxtDireccion)
                    .HasColumnName("txt_direccion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TxtNumero)
                    .HasColumnName("txt_numero")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TxtPiso)
                    .HasColumnName("txt_piso")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCalleNavigation)
                    .WithMany(p => p.ProveedorDir)
                    .HasForeignKey(d => d.CodCalle)
                    .HasConstraintName("FK_proveedor_dir_tcalle");

                entity.HasOne(d => d.CodMunicipioNavigation)
                    .WithMany(p => p.ProveedorDir)
                    .HasForeignKey(d => d.CodMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedor_dir_tmunicipio");

                entity.HasOne(d => d.CodPaisNavigation)
                    .WithMany(p => p.ProveedorDir)
                    .HasForeignKey(d => d.CodPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__proveedor__cod_p__15A53433");

                entity.HasOne(d => d.CodProvinciaNavigation)
                    .WithMany(p => p.ProveedorDir)
                    .HasForeignKey(d => d.CodProvincia)
                    .HasConstraintName("FK__proveedor__cod_p__178D7CA5");

                entity.HasOne(d => d.CodTipoCalleNavigation)
                    .WithMany(p => p.ProveedorDir)
                    .HasForeignKey(d => d.CodTipoCalle)
                    .HasConstraintName("FK_proveedor_dir_ttipo_calle");

                entity.HasOne(d => d.CodTipoDirNavigation)
                    .WithMany(p => p.ProveedorDir)
                    .HasForeignKey(d => d.CodTipoDir)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__proveedor___cod_t__3C24A6E0");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.ProveedorDir)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedor_dir_proveedor");
            });

            modelBuilder.Entity<Tcalle>(entity =>
            {
                entity.HasKey(e => e.CodCalle)
                    .HasName("tcalle_9217673101");

                entity.ToTable("tcalle");

                entity.Property(e => e.CodCalle)
                    .HasColumnName("cod_calle")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tmunicipio>(entity =>
            {
                entity.HasKey(e => e.CodMunicipio)
                    .HasName("PK_tmunicipio_1");

                entity.ToTable("tmunicipio");

                entity.Property(e => e.CodMunicipio)
                    .HasColumnName("cod_municipio")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CodDivipola)
                    .HasColumnName("cod_divipola")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodProvincia)
                    .HasColumnName("cod_provincia")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.TxtDesc)
                    .HasColumnName("txt_desc")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CodPaisNavigation)
                    .WithMany(p => p.Tmunicipio)
                    .HasForeignKey(d => d.CodPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmunicipio_tpais1");

                entity.HasOne(d => d.CodProvinciaNavigation)
                    .WithMany(p => p.Tmunicipio)
                    .HasForeignKey(d => d.CodProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmunicipio_tprovincia");
            });

            modelBuilder.Entity<Tpais>(entity =>
            {
                entity.HasKey(e => e.CodPais)
                    .HasName("tpais_2115288061");

                entity.ToTable("tpais");

                entity.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tprovincia>(entity =>
            {
                entity.HasKey(e => e.CodProvincia);

                entity.ToTable("tprovincia");

                entity.Property(e => e.CodProvincia)
                    .HasColumnName("cod_provincia")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodPaisNavigation)
                    .WithMany(p => p.Tprovincia)
                    .HasForeignKey(d => d.CodPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tprovincia_tpais");
            });

            modelBuilder.Entity<TtipoCalle>(entity =>
            {
                entity.HasKey(e => e.CodTipoCalle)
                    .HasName("ttipo_call_15520575841");

                entity.ToTable("ttipo_calle");

                entity.Property(e => e.CodTipoCalle)
                    .HasColumnName("cod_tipo_calle")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtipoCliente>(entity =>
            {
                entity.HasKey(e => e.IdTipoCliente);

                entity.ToTable("ttipo_cliente");

                entity.Property(e => e.IdTipoCliente)
                    .HasColumnName("id_tipo_cliente")
                    .ValueGeneratedNever();

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TtipoCondicionFactura>(entity =>
            {
                entity.HasKey(e => e.IdCondicionFactura);

                entity.ToTable("ttipo_condicion_factura");

                entity.Property(e => e.IdCondicionFactura)
                    .HasColumnName("id_condicion_factura")
                    .ValueGeneratedNever();

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TtipoCondicionIva>(entity =>
            {
                entity.HasKey(e => e.IdCondicionAnteIva);

                entity.ToTable("ttipo_condicion_iva");

                entity.Property(e => e.IdCondicionAnteIva)
                    .HasColumnName("id_condicion_ante_iva")
                    .ValueGeneratedNever();

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(10);

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.TxtDescResumido)
                    .IsRequired()
                    .HasColumnName("txt_desc_resumido")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TtipoCondicionPago>(entity =>
            {
                entity.HasKey(e => e.IdCondicionPago);

                entity.ToTable("ttipo_condicion_pago");

                entity.Property(e => e.IdCondicionPago)
                    .HasColumnName("id_condicion_pago")
                    .ValueGeneratedNever();

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TtipoDato>(entity =>
            {
                entity.HasKey(e => e.CodTipoDato)
                    .HasName("ttipo_conta_5885781541");

                entity.ToTable("ttipo_dato");

                entity.Property(e => e.CodTipoDato)
                    .HasColumnName("cod_tipo_dato")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtipoDir>(entity =>
            {
                entity.HasKey(e => e.CodTipoDir)
                    .HasName("ttipo_dir_19360589521");

                entity.ToTable("ttipo_dir");

                entity.Property(e => e.CodTipoDir)
                    .HasColumnName("cod_tipo_dir")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtipoFactura>(entity =>
            {
                entity.HasKey(e => e.CodTipoFactura)
                    .HasName("ttipo_fact_5885781541");

                entity.ToTable("ttipo_factura");

                entity.Property(e => e.CodTipoFactura)
                    .HasColumnName("cod_tipo_factura")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Letra)
                    .IsRequired()
                    .HasColumnName("letra")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TxtDesc)
                    .IsRequired()
                    .HasColumnName("txt_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK_Usuario_1");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.AceptaTerminos).HasColumnName("acepta_terminos");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(50);

                entity.Property(e => e.Cuit)
                    .IsRequired()
                    .HasColumnName("cuit")
                    .HasMaxLength(50);

                entity.Property(e => e.DireccionDescripcion)
                    .IsRequired()
                    .HasColumnName("direccion_descripcion")
                    .HasMaxLength(200);

                entity.Property(e => e.DireccionValor)
                    .IsRequired()
                    .HasColumnName("direccion_valor")
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCreacionUsuario)
                    .HasColumnName("fecha_creacion_usuario")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaUltimaModificacionUsuario)
                    .HasColumnName("fecha_ultima_modificacion_usuario")
                    .HasColumnType("date");

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasColumnName("lat")
                    .HasMaxLength(200);

                entity.Property(e => e.Lng)
                    .IsRequired()
                    .HasColumnName("lng")
                    .HasMaxLength(200);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(200);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("razon_social")
                    .HasMaxLength(50);

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(50);

                entity.Property(e => e.TokenReseteo)
                    .HasColumnName("token_reseteo")
                    .HasMaxLength(50);

                entity.Property(e => e.TokenReseteoFechaExpiracion)
                    .HasColumnName("token_reseteo_fecha_expiracion")
                    .HasColumnType("date");

                entity.Property(e => e.TokenVerificacion)
                    .HasColumnName("token_verificacion")
                    .HasMaxLength(50);

                entity.Property(e => e.UsuarioVerificado)
                    .HasColumnName("usuario_verificado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Utilidad).HasColumnName("utilidad");
            });

            modelBuilder.Entity<UsuarioPedido>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioPedido);

                entity.ToTable("usuario_pedido");

                entity.Property(e => e.IdUsuarioPedido).HasColumnName("id_usuario_pedido");

                entity.Property(e => e.FechaPedido)
                    .HasColumnName("fecha_pedido")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.UsuarioPedido)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuario_pedido_empresa");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioPedido)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuario_pedido_usuario");
            });

            modelBuilder.Entity<UsuarioPedidoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioPedidoDetalle);

                entity.ToTable("usuario_pedido_detalle");

                entity.Property(e => e.IdUsuarioPedidoDetalle).HasColumnName("id_usuario_pedido_detalle");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodigoArticulo)
                    .IsRequired()
                    .HasColumnName("codigo_articulo")
                    .HasMaxLength(100);

                entity.Property(e => e.Coeficiente)
                    .HasColumnName("coeficiente")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DescripcionArticulo)
                    .IsRequired()
                    .HasColumnName("descripcion_articulo");

                entity.Property(e => e.IdUsuarioPedido).HasColumnName("id_usuario_pedido");

                entity.Property(e => e.PrecioLista)
                    .HasColumnName("precio_lista")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrecioListaPorCoeficientePorMedioIva)
                    .HasColumnName("precioLista_por_coeficiente_por_medioIva")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SnOferta).HasColumnName("sn_oferta");

                entity.Property(e => e.TxtDescFamilia)
                    .IsRequired()
                    .HasColumnName("txt_desc_familia")
                    .HasMaxLength(255);

                entity.Property(e => e.TxtDescMarca)
                    .IsRequired()
                    .HasColumnName("txt_desc_marca")
                    .HasMaxLength(100);

                entity.Property(e => e.Utilidad).HasColumnName("utilidad");

                entity.HasOne(d => d.IdUsuarioPedidoNavigation)
                    .WithMany(p => p.UsuarioPedidoDetalle)
                    .HasForeignKey(d => d.IdUsuarioPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuario_pedido_detalle_usuario_pedido");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
