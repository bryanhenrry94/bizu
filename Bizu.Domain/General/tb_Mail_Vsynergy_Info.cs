using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.General
{
    public class tb_Mail_Vsynergy_Info
    {
        public int IdEmpresa { get; set; }
        public int IdMail { get; set; }
        public string Origen { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public List<string> To { get; set; }
        public List<string> CC { get; set; }
        public List<string> Files_Path { get; set; }

        public tb_Mail_Vsynergy_Info()
        {
            this.To = new List<string>();
            this.CC = new List<string>();
            this.Files_Path = new List<string>();
        }
    }
}