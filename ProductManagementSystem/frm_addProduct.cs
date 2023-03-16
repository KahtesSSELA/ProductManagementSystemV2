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
    public partial class frm_addProduct : Form 
    {
        public frm_addProduct()
        {
            InitializeComponent();
        }

        private void frm_addProduct_Load(object sender, EventArgs e)
        {
            //Manufacturer manufacturer = new Manufacturer();
            //KiloProduct sugar = new KiloProduct("001", "sugar 1 kg", Convert.ToDecimal(1000));
            //LiquidProduct vital = new LiquidProduct("002", "Vital 0.5 L", Convert.ToDecimal(2000));
            //manufacturer.Build(sugar);
            //manufacturer.Build(vital);

            KiloProduct kilo = new KiloProduct();
            LiquidProduct liquid = new LiquidProduct();

            cbox_productType.Items.Add(kilo.ProductType);
            cbox_productType.Items.Add(liquid.ProductType);
        }

        private void btn_showProductList_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer();

            ProductBuilder builder;
            //KiloProduct sugar = new KiloProduct("001", "sugar 1 kg", Convert.ToDecimal(1000));
            //LiquidProduct vital = new LiquidProduct("002", "Vital 0.5 L", Convert.ToDecimal(2000));
            //manufacturer.Build(sugar);
            //manufacturer.Build(vital);
            switch (cbox_productType.Text)
            {
                case "Kilo Product":
                    
                    builder = new KiloProduct(tb_id.Text,tb_productName.Text,int.Parse(tb_price.Text));
                    manufacturer.Build(builder);
                    break;
                case "Liquid Product":
                    builder = new LiquidProduct(tb_id.Text, tb_productName.Text, int.Parse(tb_price.Text));
                    manufacturer.Build(builder);

                    break;

                default:
                    MessageBox.Show("Choose Product Type");
                    break;
            }
        }

        private void btn_showProductList_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer();

            ProductBuilder builder;
            //KiloProduct sugar = new KiloProduct("001", "sugar 1 kg", Convert.ToDecimal(1000));
            //LiquidProduct vital = new LiquidProduct("002", "Vital 0.5 L", Convert.ToDecimal(2000));
            //manufacturer.Build(sugar);
            //manufacturer.Build(vital);
            switch (cbox_productType.Text)
            {
                case "Kilo Product":

                    builder = new KiloProduct(tb_id.Text, tb_productName.Text, int.Parse(tb_price.Text));
                    manufacturer.Build(builder);
                    break;
                case "Liquid Product":
                    builder = new LiquidProduct(tb_id.Text, tb_productName.Text, int.Parse(tb_price.Text));
                    manufacturer.Build(builder);

                    break;

                default:
                    MessageBox.Show("Choose Product Type");
                    break;
            }
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
