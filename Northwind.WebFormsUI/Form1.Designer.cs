namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCUnitPrice = new System.Windows.Forms.Label();
            this.lblCQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblCProductCategoryId = new System.Windows.Forms.Label();
            this.lblCStock = new System.Windows.Forms.Label();
            this.lblCPorductName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUCategoryId = new System.Windows.Forms.ComboBox();
            this.txtUQuantity = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.txtUStock = new System.Windows.Forms.TextBox();
            this.txtUPrice = new System.Windows.Forms.TextBox();
            this.txtUProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(9, 114);
            this.dgwProduct.MultiSelect = false;
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProduct.Size = new System.Drawing.Size(954, 167);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(254, 96);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(198, 32);
            this.btnProductAdd.TabIndex = 1;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btProductAdd_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(91, 25);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(347, 20);
            this.txtProduct.TabIndex = 2;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategoryName);
            this.gbxCategory.Location = new System.Drawing.Point(9, 26);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(479, 71);
            this.gbxCategory.TabIndex = 3;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategori Seç";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(89, 25);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(336, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(20, 28);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Kategori";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.lblProductName);
            this.gbxProduct.Controls.Add(this.txtProduct);
            this.gbxProduct.Location = new System.Drawing.Point(481, 26);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(482, 71);
            this.gbxProduct.TabIndex = 4;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürün Adına Göre Ara";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(22, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCategoryId);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.btnProductAdd);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.lblCUnitPrice);
            this.groupBox1.Controls.Add(this.lblCQuantityPerUnit);
            this.groupBox1.Controls.Add(this.lblCProductCategoryId);
            this.groupBox1.Controls.Add(this.lblCStock);
            this.groupBox1.Controls.Add(this.lblCPorductName);
            this.groupBox1.Location = new System.Drawing.Point(9, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(86, 61);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(118, 21);
            this.cbxCategoryId.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(334, 61);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(118, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(334, 26);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(118, 20);
            this.txtStock.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(86, 96);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(118, 20);
            this.txtUnitPrice.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(86, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(118, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // lblCUnitPrice
            // 
            this.lblCUnitPrice.AutoSize = true;
            this.lblCUnitPrice.Location = new System.Drawing.Point(19, 99);
            this.lblCUnitPrice.Name = "lblCUnitPrice";
            this.lblCUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblCUnitPrice.TabIndex = 7;
            this.lblCUnitPrice.Text = "Fiyat";
            // 
            // lblCQuantityPerUnit
            // 
            this.lblCQuantityPerUnit.AutoSize = true;
            this.lblCQuantityPerUnit.Location = new System.Drawing.Point(251, 64);
            this.lblCQuantityPerUnit.Name = "lblCQuantityPerUnit";
            this.lblCQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblCQuantityPerUnit.TabIndex = 6;
            this.lblCQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblCProductCategoryId
            // 
            this.lblCProductCategoryId.AutoSize = true;
            this.lblCProductCategoryId.Location = new System.Drawing.Point(19, 64);
            this.lblCProductCategoryId.Name = "lblCProductCategoryId";
            this.lblCProductCategoryId.Size = new System.Drawing.Size(46, 13);
            this.lblCProductCategoryId.TabIndex = 5;
            this.lblCProductCategoryId.Text = "Kategori";
            // 
            // lblCStock
            // 
            this.lblCStock.AutoSize = true;
            this.lblCStock.Location = new System.Drawing.Point(251, 29);
            this.lblCStock.Name = "lblCStock";
            this.lblCStock.Size = new System.Drawing.Size(59, 13);
            this.lblCStock.TabIndex = 4;
            this.lblCStock.Text = "Stok Adedi";
            // 
            // lblCPorductName
            // 
            this.lblCPorductName.AutoSize = true;
            this.lblCPorductName.Location = new System.Drawing.Point(17, 29);
            this.lblCPorductName.Name = "lblCPorductName";
            this.lblCPorductName.Size = new System.Drawing.Size(48, 13);
            this.lblCPorductName.TabIndex = 3;
            this.lblCPorductName.Text = "Ürün Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveProduct);
            this.groupBox2.Controls.Add(this.cmbUCategoryId);
            this.groupBox2.Controls.Add(this.txtUQuantity);
            this.groupBox2.Controls.Add(this.btnProductUpdate);
            this.groupBox2.Controls.Add(this.txtUStock);
            this.groupBox2.Controls.Add(this.txtUPrice);
            this.groupBox2.Controls.Add(this.txtUProductName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(494, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 142);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle";
            // 
            // cmbUCategoryId
            // 
            this.cmbUCategoryId.FormattingEnabled = true;
            this.cmbUCategoryId.Location = new System.Drawing.Point(86, 61);
            this.cmbUCategoryId.Name = "cmbUCategoryId";
            this.cmbUCategoryId.Size = new System.Drawing.Size(118, 21);
            this.cmbUCategoryId.TabIndex = 2;
            // 
            // txtUQuantity
            // 
            this.txtUQuantity.Location = new System.Drawing.Point(334, 61);
            this.txtUQuantity.Name = "txtUQuantity";
            this.txtUQuantity.Size = new System.Drawing.Size(118, 20);
            this.txtUQuantity.TabIndex = 10;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(242, 96);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(102, 32);
            this.btnProductUpdate.TabIndex = 1;
            this.btnProductUpdate.Text = "Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // txtUStock
            // 
            this.txtUStock.Location = new System.Drawing.Point(334, 26);
            this.txtUStock.Name = "txtUStock";
            this.txtUStock.Size = new System.Drawing.Size(118, 20);
            this.txtUStock.TabIndex = 9;
            // 
            // txtUPrice
            // 
            this.txtUPrice.Location = new System.Drawing.Point(86, 96);
            this.txtUPrice.Name = "txtUPrice";
            this.txtUPrice.Size = new System.Drawing.Size(118, 20);
            this.txtUPrice.TabIndex = 8;
            // 
            // txtUProductName
            // 
            this.txtUProductName.Location = new System.Drawing.Point(86, 26);
            this.txtUProductName.Name = "txtUProductName";
            this.txtUProductName.Size = new System.Drawing.Size(118, 20);
            this.txtUProductName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birim Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok Adedi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Adı";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(350, 96);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(102, 32);
            this.btnRemoveProduct.TabIndex = 11;
            this.btnRemoveProduct.Text = "Sil";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCUnitPrice;
        private System.Windows.Forms.Label lblCQuantityPerUnit;
        private System.Windows.Forms.Label lblCProductCategoryId;
        private System.Windows.Forms.Label lblCStock;
        private System.Windows.Forms.Label lblCPorductName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbUCategoryId;
        private System.Windows.Forms.TextBox txtUQuantity;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.TextBox txtUStock;
        private System.Windows.Forms.TextBox txtUPrice;
        private System.Windows.Forms.TextBox txtUProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveProduct;
    }
}

