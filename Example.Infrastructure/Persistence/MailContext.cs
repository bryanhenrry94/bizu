using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dazzsoft.ERP.Infrastructure.Model.Mail;

namespace Dazzsoft.ERP.Infrastructure.Persistence
{
    public class MailContext : DbContext
    {
        public MailContext() : base("name=DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Esta línea evita que use el esquema dbo
            modelBuilder.HasDefaultSchema("public"); // Usa "public", o cambia según el esquema real

            base.OnModelCreating(modelBuilder);
        }

        public void SetCommandTimeOut(int TimeOut)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = TimeOut;
        }

        internal DbSet<mail_Cuenta_Correo> mail_Cuenta_Correo { get; set; }
        public DbSet<mail_Mail> mail_Mail { get; set; }
        public DbSet<mail_Mail_Attachment> mail_Mail_Attachment { get; set; }
        public DbSet<mail_Plantilla_Mensaje> mail_Plantilla_Mensaje { get; set; }
        public DbSet<mail_Notificacion_Config> mail_Notificacion_Config { get; set; }
    }
}
