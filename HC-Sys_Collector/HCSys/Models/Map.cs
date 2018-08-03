using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCSys.Models
{
    public class Map
    {
        public static GMapOverlay markersOverlay;
        public static GMapOverlay markersOverlay2;
        public static void AddMarker(PointLatLng pos, GMapControl MainMap, String id,bool redColor=false)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(pos.Lat, pos.Lng), redColor == false ? GMarkerGoogleType.green : GMarkerGoogleType.red);

            if (redColor)
               // foreach (var item in terminal_request.LoadData(id))
                {

                    DateTime DateTime1 = Convert.ToDateTime(terminal_request.LoadData(id)[0].DateTime);
                    TimeSpan span = DateTime.Now - DateTime1;

                    marker.ToolTipText = marker.ToolTipText+
                       Environment.NewLine + "Date Time : "
                        + span.ToString(@"hh\:mm") + Environment.NewLine
                        + "Terminal : "
                        + Convert.ToString(terminal_request.LoadData(id)[0].Description) + Environment.NewLine
                        + "Type : "
                        + Convert.ToString(terminal_request.LoadData(id)[0].rt) + Environment.NewLine
                        + "Querie : "
                        + Convert.ToString(terminal_request.LoadData(id)[0].req) + Environment.NewLine
                        + "---------------------------------------";
                    marker.Tag = terminal_request.LoadData(id)[0].Id;

                    
                }



            markersOverlay.Markers.Add(marker);
           // MainMap.Overlays.Add(markersOverlay);
        }


        public static void GoTo(PointLatLng pos, GMapControl MainMap)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            MainMap.Position = new PointLatLng(pos.Lat, pos.Lng);
        }

       public static  PointLatLng GetPos(MouseEventArgs e, GMapControl MainMap)
       {
         return MainMap.FromLocalToLatLng(e.X, e.Y);
       }
    }
}
