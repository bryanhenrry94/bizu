using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dazzsoft.ERP.Infrastructure.Model.Seguridad;

namespace Dazzsoft.ERP.Infrastructure.Persistence
{
    public class SeguridadContext : DbContext
    {
        public SeguridadContext() : base("name=DefaultConnection") { }
        
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Esta línea evita que use el esquema dbo
            modelBuilder.HasDefaultSchema("public"); // Usa "public", o cambia según el esquema real

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<seg_Menu_x_Empresa> seg_Menu_x_Empresa { get; set; }
        public DbSet<seg_Menu_x_Empresa_x_Usuario> seg_Menu_x_Empresa_x_Usuario { get; set; }
        public DbSet<seg_Usuario_x_Empresa> seg_Usuario_x_Empresa { get; set; }
        public DbSet<vw_Seg_Menu_x_Usuario_x_Empresa> vw_Seg_Menu_x_Usuario_x_Empresa { get; set; }
        public DbSet<vwseg_Usuario_x_Empresa> vwseg_Usuario_x_Empresa { get; set; }
        public DbSet<seg_Menu> seg_Menu { get; set; }
        public DbSet<seg_Menu_Grupo> seg_Menu_Grupo { get; set; }
        public DbSet<seg_Menu_Item_Tipo> seg_Menu_Item_Tipo { get; set; }
        public DbSet<seg_Menu_Pagina> seg_Menu_Pagina { get; set; }
        public DbSet<seg_Menu_Categoria> seg_Menu_Categoria { get; set; }
        public DbSet<seg_Menu_Grupo_x_seg_Menu_Item> seg_Menu_Grupo_x_seg_Menu_Item { get; set; }
        public DbSet<seg_Menu_Item> seg_Menu_Item { get; set; }
        public DbSet<seg_usuario_x_tb_sis_reporte> seg_usuario_x_tb_sis_reporte { get; set; }
        public DbSet<vwseg_usuario_x_tb_sis_reporte> vwseg_usuario_x_tb_sis_reporte { get; set; }
        public DbSet<seg_usuario> seg_usuario { get; set; }
    }

}
