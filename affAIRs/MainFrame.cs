using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace affAIRs
{
    public partial class MainFrame : Form
    {
        Controller controller;
        public MainFrame()
        {
            InitializeComponent();
            controller = new Controller();
            FillTable();
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'affAIRsDataSet2.SalesLine' table. You can move, or remove it, as needed.
            this.salesLineTableAdapter.Fill(this.affAIRsDataSet2.SalesLine);
            // TODO: This line of code loads data into the 'affAIRsDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.affAIRsDataSet1.Product);
            // TODO: This line of code loads data into the 'affAIRsDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.affAIRsDataSet.Product);

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void adminToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.affAIRsDataSet.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GetAllProducts()
        {
            SqlDataAdapter da = controller.GetAllProducts();
            DataTable data = new DataTable();
            da.Fill(data);
            ProductList.DataSource = data;
        }

    }
}
