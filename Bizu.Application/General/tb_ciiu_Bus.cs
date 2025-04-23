using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.General
{
    public class tb_ciiu_Bus
    {
        public List<tb_ciiu_Info> GetList()
        {
            tb_ciiu_Data Data = new tb_ciiu_Data();
            List<tb_ciiu_Info> Lista = new List<tb_ciiu_Info>();
            Lista = Data.GetList();





            return Lista;
        }

    }
}
