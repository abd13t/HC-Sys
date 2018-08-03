using Dapper;
using GMap.NET;
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
    public partial class Main : MaterialForm
    {
        public Main()
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
            PoupulateMainMap(true);
            RefreshGridRequest();
            Map.GoTo(new PointLatLng(21.4224973, 39.8266955), gMapControl1);
            Map.GoTo(new PointLatLng(21.4224973, 39.8266955), gMapControl2);
            timer1.Enabled = true;
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            var FQuery = @"SELECT rt.Description_En
                            FROM request_type rt where Is_actif=1";
             var data=Connexion.db.Query(FQuery).ToList();
            foreach (var item in data)
            {
                cxtypeFilter.Items.Add(item.Description_En);
            }
        }

        private void RefreshGridRequest()
        {
            materialListView1.Items.Clear();
            var list = terminal_request.LoadData(cxtypeFilter.Text,false);
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

        private void PoupulateMainMap(bool all)
        {
            PointLatLng pos = gMapControl1.Position;
            Map.markersOverlay.Markers.Clear();
            gMapControl1.Refresh();

            foreach (Terminal terminal in Terminal.RefreshDataListe())
            {
                if(all)
                Map.AddMarker( new PointLatLng(terminal.Latitude,terminal.Longitude),gMapControl1, terminal.Id.ToString(), Terminal.HasRequest(terminal.Id) );
                else
                    if (Terminal.HasRequest(terminal.Id))
                    Map.AddMarker(new PointLatLng(terminal.Latitude, terminal.Longitude), gMapControl1, terminal.Id.ToString(), true);
            }

            gMapControl1.Refresh();
            gMapControl1.Position = pos;
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
                ListViewItem item = materialListView1.SelectedItems[0];
                gMapControl2.Overlays.Remove(Map.markersOverlay2);
                cxterminale.Text = item.SubItems[1].Text;
                cxType.Text = item.SubItems[2].Text;
                cxDate.Text = item.SubItems[3].Text;
                var Data = terminal_request.GetDiscription(item.SubItems[0].Text);
                cxreq.Text = Convert.ToString(Data[0].Description_En);
                Map.markersOverlay2 = new GMapOverlay(item.SubItems[0].Text);
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Data[0].Latitude), Convert.ToDouble(Data[0].Longitude)),GMarkerGoogleType.red);
                Map.markersOverlay2.Markers.Add(marker);
                gMapControl2.Overlays.Add(Map.markersOverlay2);
                Map.GoTo(new PointLatLng(Convert.ToDouble(Data[0].Latitude),Convert.ToDouble(Data[0].Longitude)), gMapControl2);
              
            }
            catch (Exception r)
            {
               // MessageBox.Show(r.ToString());
            }
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            PoupulateMainMap(!cxCheckGrinMarks.Checked);
        }


        

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Map.GoTo(new PointLatLng(21.4224973, 39.8266955), gMapControl1);
        }


        //On MArk Clique
        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
             if(((GMap.NET.WindowsForms.Markers.GMarkerGoogle)item).Type == GMarkerGoogleType.red)
            {
                //DialogResult dialogResult= MessageBox.Show("Done the Query?","HCSys",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                //if (dialogResult == DialogResult.OK)
                //{
                //    var FQuery = "UPDATE terminal_request SET Is_Done=1 WHERE Id=@Id";
                //    Connexion.db.Execute(FQuery, new {Id = ((GMap.NET.WindowsForms.Markers.GMarkerGoogle)item).Tag });

                //    PoupulateMainMap(!cxCheckGrinMarks.Checked);
                //}

                VInfo vInfo = new VInfo();
                vInfo.id = ((GMap.NET.WindowsForms.Markers.GMarkerGoogle)item).Tag.ToString();
                vInfo.ShowDialog();
                if (vInfo.result == true)
                {
                    var FQuery = "UPDATE terminal_request SET Is_Done=1 WHERE Id=@Id";
                    Connexion.db.Execute(FQuery, new { Id = ((GMap.NET.WindowsForms.Markers.GMarkerGoogle)item).Tag });
                    PoupulateMainMap(!cxCheckGrinMarks.Checked);
                }



            }
        }



        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Done the Query?", "HCSys", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    gMapControl2.Overlays.Remove(Map.markersOverlay2);
                    ListViewItem item = materialListView1.SelectedItems[0];
                    var FQuery = "UPDATE terminal_request SET Is_Done=1 WHERE Id=@Id";
                    Connexion.db.Execute(FQuery, new { Id = item.SubItems[0].Text });
                    var Data = terminal_request.GetDiscription(item.SubItems[0].Text);
                    Map.markersOverlay2 = new GMapOverlay(item.SubItems[0].Text);
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng( Convert.ToDouble(Data[0].Latitude), Convert.ToDouble(Data[0].Longitude)), GMarkerGoogleType.red);
                    Map.markersOverlay2.Markers.Add(marker);
                    gMapControl2.Overlays.Add(Map.markersOverlay2);
                    Map.GoTo(new PointLatLng( Convert.ToDouble(Data[0].Latitude), Convert.ToDouble(Data[0].Longitude)), gMapControl2);
                    RefreshGridRequest();
                }
            }
            catch (Exception)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //RefreshGridRequest();
             PoupulateMainMap(!cxCheckGrinMarks.Checked);
        }

        private void materialListView1_Click(object sender, EventArgs e)
        {
           // RefreshGridRequest();
           
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridRequest();
        }

        private void cxtypeFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshGridRequest();
        }
    }
}
