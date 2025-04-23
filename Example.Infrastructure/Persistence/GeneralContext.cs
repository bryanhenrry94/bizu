using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dazzsoft.ERP.Infrastructure.Configurations.General;
using Dazzsoft.ERP.Infrastructure.Model.General;

namespace Dazzsoft.ERP.Infrastructure.Persistence
{
    public class GeneralContext : DbContext
    {
        public GeneralContext() : base("name=DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Esta línea evita que use el esquema dbo
            modelBuilder.HasDefaultSchema("public"); // Usa "public", o cambia según el esquema real
            modelBuilder.Configurations.Add(new TbEmpresaConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TbEmpresa> TbEmpresa { get; set; }
        public DbSet<tb_Actividades_Horario> tb_Actividades_Horario { get; set; }
        public DbSet<tb_Actividades_Horario_Acciones> tb_Actividades_Horario_Acciones { get; set; }
        public DbSet<tb_Actividades_Horario_Tipo_Ejecucion> tb_Actividades_Horario_Tipo_Ejecucion { get; set; }
        public DbSet<tb_Actividades_Horario_Tipo_Tiempo> tb_Actividades_Horario_Tipo_Tiempo { get; set; }
        public DbSet<tb_banco> tb_banco { get; set; }
        public DbSet<tb_banco_estado_reg__resp_bancaria> tb_banco_estado_reg__resp_bancaria { get; set; }
        public DbSet<tb_banco_procesos_bancarios_tipo> tb_banco_procesos_bancarios_tipo { get; set; }
        public DbSet<tb_banco_procesos_bancarios_x_empresa> tb_banco_procesos_bancarios_x_empresa { get; set; }
        public DbSet<tb_bodega> tb_bodega { get; set; }
        public DbSet<tb_bodega_Filtro> tb_bodega_Filtro { get; set; }
        public DbSet<tb_Calendario> tb_Calendario { get; set; }
        public DbSet<tb_Catalogo> tb_Catalogo { get; set; }
        public DbSet<tb_CatalogoTipo> tb_CatalogoTipo { get; set; }
        public DbSet<tb_ciudad> tb_ciudad { get; set; }
        public DbSet<tb_Conexion_DBFacturacion_Electronica> tb_Conexion_DBFacturacion_Electronica { get; set; }
        public DbSet<tb_contacto> tb_contacto { get; set; }
        public DbSet<tb_dia> tb_dia { get; set; }
        public DbSet<tb_mes> tb_mes { get; set; }
        public DbSet<tb_modulo> tb_modulo { get; set; }
        public DbSet<tb_moneda> tb_moneda { get; set; }
        public DbSet<tb_pais> tb_pais { get; set; }
        public DbSet<tb_parametro> tb_parametro { get; set; }
        public DbSet<tb_parametro_tipo> tb_parametro_tipo { get; set; }
        public DbSet<tb_parroquia> tb_parroquia { get; set; }
        public DbSet<tb_persona> tb_persona { get; set; }
        public DbSet<tb_persona_direccion> tb_persona_direccion { get; set; }
        public DbSet<tb_persona_direccion_tipo> tb_persona_direccion_tipo { get; set; }
        public DbSet<tb_persona_tipo> tb_persona_tipo { get; set; }
        public DbSet<tb_provincia> tb_provincia { get; set; }
        public DbSet<tb_rango_fecha_busqueda_x_periodo> tb_rango_fecha_busqueda_x_periodo { get; set; }
        public DbSet<tb_region> tb_region { get; set; }
        public DbSet<tb_sis_Actualizaciones_x_tablas> tb_sis_Actualizaciones_x_tablas { get; set; }
        public DbSet<tb_sis_Datos_Sistema> tb_sis_Datos_Sistema { get; set; }
        public DbSet<tb_sis_Documento_Registros_x_Talonario> tb_sis_Documento_Registros_x_Talonario { get; set; }
        public DbSet<tb_sis_Documento_Tipo> tb_sis_Documento_Tipo { get; set; }
        public DbSet<tb_sis_Documento_Tipo_Reporte_x_Empresa> tb_sis_Documento_Tipo_Reporte_x_Empresa { get; set; }
        public DbSet<tb_sis_Documento_Tipo_Talonario> tb_sis_Documento_Tipo_Talonario { get; set; }
        public DbSet<tb_sis_Documento_Tipo_x_Empresa> tb_sis_Documento_Tipo_x_Empresa { get; set; }
        public DbSet<tb_sis_Documento_Tipo_x_Empresa_Anulados> tb_sis_Documento_Tipo_x_Empresa_Anulados { get; set; }
        public DbSet<tb_sis_Documento_Tipo_x_Secuencia_Talonario> tb_sis_Documento_Tipo_x_Secuencia_Talonario { get; set; }
        public DbSet<tb_sis_formulario> tb_sis_formulario { get; set; }
        public DbSet<tb_sis_Grupo_empresarial_Cliente> tb_sis_Grupo_empresarial_Cliente { get; set; }
        public DbSet<tb_sis_iconos> tb_sis_iconos { get; set; }
        public DbSet<tb_sis_Impuesto> tb_sis_Impuesto { get; set; }
        public DbSet<tb_sis_Impuesto_Tipo> tb_sis_Impuesto_Tipo { get; set; }
        public DbSet<tb_sis_Impuesto_x_ctacble> tb_sis_Impuesto_x_ctacble { get; set; }
        public DbSet<tb_sis_Log_Error_Vzen> tb_sis_Log_Error_Vzen { get; set; }
        public DbSet<tb_sis_Mensajes_sys> tb_sis_Mensajes_sys { get; set; }
        public DbSet<tb_sis_reporte> tb_sis_reporte { get; set; }
        public DbSet<tb_sis_reporte_Grupo> tb_sis_reporte_Grupo { get; set; }
        public DbSet<tb_sis_reporte_x_formulario> tb_sis_reporte_x_formulario { get; set; }
        public DbSet<tb_spSys_in_consulta_errores_frecuentes_eliminar_movimient1> tb_spSys_in_consulta_errores_frecuentes_eliminar_movimient1 { get; set; }
        public DbSet<tb_sucursal> tb_sucursal { get; set; }
        public DbSet<tb_tarjeta> tb_tarjeta { get; set; }
        public DbSet<tb_tarjeta_parametro> tb_tarjeta_parametro { get; set; }
        public DbSet<tb_transportista> tb_transportista { get; set; }
        public DbSet<vwtb_Bodega_x_Sucursal_TreeList> vwtb_Bodega_x_Sucursal_TreeList { get; set; }
        public DbSet<vwtb_bodega_x_tb_sucursal> vwtb_bodega_x_tb_sucursal { get; set; }
        public DbSet<vwtb_Ciudad> vwtb_Ciudad { get; set; }
        public DbSet<vwtb_contacto> vwtb_contacto { get; set; }
        public DbSet<vwtb_persona_beneficiario> vwtb_persona_beneficiario { get; set; }
        public DbSet<vwtb_persona_beneficiario_por_Banco_Acreditacion> vwtb_persona_beneficiario_por_Banco_Acreditacion { get; set; }
        public DbSet<vwtb_sis_Documento_Tipo_x_Disenio_Report> vwtb_sis_Documento_Tipo_x_Disenio_Report { get; set; }
        public DbSet<vwtb_sis_Documento_Tipo_x_Empresa_Anulados> vwtb_sis_Documento_Tipo_x_Empresa_Anulados { get; set; }
        public DbSet<vwtb_tb_banco_procesos_bancarios> vwtb_tb_banco_procesos_bancarios { get; set; }
        public DbSet<vwtb_tb_sis_Documento_Tipo_Talonario> vwtb_tb_sis_Documento_Tipo_Talonario { get; set; }
        public DbSet<vwtb_transportista_x_tb_persona> vwtb_transportista_x_tb_persona { get; set; }
        public DbSet<vwtb_Ubicacion_Geografica> vwtb_Ubicacion_Geografica { get; set; }
        public DbSet<vwGe_tb_sis_Documento_Tipo_Talonario> vwGe_tb_sis_Documento_Tipo_Talonario { get; set; }
        public DbSet<vwGe_tb_Tarjeta_tb_Parametro> vwGe_tb_Tarjeta_tb_Parametro { get; set; }
        public DbSet<tb_tarea> tb_tarea { get; set; }
        public DbSet<tb_tarea_equipo> tb_tarea_equipo { get; set; }
        public DbSet<tb_Conexion_Dashboard> tb_Conexion_Dashboard { get; set; }
        public DbSet<tb_ciiu> tb_ciiu { get; set; }
        public DbSet<tb_catastroGranContribuyente> tb_catastroGranContribuyente { get; set; }
        public DbSet<tb_ComprobantesRecibidos> tb_ComprobantesRecibidos { get; set; }
        public DbSet<tb_empresa> tb_empresa { get; set; }
        public DbSet<vwtb_empresa_x_Usuario> vwtb_empresa_x_Usuario { get; set; }

        public virtual ObjectResult<spSys_ObtenerFecha_SinFeriadoTampocoSabDom_Result> spSys_ObtenerFecha_SinFeriadoTampocoSabDom(Nullable<System.DateTime> p_FechaInicial, Nullable<int> p_Dias)
        {
            var p_FechaInicialParameter = p_FechaInicial.HasValue ?
                new ObjectParameter("p_FechaInicial", p_FechaInicial) :
                new ObjectParameter("p_FechaInicial", typeof(System.DateTime));

            var p_DiasParameter = p_Dias.HasValue ?
                new ObjectParameter("p_Dias", p_Dias) :
                new ObjectParameter("p_Dias", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSys_ObtenerFecha_SinFeriadoTampocoSabDom_Result>("spSys_ObtenerFecha_SinFeriadoTampocoSabDom", p_FechaInicialParameter, p_DiasParameter);
        }

        public virtual ObjectResult<spSys_Ge_Comparativo_Modulo_vs_Contas_Result> spSys_Ge_Comparativo_Modulo_vs_Contas(Nullable<int> p_IdEmpresa, Nullable<System.DateTime> p_fecha_ini, Nullable<System.DateTime> p_fecha_fin)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_fecha_iniParameter = p_fecha_ini.HasValue ?
                new ObjectParameter("p_fecha_ini", p_fecha_ini) :
                new ObjectParameter("p_fecha_ini", typeof(System.DateTime));

            var p_fecha_finParameter = p_fecha_fin.HasValue ?
                new ObjectParameter("p_fecha_fin", p_fecha_fin) :
                new ObjectParameter("p_fecha_fin", typeof(System.DateTime));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSys_Ge_Comparativo_Modulo_vs_Contas_Result>("spSys_Ge_Comparativo_Modulo_vs_Contas", p_IdEmpresaParameter, p_fecha_iniParameter, p_fecha_finParameter);
        }
    }
}
