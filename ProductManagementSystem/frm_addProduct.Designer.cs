namespace ProductManagementSystem
{
    partial class frm_addProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbox_productType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_showProductList = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_productType
            // 
            this.cbox_productType.FormattingEnabled = true;
            this.cbox_productType.Location = new System.Drawing.Point(128, 99);
            this.cbox_productType.Name = "cbox_productType";
            this.cbox_productType.Size = new System.Drawing.Size(481, 21);
            this.cbox_productType.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product  ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(128, 138);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(481, 20);
            this.tb_price.TabIndex = 6;
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(128, 58);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(481, 20);
            this.tb_productName.TabIndex = 7;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(128, 18);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(481, 20);
            this.tb_id.TabIndex = 8;
            // 
            // btn_showProductList
            // 
            this.btn_showProductList.Location = new System.Drawing.Point(341, 164);
            this.btn_showProductList.Name = "btn_showProductList";
            this.btn_showProductList.Size = new System.Drawing.Size(187, 23);
            this.btn_showProductList.TabIndex = 4;
            this.btn_showProductList.Text = "Show Product List";
            this.btn_showProductList.UseVisualStyleBackColor = true;
            this.btn_showProductList.Click += new System.EventHandler(this.btn_showProductList_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(534, 164);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // frm_addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 205);
            this.Controls.Add(this.cbox_productType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_showProductList);
            this.Controls.Add(this.btn_add);
            this.Name = "frm_addProduct";
            this.Text = "frm_addProduct";
            this.Load += new System.EventHandler(this.frm_addProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_productType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_showProductList;
        private System.Windows.Forms.Button btn_add;
    }
}