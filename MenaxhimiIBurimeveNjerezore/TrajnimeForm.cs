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
    public partial class TrajnimeForm : Form
    {
        //Cilt punetor te regjjistruar kane kry trajnim 
        public TrajnimeForm()
        {
            InitializeComponent();
        }

        private void TrajnimeForm_Load(object sender, EventArgs e)
        {
            DataGridView_Trajnimet.DataSource = Lista.ListaTrajnimeve;
            DataGridView_Trajnimet.Columns["EmriPlote"].DisplayIndex = 0;
            DataGridView_Trajnimet.Columns["EmriPlote"].HeaderText = "Emri dhe Mbiemri";
            DataGridView_Trajnimet.Columns["Departamenti"].DisplayIndex = 1;
            DataGridView_Trajnimet.Columns["DataFillimit"].DisplayIndex = 2;
            DataGridView_Trajnimet.Columns["DataFillimit"].HeaderText = "Data e fillimit";
            DataGridView_Trajnimet.Columns["DataPerfundimit"].DisplayIndex = 3;
            DataGridView_Trajnimet.Columns["DataPerfundimit"].HeaderText = "Data e perfundimit";
            DataGridView_Trajnimet.Columns["Pagesa"].DisplayIndex = 4;

            //Ndreqja e width, Height tkolonave
            DataGridView_Trajnimet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DataGridView_Trajnimet.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridView_Trajnimet.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;


        }


        private void TButton_Trajnime_Click(object sender, EventArgs e)
        {
            TButton_Trajnime.TabStop = false;
            TButton_Trajnime.FlatStyle = FlatStyle.Flat;
            TButton_Trajnime.FlatAppearance.BorderSize = 1;
            TButton_Trajnime.FlatAppearance.BorderColor = Color.Teal;
        }

        private void TButton_RegjistroPunetore_Click(object sender, EventArgs e)
        {
            Regjistrimi regjistrimi = new Regjistrimi();
            regjistrimi.FormClosed += Trajnime_FormClosed;
            regjistrimi.Show();
            this.Hide();
        }

        private void TButton_ListaPunetoreve_Click(object sender, EventArgs e)
        {
            Listimi listimi = new Listimi();
            listimi.FormClosed += Trajnime_FormClosed;
            listimi.Show();
            this.Hide();
        }

        private void TButton_Departamenti_Click(object sender, EventArgs e)
        {
            DepartamentiForm departamenti = new DepartamentiForm();
            departamenti.FormClosed += Trajnime_FormClosed;
            departamenti.Show();
            this.Hide();
        }

        private void TButton_Pushime_Click(object sender, EventArgs e)
        {
            PushimeForm pushime = new PushimeForm();
            pushime.FormClosed += Trajnime_FormClosed;
            pushime.Show();
            this.Hide();
        }

        private void TButton_Kontrata_Click(object sender, EventArgs e)
        {
            KontrataForm kontrata = new KontrataForm();
            kontrata.FormClosed += Trajnime_FormClosed;
            kontrata.Show();
            this.Hide();
        }

        private void Trajnime_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Button_RegjistroTrajnime_Click(object sender, EventArgs e)
        {
            TrajnimeForm_Regjistrimi regjistrimi = new TrajnimeForm_Regjistrimi();
            regjistrimi.FormClosed += Trajnime_FormClosed;
            regjistrimi.Show();
            this.Hide();
        }

        private void DateTime_DataEPerfundimit_ValueChanged(object sender, EventArgs e)
        {
            //964, 652 size of form
        }

        private void Button_FshijTrajnime_Click(object sender, EventArgs e)
        {
            if (DataGridView_Trajnimet.CurrentRow != null)
            {
                Trajnimi trajnimi = (Trajnimi)DataGridView_Trajnimet.CurrentRow.DataBoundItem;
                Lista.FshijTrajnimin(trajnimi);
                DataGridView_Trajnimet.DataSource = Lista.ListaTrajnimeve.ToList();
            }
        }
    }
}
