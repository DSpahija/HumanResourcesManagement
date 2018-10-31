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
    public partial class TrajnimeForm_Regjistrimi : Form
    {

        public TrajnimeForm_Regjistrimi()
        {
            InitializeComponent();
              
        }

        private void Button_RegjistroTrajnime_Click(object sender, EventArgs e)
        {
            Trajnimi trajnimi = new Trajnimi(ComboBox_PunetoretTrajnim.Text,ComboBox_DepartamentiTrajnim.Text, DateTime_DataENisjes.Value, DateTime_DataEPerfundimit.Value, double.Parse(TextBox_PagesaTrajnim.Text), TextBox_Kompania.Text);
            Lista.ShtoTrajnimin(trajnimi);
            TrajnimeForm trajnime = new TrajnimeForm();
            trajnime.FormClosed += Trajnime_FormClosed;
            trajnime.Show();
            this.Hide();
        }

        private void Trajnime_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void TrajnimeForm_Regjistrimi_Load(object sender, EventArgs e)
        {
            ComboBox_PunetoretTrajnim.DataSource = Lista.ListaPunetoreve;
            ComboBox_DepartamentiTrajnim.DataSource = Lista.ListaDepartamenteve;
        }

        private void Button_AnuloTrajnime_Click(object sender, EventArgs e)
        {
            TrajnimeForm trajnime = new TrajnimeForm();
            trajnime.FormClosed += TrajnimeForm_Regjistrimi_FormClosed;
            trajnime.Show();
            this.Hide();
        }

        private void TrajnimeForm_Regjistrimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
