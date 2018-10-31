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
    public partial class Permbajtja : Form
    {
        public Permbajtja()
        {
            InitializeComponent();
        }
     

        private void Button_RegjistroPunetore_Paint(object sender, PaintEventArgs e)
        {

            Button_RegjistroPunetore.TabStop = false;
            Button_RegjistroPunetore.FlatStyle = FlatStyle.Flat;
            Button_RegjistroPunetore.FlatAppearance.BorderSize = 1;
            Button_RegjistroPunetore.FlatAppearance.BorderColor = Color.Teal;
        }

        private void Button_RegjistroPunetore_Click(object sender, EventArgs e)
        {
            Regjistrimi regjistrimi = new Regjistrimi();
            regjistrimi.FormClosed += Permbajtja_FormClosed;
            regjistrimi.Show();
            this.Hide();
        }
        

        private void Button_ListaPunetoreve_Click(object sender, EventArgs e)
        {
            Listimi listimi = new Listimi();
            listimi.FormClosed += Permbajtja_FormClosed;
            listimi.Show();
            this.Hide();
        }
        private void Button_Departamenti_Click(object sender, EventArgs e)
        {
            DepartamentiForm departamenti = new DepartamentiForm();
            departamenti.FormClosed += Permbajtja_FormClosed;
            departamenti.Show();
            this.Hide();
        }
        

        private void Button_Trajnime_Click(object sender, EventArgs e)
        {
            TrajnimeForm trajnime = new TrajnimeForm();
            trajnime.FormClosed += Permbajtja_FormClosed;
            trajnime.Show();
            this.Hide();
        }
        

        private void Button_Pushime_Click(object sender, EventArgs e)
        {
            PushimeForm pushime = new PushimeForm();
            pushime.FormClosed += Permbajtja_FormClosed;
            this.Hide();
            pushime.Show();
        }

        private void Button_Kontrata_Click(object sender, EventArgs e)
        {
            KontrataForm kontrata = new KontrataForm();
            kontrata.FormClosed += Permbajtja_FormClosed;
            kontrata.Show();
            this.Hide();
        }

        private void Permbajtja_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
