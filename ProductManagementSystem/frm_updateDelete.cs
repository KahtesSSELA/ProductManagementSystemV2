using ProductManagementSystem.AdapterPattern;
using ProductManagementSystem.BuilderPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProductManagementSystem
{
    public partial class frm_updateDelete : Form
    {
        public frm_updateDelete()
        {
            InitializeComponent();
        }

        private void frm_updateDelete_Load(object sender, EventArgs e)
        {
            tb_id.Enabled = false;

            KiloProduct kilo = new KiloProduct();
            LiquidProduct liquid = new LiquidProduct();

            cbox_productType.Items.Add(kilo.ProductType);
            cbox_productType.Items.Add(liquid.ProductType);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Adaptee adaptee = new Delete();
            ITarget target = new Adapter(adaptee);
            target.getRequest(tb_id.Text, tb_productName.Text, cbox_productType.Text, decimal.Parse(tb_price.Text));
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void btn_showProduct_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Adaptee adaptee = new Update();
            ITarget target = new Adapter(adaptee);
            target.getRequest(tb_id.Text, tb_productName.Text, cbox_productType.Text, decimal.Parse(tb_price.Text));
        }
    }
}
