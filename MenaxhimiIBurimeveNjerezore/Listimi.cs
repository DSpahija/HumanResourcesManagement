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
    public partial class Listimi : Form
    {
        public Listimi()
        {
            InitializeComponent();
        }

        private void LButton_ListaPunetore_Paint(object sender, PaintEventArgs e)
        {
            LButton_ListaPunetore.TabStop = false;
            LButton_ListaPunetore.FlatStyle = FlatStyle.Flat;
            LButton_ListaPunetore.FlatAppearance.BorderSize = 0;
            LButton_ListaPunetore.BackColor = Color.Teal;
        }

        public void AutoNumberRowsForGridView(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {
                for (int count = 0; (count <= (dataGridView.Rows.Count - 1)); count++)
                {
                    dataGridView.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
        }

        private void Listimi_Load(object sender, EventArgs e)
        {
            DataGridView_ListaPunetoreve.DataSource = Lista.ListaPunetoreve;
            AutoNumberRowsForGridView(DataGridView_ListaPunetoreve);
            RenditjaDataGrid();
        }
        
        public void RenditjaDataGrid()
        {

            DataGridView_ListaPunetoreve.Columns["Emri"].DisplayIndex = 0;
            DataGridView_ListaPunetoreve.Columns["Mbiemri"].DisplayIndex = 1;
            DataGridView_ListaPunetoreve.Columns["Datelindja"].DisplayIndex = 2;
            DataGridView_ListaPunetoreve.Columns["NrTelefonit"].DisplayIndex = 3;
            DataGridView_ListaPunetoreve.Columns["NrTelefonit"].HeaderText = "Numri Telefonit";
            DataGridView_ListaPunetoreve.Columns["NrTelefonit"].Width = 120;
            DataGridView_ListaPunetoreve.Columns["Kualifikimi"].DisplayIndex = 4;
            DataGridView_ListaPunetoreve.Columns["Departamenti"].DisplayIndex = 5;
            DataGridView_ListaPunetoreve.Columns["RrogaNetto"].DisplayIndex = 6;
            DataGridView_ListaPunetoreve.Columns.Remove("RrogaParaTatimit");
            DataGridView_ListaPunetoreve.Columns["Tatimi"].DisplayIndex = 7;
            DataGridView_ListaPunetoreve.Columns["Tatimi"].HeaderText = "Tatimi ne %";
            DataGridView_ListaPunetoreve.Columns["RrogaNetto"].DisplayIndex = 8;
            DataGridView_ListaPunetoreve.Columns["RrogaNetto"].HeaderText = "Rroga Neto";
            DataGridView_ListaPunetoreve.Columns["Pensioni"].HeaderText = "Pensioni ne %";
        }

        private void LButton_RegjistroPunetore_Click(object sender, EventArgs e)
        {
            Regjistrimi regjistrimi = new Regjistrimi();
            regjistrimi.FormClosed += Lista_FormClosed;
            regjistrimi.Show();
            this.Hide();
        }
        

        private void LButton_Departamenti_Click(object sender, EventArgs e)
        {
            DepartamentiForm departamenti = new DepartamentiForm();
            departamenti.FormClosed += Lista_FormClosed;
            departamenti.Show();
            this.Hide();
        }
        
        private void LButton_Trajnime_Click(object sender, EventArgs e)
        {
            TrajnimeForm trajnime = new TrajnimeForm();
            trajnime.FormClosed += Lista_FormClosed;
            trajnime.Show();
            this.Hide();
        }

        private void LButton_Pushime_Click(object sender, EventArgs e)
        {
            PushimeForm pushime = new PushimeForm();
            pushime.FormClosed += Lista_FormClosed;
            this.Hide();
            pushime.Show();
        }

        private void LButton_Kontrata_Click(object sender, EventArgs e)
        {
            KontrataForm kontrata = new KontrataForm();
            kontrata.FormClosed += Lista_FormClosed;
            kontrata.Show();
            this.Hide();
        }

        private void Lista_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private void DataGridView_ListaPunetoreve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGrid
        }

        private void Button_Kerko_Click(object sender, EventArgs e)
        {
            ////Nese osht if = true, ateher row qe e permban qat fjale tkolones  Emri list, shfaqe tjerat boni visible =0
            //string data = (string)DataGridView_ListaPunetoreve["Emri", 1].Value;
            //foreach (var Search in DataGridView_ListaPunetoreve.Data)
            //{
            //    if (data == TextBox_Kerko.Text)
            //    {
            //        Punetori punetori = (Punetori)DataGridView_ListaPunetoreve.CurrentRow.DataBoundItem;
            //        DataGridView_ListaPunetoreve.DataSource = punetori;
            //    }
            // }
        }

        private void TextBox_Kerko_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
