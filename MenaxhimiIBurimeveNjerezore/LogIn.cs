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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Permbajtja_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


    private void LogIn_Paint(object sender, PaintEventArgs e)
        {
            Textbox_IDLogin.BorderStyle = BorderStyle.FixedSingle;
            Textbox_FjalekalimiLogin.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Button_KycuLogIn_Paint(object sender, PaintEventArgs e)
        {
            Button_KycuLogIn.TabStop = false;
            Button_KycuLogIn.FlatStyle = FlatStyle.Flat;
            Button_KycuLogIn.FlatAppearance.BorderSize = 0;
            Button_KycuLogIn.FlatAppearance.BorderColor = Color.Teal;
        }

        private void Button_KycuLogIn_Click(object sender, EventArgs e)
        {
            if (Textbox_IDLogin.Text == "")
            {
                if (Textbox_FjalekalimiLogin.Text == "")
                {
                    Permbajtja permbajtja = new Permbajtja();
                    permbajtja.FormClosed += Permbajtja_FormClosed;
                    permbajtja.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ju lutem shkruani informatat e sakta!");
                }
            }
            else
            {
                MessageBox.Show("Ju lutem shkruani informatat e sakta!");
            }
        }
    }
}
