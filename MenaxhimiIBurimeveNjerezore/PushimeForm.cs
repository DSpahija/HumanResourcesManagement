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
    public partial class PushimeForm : Form
    {
        public PushimeForm()
        {
            InitializeComponent();
        }


        private void PushimeForm_Load(object sender, EventArgs e)
        {
            ComboBox_EmMbPunetori.DataSource = Lista.ListaPunetoreve;
            ComboBox_EmMbPunetori.SelectedIndex = -1;
            TextBox_DitetMbetura.Text = "0";
            TextBox_DitetShfrytezuara.Text = "0";
        }
        
       
        private void PButton_Pushime_Click(object sender, EventArgs e)
        {
            PButton_Pushime.TabStop = false;
            PButton_Pushime.FlatStyle = FlatStyle.Flat;
            PButton_Pushime.FlatAppearance.BorderSize = 1;
            PButton_Pushime.FlatAppearance.BorderColor = Color.Teal;
        }

        private void PButton_RegjistroPunetore_Click(object sender, EventArgs e)
        {
            Regjistrimi regjistrimi = new Regjistrimi();
            regjistrimi.FormClosed += Pushime_FormClosed;
            regjistrimi.Show();
            this.Hide();
        }

        private void PButton_ListaPunetoreve_Click(object sender, EventArgs e)
        {
            Listimi listimi = new Listimi();
            listimi.FormClosed += Pushime_FormClosed;
            listimi.Show();
            this.Hide();
        }

        private void PButton_Departamenti_Click(object sender, EventArgs e)
        {
            DepartamentiForm departamenti = new DepartamentiForm();
            departamenti.FormClosed += Pushime_FormClosed;
            departamenti.Show();
            this.Hide();
        }

        private void PButton_Trajnime_Click(object sender, EventArgs e)
        {
            TrajnimeForm trajnime = new TrajnimeForm();
            trajnime.FormClosed += Pushime_FormClosed;
            trajnime.Show();
            this.Hide();
        }

        private void PButton_Kontrata_Click(object sender, EventArgs e)
        {
            KontrataForm kontrata = new KontrataForm();
            kontrata.FormClosed += Pushime_FormClosed;
            kontrata.Show();
            this.Hide();
        }

        private void Pushime_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ComboBox_EmMbPunetori_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TextBox_PushimiVjetore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComboBox_Pushimet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vlera1 = Lista.ListaPushimeve.Find(s => s.tostring() == ComboBox_EmMbPunetori.Text);

            switch (ComboBox_Pushimet.SelectedIndex)
            {
                case 0:
                    {
                        TextBox_DitetMbetura.Text = vlera1.PushimiVjetorDitet.ToString();
                        int vlera = 20 - Int32.Parse(TextBox_DitetMbetura.Text);
                        TextBox_DitetShfrytezuara.Text = vlera.ToString();
                        Label_DitetMbetura.Visible = true;
                        TextBox_DitetMbetura.Visible = true;
                    }
                    break;
                case 1:
                    {
                        TextBox_DitetMbetura.Text = vlera1.PushimiMjekesorDitet.ToString();
                        int vlera = 20 - Int32.Parse(TextBox_DitetMbetura.Text);
                        TextBox_DitetShfrytezuara.Text = vlera.ToString();
                        Label_DitetMbetura.Visible = true;
                        TextBox_DitetMbetura.Visible = true;
                    }
                    break;
                case 2:
                    {
                        TextBox_DitetMbetura.Text = vlera1.PushimiMartesorDitet.ToString();
                        int vlera = 7 - Int32.Parse(TextBox_DitetMbetura.Text);
                        TextBox_DitetShfrytezuara.Text = vlera.ToString();
                        Label_DitetMbetura.Visible = true;
                        TextBox_DitetMbetura.Visible = true;
                    }
                    break;
                case 3:
                    {
                        TextBox_DitetMbetura.Text = vlera1.RastVdekjeDitet.ToString();
                        int vlera = 3 - Int32.Parse(TextBox_DitetMbetura.Text);
                        TextBox_DitetShfrytezuara.Text = vlera.ToString();
                        Label_DitetMbetura.Visible = true;
                        TextBox_DitetMbetura.Visible = true;
                    }
                    break;
                case 4:
                    {
                        TextBox_DitetShfrytezuara.Text = vlera1.UdhetimZyrtar.ToString();
                        Label_DitetMbetura.Visible = false;
                        TextBox_DitetMbetura.Visible = false;
                    }
                    break;
            }
        }

        public void Totali()
        {

            int ditaPrej = Int32.Parse(ComboBox_DitaPrej.Text);
            int muajiPrej = Int32.Parse(ComboBox_MuajiPrej.Text);
            int vitiPrej = Int32.Parse(TextBox_VitiPrej.Text);
            int ditaDeri = Int32.Parse(ComboBox_DitaDeri.Text);
            int muajiDeri = Int32.Parse(ComboBox_MuajiDeri.Text);
            int vitiDeri = Int32.Parse(TextBox_VitiDeri.Text);

            int indexiFundit1 = ComboBox_DitaPrej.Items.Count - 1;
            int NrFunditPrej = Int32.Parse(ComboBox_DitaPrej.Items[indexiFundit1].ToString());

            int indexFundit2 = ComboBox_DitaDeri.Items.Count - 1;
            int NrFunditDeri = Int32.Parse(ComboBox_DitaDeri.Items[indexFundit2].ToString());

            int ditetTotal =(ditaDeri+(muajiDeri* NrFunditDeri) + (vitiDeri*365)) -(ditaPrej + (muajiPrej*NrFunditPrej) + (vitiPrej*365));
            TextBox_Ditet.Text = ditetTotal.ToString();
            //30 dhjetor 2016 deri me 10 janar 2017   (30 + 360(12*30) + 2016*12*30) = 726'150   10 + 30 + 2017*12*30
        }

        private void TextBox_VitiDeri_TextChanged(object sender, EventArgs e)
        {
            Totali();
        }

        private void ComboBox_MuajiPrej_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Janar,Mars,Maj,Korrik, Gusht, Tetor, dhjetor = 31 dite (1,3,5,7 - 8,10,12)
            //Prill, Qershor, Shtator, Nentore = 30 dite  (4,6 - 9,11)
            //Shkurt = 28 => vit i brisht 29 (IsLeapYear();)
            if (ComboBox_MuajiPrej.SelectedIndex == 1)
            {
                ComboBox_DitaPrej.Items.Remove(29);
                ComboBox_DitaPrej.Items.Remove(30);
                ComboBox_DitaPrej.Items.Remove(31);
            }

            if (ComboBox_MuajiPrej.SelectedIndex == 0 || ComboBox_MuajiPrej.SelectedIndex == 2 || ComboBox_MuajiPrej.SelectedIndex ==4 ||ComboBox_MuajiPrej.SelectedIndex == 6 || ComboBox_MuajiPrej.SelectedIndex ==7 || ComboBox_MuajiPrej.SelectedIndex == 9 || ComboBox_MuajiPrej.SelectedIndex ==11)
            {
                ComboBox_DitaPrej.Items.Add(31);
            }
            else
            {
                ComboBox_DitaPrej.Items.Remove(31);
            }
        }

        private void ComboBox_MuajiDeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_MuajiDeri.SelectedIndex == 1)
            {
                ComboBox_DitaDeri.Items.Remove(29);
                ComboBox_DitaDeri.Items.Remove(30);
                ComboBox_DitaDeri.Items.Remove(31);
            }

            if (ComboBox_MuajiDeri.SelectedIndex == 0 || ComboBox_MuajiDeri.SelectedIndex == 2 || ComboBox_MuajiDeri.SelectedIndex == 4 || ComboBox_MuajiDeri.SelectedIndex == 6 || ComboBox_MuajiDeri.SelectedIndex == 7 || ComboBox_MuajiDeri.SelectedIndex == 9 || ComboBox_MuajiDeri.SelectedIndex == 11)
            {
                ComboBox_DitaDeri.Items.Add(31);
            }

            else
            {
                ComboBox_DitaDeri.Items.Remove(31);
            }
        }
        
        private void Button_RuajPushime_Click(object sender, EventArgs e)
        {
            var vlera1 = Lista.ListaPunetoreve.Find(s => s.ToString() == ComboBox_EmMbPunetori.Text);
            string IdPunetori = vlera1.FullID;
            

            switch (ComboBox_Pushimet.SelectedIndex)
            {
                case 0:
                    {
                        int kushti = Int32.Parse(TextBox_Ditet.Text);
                        if (kushti > 20)
                        {
                            MessageBox.Show("Pushimi vjetor ka vetem 20 dite!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        if (kushti < 0)
                        {
                            MessageBox.Show("Gabim ne date!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        else
                        {

                            Permbajtja permbajtja = new Permbajtja();
                            permbajtja.FormClosed += PushimeForm_FormClosed;
                            permbajtja.Show();
                            this.Hide();

                            int totaliVjetor = Int32.Parse(TextBox_DitetMbetura.Text) - Int32.Parse(TextBox_Ditet.Text);
                            Pushimi pushimi = Lista.ListaPushimeve.Where(w => w._PunetoriEmri == ComboBox_EmMbPunetori.Text).First();
                            pushimi.PushimiVjetorDitet = totaliVjetor;
                        }
                    }
                    break;
                case 1:
                    {
                        int kushti = Int32.Parse(TextBox_Ditet.Text);
                        int ditet = Int32.Parse(TextBox_DitetMbetura.Text);
                        if (kushti > ditet )
                        {
                            MessageBox.Show("Pushimi Mjekesore ka vetem 20 dite!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        if(kushti < 0)
                        {
                            MessageBox.Show("Gabim ne date!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        else
                        {
                            int totaliMjekesore = Int32.Parse(TextBox_DitetMbetura.Text) - Int32.Parse(TextBox_Ditet.Text);
                            Pushimi pushimi = Lista.ListaPushimeve.Where(w => w._PunetoriEmri == ComboBox_EmMbPunetori.Text).First();
                            pushimi.PushimiMjekesorDitet = totaliMjekesore;


                            Permbajtja permbajtja = new Permbajtja();
                            permbajtja.FormClosed += PushimeForm_FormClosed;
                            permbajtja.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 2:
                    {
                        int kushti = Int32.Parse(TextBox_Ditet.Text);
                        int ditet = Int32.Parse(TextBox_DitetMbetura.Text);
                        if (kushti > ditet)
                        {
                            MessageBox.Show("Pushimi Martesore ka vetem 7 dite!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        if (kushti < 0)
                        {
                            MessageBox.Show("Gabim ne date!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        else
                        {
                            int totaliMartesore = Int32.Parse(TextBox_DitetMbetura.Text) - Int32.Parse(TextBox_Ditet.Text);
                            Pushimi pushimi = Lista.ListaPushimeve.Where(w => w._PunetoriEmri == ComboBox_EmMbPunetori.Text).First();
                            pushimi.PushimiMartesorDitet = totaliMartesore;


                            Permbajtja permbajtja = new Permbajtja();
                            permbajtja.FormClosed += PushimeForm_FormClosed;
                            permbajtja.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 3:
                    {
                        int kushti = Int32.Parse(TextBox_Ditet.Text);
                        int ditet = Int32.Parse(TextBox_DitetMbetura.Text);
                        if (kushti > ditet)
                        {
                            MessageBox.Show("Ne rast vdekje, merren vetem 3 dite!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        if (kushti < 0)
                        {
                            MessageBox.Show("Gabim ne date!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        else
                        {
                            int rastVdekje = Int32.Parse(TextBox_DitetMbetura.Text) - Int32.Parse(TextBox_Ditet.Text);
                            Pushimi pushimi = Lista.ListaPushimeve.Where(w => w._PunetoriEmri == ComboBox_EmMbPunetori.Text).First();
                            pushimi.RastVdekjeDitet = rastVdekje;


                            Permbajtja permbajtja = new Permbajtja();
                            permbajtja.FormClosed += PushimeForm_FormClosed;
                            permbajtja.Show();
                            this.Hide();
                        }
                    }
                    break;
                case 4:
                    {
                        int kushti = Int32.Parse(TextBox_Ditet.Text);
                        if (kushti < 0)
                        {
                            MessageBox.Show("Gabim ne date!");
                            TextBox_Ditet.Text = String.Empty;
                        }
                        else
                        {
                            int udhetimZyrtar = Int32.Parse(TextBox_Ditet.Text);
                            Pushimi pushimi = Lista.ListaPushimeve.Where(w => w._PunetoriEmri == ComboBox_EmMbPunetori.Text).First();
                            pushimi.UdhetimZyrtar = udhetimZyrtar;


                            Permbajtja permbajtja = new Permbajtja();
                            permbajtja.FormClosed += PushimeForm_FormClosed;
                            permbajtja.Show();
                            this.Hide();
                        }
                    }
                    break;
            }        
        }
        private void PushimeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
