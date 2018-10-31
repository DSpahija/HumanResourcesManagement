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
    public partial class DepartamentiForm : Form
    {
        public DepartamentiForm()
        {
            InitializeComponent();
        }

        private void Button_Departamenti_Click(object sender, EventArgs e)
        {
            Button_Departamenti.TabStop = false;
            Button_Departamenti.FlatStyle = FlatStyle.Flat;
            Button_Departamenti.FlatAppearance.BorderSize = 0;
            Button_Departamenti.BackColor = Color.Teal;
        }

        private void Button_Regjistro_Click(object sender, EventArgs e)
        {
            //Bone me dy lista: 1 list = datasource, tjetra list items. add + items of lista1
            if (TextBox_DepartamentRegjistro.Text != String.Empty)
            {
                Departamenti departamenti = new Departamenti(TextBox_DepartamentRegjistro.Text);
                Lista.ShtoDepartamentin(departamenti);
                ListBox_Departamentet.Items.Add(TextBox_DepartamentRegjistro.Text);
                TextBox_DepartamentRegjistro.Text = String.Empty;
            }
        }

        private void DepartamentiForm_Load(object sender, EventArgs e)
        {
                ListBox_DepartamentetMsheft.DataSource = Lista.ListaDepartamenteve;
            for (int i = 0; i < ListBox_DepartamentetMsheft.Items.Count; i++)
            {
                ListBox_Departamentet.Items.Add(ListBox_DepartamentetMsheft.Items[i].ToString());
            }
        }

        private void DButton_RegjistroPunetore_Click(object sender, EventArgs e)
        {
            Regjistrimi regjistrimi = new Regjistrimi();
            regjistrimi.FormClosed += DepartamentiForm_FormClosed;
            regjistrimi.Show();
            this.Hide();
        }


        private void Button_ListaPunetoreve_Click(object sender, EventArgs e)
        {
            Listimi listimi = new Listimi();
            listimi.FormClosed += DepartamentiForm_FormClosed;
            listimi.Show();
            this.Hide();
        }

        private void DButton_Trajnime_Click(object sender, EventArgs e)
        {
            TrajnimeForm trajnime = new TrajnimeForm();
            trajnime.FormClosed += DepartamentiForm_FormClosed;
            trajnime.Show();
            this.Hide();
        }

        private void DButton_Pushime_Click(object sender, EventArgs e)
        {
            PushimeForm pushime = new PushimeForm();
            pushime.FormClosed += DepartamentiForm_FormClosed;
            this.Hide();
            pushime.Show();
        }

        private void DButton_Kontrata_Click(object sender, EventArgs e)
        {
            KontrataForm kontrata = new KontrataForm();
            kontrata.FormClosed += DepartamentiForm_FormClosed;
            kontrata.Show();
            this.Hide();
        }

        private void DepartamentiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Button_FshijDepartament_Click(object sender, EventArgs e)
        {
            //Departamenti departamentii = new Departamenti();
            //TypeConverter tipiDepartament = TypeDescriptor.GetConverter(departamentii);
            //tipi.ConvertFromString(emritekstit)
            if (ListBox_Departamentet.SelectedIndex != -1)
            {
                Departamenti departament = (Departamenti)ListBox_Departamentet.SelectedItem;
                Lista.FshijDepartament(departament);
                ListBox_Departamentet.DataSource = Lista.ListaDepartamenteve.ToList();
            }
        }
    }
}
