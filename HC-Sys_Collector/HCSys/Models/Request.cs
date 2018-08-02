using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSys.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int QueryTypeid { get; set; }
        public string Description_En { get; set; }
        public string Desciption_Ar { get; set; }
        public string Description_Urdo { get; set; }

        public static List<Request> RefreshDataListe()
        {
            var FQuery = "SELECT * FROM request";
            return Connexion.db.Query<Request>(FQuery).ToList();
        }
    }
}
