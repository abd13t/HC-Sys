using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using HCSys.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCSys
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<PointLatLng> MinaPos = new List<PointLatLng>();
            MinaPos.Add(new PointLatLng(21.4134136, 39.8858391));
            MinaPos.Add(new PointLatLng(21.413797, 39.8859668));
            MinaPos.Add(new PointLatLng(21.4138481, 39.8899042));
            MinaPos.Add(new PointLatLng(21.41344, 39.8905418));
            MinaPos.Add(new PointLatLng(21.4183354, 39.8960524));

            Map.GoTo(MinaPos.First(), gMapControl1);
            for (int i = 0; i < MinaPos.Count; i++)
            {
              Map.AddMarker(MinaPos[i], gMapControl1, "Mina " + i+1, i.ToString(),i==1);
            }

            List<PointLatLng> HaramPos = new List<PointLatLng>();
            HaramPos.Add(new PointLatLng(21.4231482, 39.8262788));
            HaramPos.Add(new PointLatLng(21.4230128, 39.8240566));
            for (int i = 0; i < HaramPos.Count; i++)
            {

                Map.AddMarker(HaramPos[i], gMapControl1, "Haram " + i+1, i.ToString());
            }


        }

        private void gMapControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            MessageBox.Show(item.ToolTipText);
        }
    }
}
