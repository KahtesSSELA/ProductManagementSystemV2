namespace ProductManagementSystem
{
    partial class frm_updateDelete
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.cbox_productType = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_showProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product  ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Product Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product Name";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(118, 142);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(481, 20);
            this.tb_price.TabIndex = 16;
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(118, 62);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(481, 20);
            this.tb_productName.TabIndex = 17;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(118, 22);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(481, 20);
            this.tb_id.TabIndex = 18;
            // 
            // cbox_productType
            // 
            this.cbox_productType.FormattingEnabled = true;
            this.cbox_productType.Location = new System.Drawing.Point(118, 103);
            this.cbox_productType.Name = "cbox_productType";
            this.cbox_productType.Size = new System.Drawing.Size(481, 21);
            this.cbox_productType.TabIndex = 23;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(524, 190);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "Delele";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(443, 190);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_showProduct
            // 
            this.btn_showProduct.Location = new System.Drawing.Point(316, 190);
            this.btn_showProduct.Name = "btn_showProduct";
            this.btn_showProduct.Size = new System.Drawing.Size(121, 23);
            this.btn_showProduct.TabIndex = 25;
            this.btn_showProduct.Text = "Show Product";
            this.btn_showProduct.UseVisualStyleBackColor = true;
            this.btn_showProduct.Click += new System.EventHandler(this.btn_showProduct_Click);
            // 
            // frm_updateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 225);
            this.Controls.Add(this.btn_showProduct);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cbox_productType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.tb_id);
            this.Name = "frm_updateDelete";
            this.Text = "frm_updateDelete";
            this.Load += new System.EventHandler(this.frm_updateDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.TextBox tb_price;
        public System.Windows.Forms.TextBox tb_productName;
        public System.Windows.Forms.TextBox tb_id;
        public System.Windows.Forms.ComboBox cbox_productType;
        private System.Windows.Forms.Button btn_showProduct;
    }
}