using ProductManagementSystem.AdapterPattern;
using ProductManagementSystem.BuilderPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlCommand cmd;
        SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-C1548M6R\\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True");
        SqlDataAdapter adapt;


        private void Form1_Load(object sender, EventArgs e)
        {
           

            DisplayData();
        }

        private void DisplayData()
        {
            sqlCon.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Product2", sqlCon);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO need to change Cell[i] , check datagrid
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string prodtype = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            decimal price = decimal.Parse(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            Adaptee adaptee = new Delete();
            ITarget target = new Adapter(adaptee);
            target.getRequest(id, name, prodtype, price);
            DisplayData();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            frm_addProduct addProduct = new frm_addProduct();
            addProduct.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            frm_updateDelete updateDelete = new frm_updateDelete();
            updateDelete.tb_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDelete.tb_productName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDelete.cbox_productType.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateDelete.tb_price.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDelete.Show();
            this.Hide();
        }
        public List<string> names = new List<string>();
        public List<string> prices = new List<string>();

        private void btn_addTOCart_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string prodtype = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            decimal price = decimal.Parse(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
           
            names.Add(name);
            prices.Add(price.ToString());
        }

        private void btn_ShowCart_Click(object sender, EventArgs e)
        {
            frm_Cart cart = new frm_Cart();

            cart.productName = names;
            cart.productPrice = prices;

            this.Hide();
            cart.Show();
        }
    }
}
