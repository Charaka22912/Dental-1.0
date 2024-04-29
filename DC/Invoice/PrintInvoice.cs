using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DC
{
    public partial class PrintInvoice : Form
    {
        private Bitmap panelBitmap;
        public PrintInvoice(string invoiceDate, decimal total, string sal, string name, DataTable dataGridViewData)
        {
            InitializeComponent();
            labledate.Text = invoiceDate;
            labelname.Text = name;
            lableTotal.Text = total.ToString();
            labelMrms.Text = sal;
            dataGridView1.DataSource = dataGridViewData;
        }
        public void loaddata()
        {

        }
        private void PrintInvoice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void CapturePanel()
        {
            panelBitmap = new Bitmap(panel1.Width, panel1.Height);

            panel1.DrawToBitmap(panelBitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap panelBitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(panelBitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage(panelBitmap, e.MarginBounds);
        }

        private void labledate_Click(object sender, EventArgs e)
        {

        }
    }
}
