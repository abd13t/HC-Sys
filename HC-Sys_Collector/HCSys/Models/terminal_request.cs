using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSys.Models
{
    public class terminal_request
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public DateTime DateTime { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int Request_Id { get; set; }
        public bool Is_Done { get; set; }

        public static List<terminal_request> RefreshDataListe()
        {
            var FQuery = "SELECT * FROM terminal_request";
            return Connexion.db.Query<terminal_request>(FQuery).ToList();
        }

        public static List<dynamic> LoadData(string filter,bool all=false)
        {
            var FQuery = @"SELECT tr.id, t.Description,tr.DateTime,rt.Description_En
                            FROM terminal_request tr
                            left join  terminal t on t.Id=tr.TerminalId
                            left join request r on r.Id=tr.Request_Id
                            left join request_type rt on rt.Id=r.RequestTypeid WHERE tr.Is_Done=0 AND  rt.Description_En LIKE '%"+filter+ "%'  ORDER BY  r.Priority DESC,tr.DateTime ASC";
            return Connexion.db.Query(FQuery).ToList();
        }

        public static dynamic GetDiscription(string id)
        {
            var FQuery = @"SELECT r.Description_En,tr.Longitude,tr.Latitude
                            FROM terminal_request tr
                            left join request r on r.Id=tr.Request_Id
                            WHERE tr.Id=" + id;
            return Connexion.db.Query(FQuery).ToList(); ;
        }

        public static List<dynamic> LoadData(string id)
        {
            var FQuery = @"SELECT tr.Id,t.Description,tr.DateTime,rt.Description_En As rt,r.Description_En AS req
                            FROM terminal_request tr
                            left join  terminal t on t.Id=tr.TerminalId
                            left join request r on r.Id=tr.Request_Id
                            left join request_type rt on rt.Id=r.RequestTypeid
                            WHERE tr.TerminalId=" + id+ " AND tr.Is_Done=0 ORDER BY r.Priority DESC, DateTime ASC ";

            return Connexion.db.Query(FQuery).ToList();
        }
    }
}
