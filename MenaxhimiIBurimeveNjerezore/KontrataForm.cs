using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiIBurimeveNjerezore
{
    public partial class KontrataForm : Form
    {
        public KontrataForm()
        {
            InitializeComponent();
        }
        //Kena me marr prej punetorit emrin, mbiemrin, kualifikimin, departamentin, Rrogen Bruto

        private void KButton_Kontrata_Click(object sender, EventArgs e)
        {
            KButton_Kontrata.TabStop = false;
            KButton_Kontrata.FlatStyle = FlatStyle.Flat;
            KButton_Kontrata.FlatAppearance.BorderSize = 1;
            KButton_Kontrata.FlatAppearance.BorderColor = Color.Teal;
        }

        private void KButton_RegjistroPunetore_Click_1(object sender, EventArgs e)
        {
            Regjistrimi regjistrimi = new Regjistrimi();
            regjistrimi.FormClosed += Regjistrimi_FormClosed;
            regjistrimi.Show();
            this.Hide();
        }

        private void Regjistrimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void KButton_ListaPunetoreve_Click_1(object sender, EventArgs e)
        {
            Listimi listimi = new Listimi();
            listimi.FormClosed += Listimi_FormClosed;
            listimi.Show();
            this.Hide();
        }

        private void Listimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void KButton_Departamenti_Click(object sender, EventArgs e)
        {
            DepartamentiForm departamenti = new DepartamentiForm();
            departamenti.FormClosed += DepartamentiForm_FormClosed;
            departamenti.Show();
            this.Hide();
        }

        private void DepartamentiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void KButton_Trajnime_Click(object sender, EventArgs e)
        {
            TrajnimeForm trajnime = new TrajnimeForm();
            trajnime.FormClosed += TrajnimeForm_FormClosed;
            trajnime.Show();
            this.Hide();
        }

        private void TrajnimeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void KButton_Pushime_Click(object sender, EventArgs e)
        {
            PushimeForm pushime = new PushimeForm();
            pushime.FormClosed += PushimeForm_FormClosed;
            this.Hide();
            pushime.Show();
        }

        private void PushimeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void KontrataForm_Load(object sender, EventArgs e)
        {
            //ComboBox_EmriPunedhenesit.DataSource = Lista.ListaPunedhenesve;
            Label_DataSot.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            ComboBox_EmMbPunetoritK.DataSource = Lista.ListaPunetoreve;
        }

        private void Button_PrintoKontraten_Click(object sender, EventArgs e)
        {
            Kontrata kontrata = new Kontrata(ComboBox_EmMbPunetoritK.Text, ComboBox_EmriPunedhenesit.Text, TextBox_DepartamentiK.Text, Label_DataSot.Text, DateTime_DataEFillimitK.Value, DateTime_DataPerfundimitK.Value, TextBox_KualifikimiK.Text, TextBox_RrogaBrutoK.Text);
            Kontrata.GjeneroKontrate(kontrata);
        }

        private void ComboBox_EmMbPunetoritK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string EmriMbiemriCmb = ComboBox_EmMbPunetoritK.Text;
            var vlera1 = Lista.ListaPunetoreve.Find(item => item.ToString() == EmriMbiemriCmb);
            TextBox_KualifikimiK.Text = vlera1.Kualifikimi;
            TextBox_DepartamentiK.Text = vlera1.Departamenti;
            TextBox_RrogaBrutoK.Text = vlera1.RrogaBruto.ToString();
        }
    }
}
