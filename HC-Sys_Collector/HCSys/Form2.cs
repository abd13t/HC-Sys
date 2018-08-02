﻿using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using HCSys.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCSys
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            Map.markersOverlay = new GMapOverlay("dd");
            Map.markersOverlay2 = new GMapOverlay("ddd");
            gMapControl1.Overlays.Add(Map.markersOverlay);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            gMapControl2.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            PoupulateMainMap();
            RefreshGridRequest();
            Map.GoTo(new PointLatLng(21.4224973, 39.8266955), gMapControl1);
            Map.GoTo(new PointLatLng(21.4224973, 39.8266955), gMapControl2);
        }


        private void RefreshGridRequest()
        {
            var list = terminal_request.LoadData();
            foreach (var version in list)
            {
                string Id = Convert.ToString(version.id);
                string Description = Convert.ToString(version.Description);
                DateTime DateTime1 = Convert.ToDateTime(version.DateTime);
                string DateTime = DateTime1.ToString("dd/MM/yyy hh:mm");
                string Description_En = Convert.ToString(version.Description_En);
                var item = new ListViewItem(new[] { Id, Description, Description_En, DateTime });
                materialListView1.Items.Add(item);
            }
        }

        private void PoupulateMainMap()
        {
            foreach (Terminal terminal in Terminal.RefreshDataListe())
            {
                Map.AddMarker( new PointLatLng(terminal.Latitude,terminal.Longitude),gMapControl1,"", terminal.Id.ToString(), Terminal.HasRequest(terminal.Id) );
            }
        }

    
        private void cxSatelite_CheckedChanged(object sender, EventArgs e)
        {  
            if (cxSatelite.Checked)
                gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            else
                gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; 
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gMapControl2.Overlays.Remove(Map.markersOverlay2);
                ListViewItem item = materialListView1.SelectedItems[0];
                cxterminale.Text = item.SubItems[1].Text;
                cxType.Text = item.SubItems[2].Text;
                cxDate.Text = item.SubItems[3].Text;
                var Data = terminal_request.GetDiscription(item.SubItems[0].Text);
                cxreq.Text = Convert.ToString(Data[0].Description_En);
                Map.markersOverlay2 = new GMapOverlay(item.SubItems[0].Text);
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Data[0].Longitude), Convert.ToDouble(Data[0].Latitude)),GMarkerGoogleType.red);
                Map.markersOverlay2.Markers.Add(marker);
                gMapControl2.Overlays.Add(Map.markersOverlay2);
                Map.GoTo(new PointLatLng(Convert.ToDouble(Data[0].Longitude), Convert.ToDouble(Data[0].Latitude)), gMapControl2);
            }
            catch (Exception)
            {

            }
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //gMapControl1.Overlays.Remove(Map.markersOverlay);
            PointLatLng pos = gMapControl1.Position;
            Map.markersOverlay.Markers.Clear();
            gMapControl1.Refresh();

            List<Terminal> terminals = Terminal.RefreshDataListe();
            if (cxCheckGrinMarks.Checked)
                foreach (Terminal terminal in terminals)
                {
                    if (Terminal.HasRequest(terminal.Id))
                        Map.AddMarker(new PointLatLng(terminal.Latitude, terminal.Longitude), gMapControl1,"", terminal.Id.ToString(), Terminal.HasRequest(terminal.Id));
                }
            else

                foreach (Terminal terminal in terminals)
                {
                    Map.AddMarker(new PointLatLng(terminal.Latitude, terminal.Longitude), gMapControl1, "", terminal.Id.ToString(), Terminal.HasRequest(terminal.Id));
                }
            gMapControl1.Refresh();
            gMapControl1.Position = pos;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Map.GoTo(new PointLatLng(21.4224973, 39.8266955), gMapControl1);
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
             if(((GMap.NET.WindowsForms.Markers.GMarkerGoogle)item).Type == GMarkerGoogleType.red)
            {
                DialogResult dialogResult= MessageBox.Show("Done the Query?","HCSys",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    //FQuery = "UPDATE Document_tags SET x=@x WHERE DocumentId=@Id";
                    //Connexion.db.Execute(FQuery, new { x = "123", Id = AID });
                }
            }
        }
    }
}
