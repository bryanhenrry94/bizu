using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Dazzsoft.ERP.Infrastructure.Model.General;

namespace Dazzsoft.ERP.Infrastructure.Configurations.General
{
    public class TbEmpresaConfiguration : EntityTypeConfiguration<TbEmpresa>
    {
        public TbEmpresaConfiguration()
        {
            ToTable("tb_empresa", "public");

            HasKey(e => e.IdEmpresa);

            Property(e => e.IdEmpresa)
                .HasColumnName("idempresa");

            Property(e => e.Codigo)
                .HasColumnName("codigo")
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.EmNombre)
                .HasColumnName("em_nombre")
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.RazonSocial)
                .HasColumnName("razonsocial")
                .IsRequired()
                .HasMaxLength(300);

            Property(e => e.NombreComercial)
                .HasColumnName("nombrecomercial")
                .IsRequired()
                .HasMaxLength(300);

            Property(e => e.ContribuyenteEspecial)
                .HasColumnName("contribuyenteespecial")
                .HasMaxLength(5);

            Property(e => e.ObligadoALlevarConta)
                .HasColumnName("obligadoallevarconta")
                .IsRequired()
                .HasMaxLength(2);

            Property(e => e.EmRuc)
                .HasColumnName("em_ruc")
                .IsRequired()
                .HasMaxLength(13);

            Property(e => e.EmGerente)
                .HasColumnName("em_gerente")
                .HasMaxLength(50);

            Property(e => e.EmContador)
                .HasColumnName("em_contador")
                .HasMaxLength(150);

            Property(e => e.EmRucContador)
                .HasColumnName("em_ruccontador")
                .HasMaxLength(20);

            Property(e => e.EmTelefonos)
                .HasColumnName("em_telefonos")
                .HasMaxLength(100);

            Property(e => e.EmFax)
                .HasColumnName("em_fax")
                .HasMaxLength(20)
                .IsFixedLength();

            Property(e => e.EmNotificacion)
                .HasColumnName("em_notificacion");

            Property(e => e.EmDireccion)
                .HasColumnName("em_direccion")
                .IsRequired()
                .HasMaxLength(300);

            Property(e => e.EmTelInt)
                .HasColumnName("em_tel_int")
                .HasMaxLength(50);

            Property(e => e.EmLogo)
                .HasColumnName("em_logo");

            Property(e => e.EmFondo)
                .HasColumnName("em_fondo");

            Property(e => e.EmFechaInicioContable)
                .HasColumnName("em_fechainiciocontable");

            Property(e => e.Estado)
                .HasColumnName("estado")
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength();

            Property(e => e.EmFechaInicioActividad)
                .HasColumnName("em_fechainicioactividad");

            Property(e => e.CodEntidadDinardap)
                .HasColumnName("cod_entidad_dinardap")
                .HasMaxLength(50);

            Property(e => e.EmEmail)
                .HasColumnName("em_email")
                .HasMaxLength(300);

            Property(e => e.EmEmailContacto)
                .HasColumnName("em_email_contacto")
                .HasMaxLength(300);

            Property(e => e.SitioWeb)
                .HasColumnName("sitio_web")
                .HasMaxLength(300);

            Property(e => e.Trial228)
                .HasColumnName("trial228")
                .HasMaxLength(1)
                .IsFixedLength();
        }
    }
}