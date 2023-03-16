using ProductManagementSystem.BuilderPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementSystem
{ 
    public partial class frm_Cart : Form
    {
        public List<string> productName = new List<string>();
        public List<string> productPrice= new List<string>();

        public frm_Cart()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frm_Cart_Load(object sender, EventArgs e)
        {
            decimal total= 0;
            for (int i = 0; i < productName.Count; i++)
            {
                string name = productName[i];
                string price = productPrice[i];
                listBox1.Items.Add(name + " " + price);
            }
            foreach (var item in productPrice)
            {
                total += decimal.Parse(item);
            }
            label1.Text = total.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Receipt frm = new Frm_Receipt();
            foreach (var item in listBox1.Items)
            {
                frm.orderLst.Add(item.ToString());
            }
            frm.Show();
            this.Hide();
        }
    }
}
