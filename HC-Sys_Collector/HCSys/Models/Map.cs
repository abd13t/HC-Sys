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
        public static void AddMarker(PointLatLng pos, GMapControl MainMap, String tooltip, String id,bool redColor=false)
        {
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(pos.Lat, pos.Lng), redColor == false ? GMarkerGoogleType.green : GMarkerGoogleType.red);

            if (redColor)
                foreach (var item in terminal_request.LoadData(id))
                {
                    DateTime DateTime1 = Convert.ToDateTime(item.DateTime);
                    TimeSpan span = DateTime.Now - DateTime1;
                    marker.ToolTipText = marker.ToolTipText
                        + "Date Time : "
                        + span.ToString(@"hh\:mm") + Environment.NewLine
                        + "Terminal : "
                        + Convert.ToString(item.Description) + Environment.NewLine
                        + "Type : "
                        + Convert.ToString(item.rt) + Environment.NewLine
                        + "Querie : "
                        + Convert.ToString(item.req) + Environment.NewLine
                        + "---------------------------------------";
                  //  marker.ta = id;
                   // Int32.TryParse(id, out j)
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
