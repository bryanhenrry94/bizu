using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_Conexion_Dashboard_Data
    {

        public bool GrabarBD(tb_Conexion_Dashboard_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();

                tb_Conexion_Dashboard obj = new tb_Conexion_Dashboard();
                obj.Id = getID();
                obj.Provider = Info.Provider;
                obj.ServerName = Info.ServerName;
                obj.PortNumber = Info.PortNumber;
                obj.DatabaseName = Info.DatabaseName;
                obj.UserName = Info.UserName;
                obj.Password = Info.Password;
                obj.StringConnection = Info.StringConnection;

                context.tb_Conexion_Dashboard.Add(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tb_Conexion_Dashboard_Info Get_Conexion_Dashboard()
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();

                var query = from q in context.tb_Conexion_Dashboard select q;

                tb_Conexion_Dashboard_Info obj = new tb_Conexion_Dashboard_Info();

                foreach (var item in query)
                {
                    obj.Id = item.Id;
                    obj.Provider = item.Provider;
                    obj.ServerName = item.ServerName;
                    obj.PortNumber = item.PortNumber;
                    obj.DatabaseName = item.DatabaseName;
                    obj.UserName = item.UserName;
                    obj.Password = item.Password;
                    obj.StringConnection = item.StringConnection;
                }
                
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int getID()
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();

                var query = from q in context.tb_Conexion_Dashboard select q;                            

                if(query.Count() > 0)
                {
                    return query.Select(t => t.Id).Max() + 1;
                }

                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}