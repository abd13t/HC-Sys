using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSys.Models
{
    public class Terminal
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public bool Is_Locked { get; set; }
        public string MacAdress { get; set; }
        public string Ip_adress { get; set; }
        public DateTime Last_Check { get; set; }


        public static List<Terminal> RefreshDataListe()
        {
            var FQuery = "SELECT * FROM terminal";
            return Connexion.db.Query<Terminal>(FQuery).ToList();
        }

        public static bool HasRequest(int idTerminal)
        {
            var FQuery = "SELECT Id FROM terminal_request WHERE Is_Done=0 and TerminalId="+idTerminal;
            var result= Connexion.db.QueryFirstOrDefault(FQuery);
            return Connexion.db.Query<int>(FQuery).ToList().Count()>0;
        }
    }
}
