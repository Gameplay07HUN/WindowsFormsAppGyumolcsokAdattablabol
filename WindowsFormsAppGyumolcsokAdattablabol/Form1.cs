using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGyumolcsokAdattablabol
{
    public partial class Form1 : Form
    {
        Database db = new Database("localhost","root","","gyumolcsok");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewGyumolcsokFelepitese();
            dataGridViewGyumolcsokUpdate();
        }

        private void dataGridViewGyumolcsokUpdate()
        {
            dataGridViewGyumolcsok.Rows.Clear();
            foreach(Gyumolcs rekord in db.getAllGyumolcs())
            {
                //--rekord adatának beírása egy sor celláiba ------------
                int sorIndex = dataGridViewGyumolcsok.Rows.Add();
                DataGridViewRow getUjSor = dataGridViewGyumolcsok.Rows[sorIndex];//-- kiolvassuk
                getUjSor.Cells["id"].Value = rekord.Id;
                getUjSor.Cells["nev"].Value = rekord.Nev;
                getUjSor.Cells["egysegar"].Value = rekord.Egysegar;
                getUjSor.Cells["mennyiseg"].Value = rekord.Mennyiseg;

            }
        }

        private void dataGridViewGyumolcsokFelepitese()
        {
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {
                //-- col_ID jellemzőinek a beállítása -------------
                col_ID.Name = "id";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Azonosító";
            }
            dataGridViewGyumolcsok.Columns.Add(col_ID);
            DataGridViewColumn col_Nev = new DataGridViewColumn();
            {
                col_Nev.Name = "nev";
                col_Nev.HeaderText = "Gyümölcs neve";
                col_Nev.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridViewGyumolcsok.Columns.Add(col_Nev);
            DataGridViewColumn col_Mennyiseg = new DataGridViewColumn();
            {
                col_Mennyiseg.CellTemplate=new DataGridViewTextBoxCell();
                col_Mennyiseg.HeaderText = "Mennyiség";
                col_Mennyiseg.Name = "mennyiseg";
            }
            dataGridViewGyumolcsok.Columns.Add(col_Mennyiseg);
            DataGridViewColumn col_Egysegar = new DataGridViewColumn();
            {
                col_Egysegar.CellTemplate = new DataGridViewTextBoxCell();
                col_Egysegar.HeaderText = "Egyégár";
                col_Egysegar.Name = "egysegar";
            }
            dataGridViewGyumolcsok.Columns.Add(col_Egysegar);
            //-- Egész táblázatra vonatkozó beállítások --------------
            dataGridViewGyumolcsok.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewGyumolcsok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewGyumolcsok_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow rekord= dataGridViewGyumolcsok.SelectedRows[0];
            if (rekord.Cells["id"].Value==null)
            {
                return;
            }
            else
            {
                textBoxGyumolcsnev.Text = rekord.Cells["nev"].Value.ToString();
                textBoxId.Text = rekord.Cells["id"].Value.ToString();
                numericUpDownEgysegar.Value = decimal.Parse(rekord.Cells["egysegar"].Value.ToString());
                numericUpDownMennyiseg.Value = decimal.Parse(rekord.Cells["mennyiseg"].Value.ToString());
            }
        }
    }
}
