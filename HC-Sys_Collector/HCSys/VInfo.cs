using Dapper;
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
    public partial class VInfo : MaterialForm
    {
        public bool result;
        public string id;
        public VInfo()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            result = false;
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            result = true;
            Close();
        }

        private void VInfo_Shown(object sender, EventArgs e)
        {
            var FQuery = @"SELECT tr.Id,t.Description as trm,tr.DateTime,rt.Description_En As rt,r.Description_En AS req
                            FROM terminal_request tr
                            left join  terminal t on t.Id=tr.TerminalId
                            left join request r on r.Id=tr.Request_Id
                            left join request_type rt on rt.Id=r.RequestTypeid
                            WHERE tr.id=" + id + " AND tr.Is_Done=0 ORDER BY DateTime ASC";


            var data = Connexion.db.Query(FQuery).ToList();

            DateTime DateTime1 = Convert.ToDateTime(data[0].DateTime);
            string DateTime = DateTime1.ToString("dd/MM/yyy hh:mm");

            cxDate.Text = DateTime;
            cxreq.Text = data[0].req;
            cxterminale.Text = data[0].trm;
            cxType.Text = data[0].rt;
            
        }
    }
}
