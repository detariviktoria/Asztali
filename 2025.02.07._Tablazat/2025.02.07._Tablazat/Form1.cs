using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025._02._07._Tablazat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TablaBeallitasok();
            TablaAdatok();
        }

        private void TablaAdatok()
        {
            TablaDGV.Rows[0].Cells[0].Value = "0,0";
        }

        void TablaBeallitasok()
        {
            TablaDGV.RowCount = 10;
            TablaDGV.ColumnCount = 5;


            int magassag = 30;
            int szelesseg = 30;
            SorMagassagBeallitasa(30);
            OszlopSzelessegBeallitasa(30);
            TablaDGV.ColumnHeadersVisible = false;
            TablaDGV.RowHeadersVisible = false;

            TablaDGV.Width = TablaDGV.ColumnCount * szelesseg + 3;
            TablaDGV.Height = TablaDGV.RowCount * magassag + 3;
        }

        private void OszlopSzelessegBeallitasa(int v)
        {
            for (int i = 0; i<TablaDGV.RowCount; i++)
            {

            }
        }

        private void SorMagassagBeallitasa(int szelesseg)
        {
            for (int i = 0; i < TablaDGV.ColumnCount; i++)
            {
                TablaDGV.Columns[i].Width = szelesseg;
            }
        }
    }
}
