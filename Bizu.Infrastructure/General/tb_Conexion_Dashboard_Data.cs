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

                tb_conexion_dashboard obj = new tb_conexion_dashboard();
                obj.id = getID();
                obj.provider = Info.Provider;
                obj.servername = Info.ServerName;
                obj.portnumber = Info.PortNumber;
                obj.databasename = Info.DatabaseName;
                obj.username = Info.UserName;
                obj.password = Info.Password;
                obj.stringconnection = Info.StringConnection;

                context.tb_conexion_dashboard.Add(obj);
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

                var query = from q in context.tb_conexion_dashboard select q;

                tb_Conexion_Dashboard_Info obj = new tb_Conexion_Dashboard_Info();

                foreach (var item in query)
                {
                    obj.Id = item.id;
                    obj.Provider = item.provider;
                    obj.ServerName = item.servername;
                    obj.PortNumber = item.portnumber;
                    obj.DatabaseName = item.databasename;
                    obj.UserName = item.username;
                    obj.Password = item.password;
                    obj.StringConnection = item.stringconnection;
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

                var query = from q in context.tb_conexion_dashboard select q;                            

                if(query.Count() > 0)
                {
                    return query.Select(t => t.id).Max() + 1;
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