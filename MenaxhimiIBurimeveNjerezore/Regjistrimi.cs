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
    public partial class Regjistrimi : Form
    {

        public Regjistrimi()
        {
            InitializeComponent();
        }


        private void RButton_RegjistroPunetore_Paint(object sender, PaintEventArgs e)
        {
            RButton_RegjistroPunetore.TabStop = false;
            RButton_RegjistroPunetore.FlatStyle = FlatStyle.Flat;
            RButton_RegjistroPunetore.FlatAppearance.BorderSize = 0;
            RButton_RegjistroPunetore.BackColor = Color.Teal;
        }
        

        private void Button_Regjistro_Click(object sender, EventArgs e)
        {
            // Departamenti departamenti = new Departamenti();
            // Trajnimi trajnimi = new Trajnimi();
            //TypeConverter tipiDepartament = TypeDescriptor.GetConverter(departamenti);
            //TypeConverter tipiTrajnim = TypeDescriptor.GetConverter(trajnimi);

            Punetori punetori = new Punetori(TextBox_IDRegjistro.Text, TextBox_EmriRegjistro.Text, TextBox_MbiemriRegjistro.Text, DateTime_DatelindjaRegjistro.Value, TextBox_NumriTelRegjistro.Text, ComboBox_KualifikimiRegjistro.Text, double.Parse(TextBox_RrogaBrutoRegjistro.Text), double.Parse(ComboBox_PensioniRegjistro.Text), double.Parse(TextBox_RrogaNetoRegjistro.Text), double.Parse(TextBox_TatimiRegjistro.Text), ComboBox_DepartamentiRegjistro.Text);
            Lista.ShtoPunetorin(punetori);
            Punetori._IDPunetori++;

            Pushimi pushimi = new Pushimi(TextBox_IDRegjistro.Text, TextBox_EmriRegjistro.Text + " " + TextBox_MbiemriRegjistro.Text, 20, 20, 7, 3, 0);
            Lista.ShtoPushimet(pushimi);

            Permbajtja permbajtja = new Permbajtja();
            permbajtja.FormClosed += Regjistrimi_FormClosed;
            permbajtja.Show();
            this.Hide();

        }
        private void Regjistrimi_Load(object sender, EventArgs e)
        {
            Punetori idpunetori = new Punetori();
            TextBox_IDRegjistro.Text = idpunetori.IDMetode();
            ComboBox_DepartamentiRegjistro.DataSource = Lista.ListaDepartamenteve;
            ComboBox_PensioniRegjistro.SelectedIndex = 0;
            ComboBox_KualifikimiRegjistro.SelectedIndex = 0;
        }

        private void TextBox_RrogaBrutoRegjistro_TextChanged(object sender, EventArgs e)
        {
            if(TextBox_RrogaBrutoRegjistro.Text == String.Empty)
            {
                TextBox_RrogaBrutoRegjistro.Text = 0.ToString();
            }

            double RrogaBruto = double.Parse(TextBox_RrogaBrutoRegjistro.Text);
            Punetori punetoriRroga = new Punetori(RrogaBruto, double.Parse(ComboBox_PensioniRegjistro.Text));
            TextBox_RrogaNetoRegjistro.Text = punetoriRroga.LlogaritjaRrogaNetto(punetoriRroga.RrogaParaTatimit, punetoriRroga.Tatimi).ToString();
            TextBox_TatimiRegjistro.Text = punetoriRroga.Tatimi.ToString();

        }

        private void RButton_ListaPunetoreve_Click(object sender, EventArgs e)
        {
            Listimi listimi = new Listimi();
            listimi.FormClosed += Regjistrimi_FormClosed;
            listimi.Show();
            this.Hide();
        }
        

        private void RButton_Departamenti_Click(object sender, EventArgs e)
        {
            DepartamentiForm departamenti = new DepartamentiForm();
            departamenti.FormClosed += Regjistrimi_FormClosed;
            departamenti.Show();
            this.Hide();
        }
        
        private void RButton_Trajnime_Click(object sender, EventArgs e)
        {
            TrajnimeForm trajnime = new TrajnimeForm();
            trajnime.FormClosed += Regjistrimi_FormClosed;
            trajnime.Show();
            this.Hide();
        }
        
        private void RButton_Pushime_Click(object sender, EventArgs e)
        {
            PushimeForm pushime = new PushimeForm();
            pushime.FormClosed += Regjistrimi_FormClosed;
            this.Hide();
            pushime.Show();
        }

        private void RButton_Kontrata_Click(object sender, EventArgs e)
        {
            KontrataForm kontrata = new KontrataForm();
            kontrata.FormClosed += Regjistrimi_FormClosed;
            kontrata.Show();
            this.Hide();
        }

        private void Regjistrimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_RrogaBrutoRegjistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBox_EmriRegjistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_NumriTelRegjistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
