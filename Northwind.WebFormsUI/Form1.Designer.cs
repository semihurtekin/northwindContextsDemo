
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
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategoryName = new System.Windows.Forms.ComboBox();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxCategoryID = new System.Windows.Forms.ComboBox();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxUpdateCategoryID = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxProduct.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProductName);
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Location = new System.Drawing.Point(12, 94);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(900, 81);
            this.gbxProduct.TabIndex = 5;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(98, 47);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(322, 22);
            this.tbxProductName.TabIndex = 3;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(31, 47);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(39, 17);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Ürün";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Controls.Add(this.cbxCategoryName);
            this.gbxCategory.Location = new System.Drawing.Point(12, 27);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(900, 61);
            this.gbxCategory.TabIndex = 4;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(31, 38);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(61, 17);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategori";
            // 
            // cbxCategoryName
            // 
            this.cbxCategoryName.FormattingEnabled = true;
            this.cbxCategoryName.Location = new System.Drawing.Point(98, 31);
            this.cbxCategoryName.Name = "cbxCategoryName";
            this.cbxCategoryName.Size = new System.Drawing.Size(322, 24);
            this.cbxCategoryName.TabIndex = 0;
            this.cbxCategoryName.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryName_SelectedIndexChanged);
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 181);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1102, 243);
            this.dgwProduct.TabIndex = 3;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxStockAmount);
            this.groupBox1.Controls.Add(this.tbxQuantityPerUnit);
            this.groupBox1.Controls.Add(this.tbxUnitPrice);
            this.groupBox1.Controls.Add(this.cbxCategoryID);
            this.groupBox1.Controls.Add(this.tbxProductName2);
            this.groupBox1.Controls.Add(this.lblStockAmount);
            this.groupBox1.Controls.Add(this.lblCategoryID);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Controls.Add(this.lblQuantityPerUnit);
            this.groupBox1.Controls.Add(this.lblProductName2);
            this.groupBox1.Location = new System.Drawing.Point(46, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(517, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 43);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(471, 59);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(215, 22);
            this.tbxStockAmount.TabIndex = 9;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(471, 98);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(215, 22);
            this.tbxQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(130, 153);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(215, 22);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // cbxCategoryID
            // 
            this.cbxCategoryID.FormattingEnabled = true;
            this.cbxCategoryID.Location = new System.Drawing.Point(130, 103);
            this.cbxCategoryID.Name = "cbxCategoryID";
            this.cbxCategoryID.Size = new System.Drawing.Size(215, 24);
            this.cbxCategoryID.TabIndex = 6;
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(130, 59);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(215, 22);
            this.tbxProductName2.TabIndex = 5;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(374, 59);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(91, 17);
            this.lblStockAmount.TabIndex = 4;
            this.lblStockAmount.Text = "STOK ADEDİ";
            this.lblStockAmount.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(31, 106);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(79, 17);
            this.lblCategoryID.TabIndex = 3;
            this.lblCategoryID.Text = "KATEGORİ";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(31, 153);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(46, 17);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "FİYAT";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(374, 103);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(89, 17);
            this.lblQuantityPerUnit.TabIndex = 1;
            this.lblQuantityPerUnit.Text = "BİRİM ADEDİ";
            this.lblQuantityPerUnit.Click += new System.EventHandler(this.lblQuantityPerUnit_Click);
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Location = new System.Drawing.Point(31, 62);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(74, 17);
            this.lblProductName2.TabIndex = 0;
            this.lblProductName2.Text = "ÜRÜN ADI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.tbxUpdateUnitsInStock);
            this.groupBox2.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.groupBox2.Controls.Add(this.tbxUpdateUnitPrice);
            this.groupBox2.Controls.Add(this.cbxUpdateCategoryID);
            this.groupBox2.Controls.Add(this.tbxUpdateProductName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(46, 658);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1095, 222);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(517, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 43);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseClick);
            // 
            // tbxUpdateUnitsInStock
            // 
            this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(471, 59);
            this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(215, 22);
            this.tbxUpdateUnitsInStock.TabIndex = 9;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(471, 98);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(215, 22);
            this.tbxUpdateQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(130, 153);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(215, 22);
            this.tbxUpdateUnitPrice.TabIndex = 7;
            // 
            // cbxUpdateCategoryID
            // 
            this.cbxUpdateCategoryID.FormattingEnabled = true;
            this.cbxUpdateCategoryID.Location = new System.Drawing.Point(130, 103);
            this.cbxUpdateCategoryID.Name = "cbxUpdateCategoryID";
            this.cbxUpdateCategoryID.Size = new System.Drawing.Size(215, 24);
            this.cbxUpdateCategoryID.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(130, 59);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(215, 22);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "STOK ADEDİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "KATEGORİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "FİYAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "BİRİM ADEDİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ÜRÜN ADI";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(942, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 968);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategoryName;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.ComboBox cbxCategoryID;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryID;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}

