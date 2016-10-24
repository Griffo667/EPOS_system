using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;

namespace Dissertation
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        public string myConn = "datasource=localhost;port=3306;username=root;password=";
        public string data = Form6.data;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string file = data + ".xls";
            Workbook wBook = new Workbook();
            int row = 0;
            int col = 0;
            string stemp = "";
            int count = 0;
            int totalRow = 0;

            foreach(DataTable dt in Form6.ds.Tables)
            {
                Worksheet wSheet = new Worksheet(data);

                foreach(DataColumn dc in dt.Columns)
                {
                    wSheet.Cells[row, col] = new Cell(dc.ColumnName);
                    col++;
                }
                row = 1;
                foreach(DataRow dr in dt.Rows)
                {
                    col = 0;
                    foreach(DataColumn dc in dt.Columns)
                    {
                        stemp = dr[dc.ColumnName].ToString();
                        wSheet.Cells[row, col] = new Cell(stemp);
                        col++;
                    }
                    row++;
                }
                wBook.Worksheets.Add(wSheet);
                totalRow = totalRow + row;
                row = 0;
                col = 0;
            }
            
            if(totalRow < 100)
            {
                Worksheet wSheet = new Worksheet("Sheet 2");
                count = 1;
                while(count < 100)
                {
                    wSheet.Cells[count, 0] = new Cell("");
                    count++;
                }
                wBook.Worksheets.Add(wSheet);
            }
            wBook.Save(file);
        }
    }
}
