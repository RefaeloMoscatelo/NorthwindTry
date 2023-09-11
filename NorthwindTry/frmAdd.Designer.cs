
namespace NorthwindTry
{
    partial class frmAdd
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
            this.components = new System.ComponentModel.Container();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductDiscontinued = new System.Windows.Forms.TextBox();
            this.btnAddProducttoDB = new System.Windows.Forms.Button();
            this.lblCat = new System.Windows.Forms.Label();
            this.cbocatNewProduct = new System.Windows.Forms.ComboBox();
            this.northwindDataSet = new NorthwindTry.NorthwindDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new NorthwindTry.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(121, 38);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(158, 29);
            this.txtProductName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dicontinued";
            // 
            // txtProductDiscontinued
            // 
            this.txtProductDiscontinued.Location = new System.Drawing.Point(121, 81);
            this.txtProductDiscontinued.Multiline = true;
            this.txtProductDiscontinued.Name = "txtProductDiscontinued";
            this.txtProductDiscontinued.Size = new System.Drawing.Size(158, 29);
            this.txtProductDiscontinued.TabIndex = 2;
            // 
            // btnAddProducttoDB
            // 
            this.btnAddProducttoDB.Location = new System.Drawing.Point(460, 87);
            this.btnAddProducttoDB.Name = "btnAddProducttoDB";
            this.btnAddProducttoDB.Size = new System.Drawing.Size(75, 23);
            this.btnAddProducttoDB.TabIndex = 16;
            this.btnAddProducttoDB.Text = "ADD";
            this.btnAddProducttoDB.UseVisualStyleBackColor = true;
            this.btnAddProducttoDB.Click += new System.EventHandler(this.btnAddProducttoDB_Click);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(42, 145);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(49, 13);
            this.lblCat.TabIndex = 18;
            this.lblCat.Text = "Category";
            // 
            // cbocatNewProduct
            // 
            this.cbocatNewProduct.DataSource = this.categoriesBindingSource;
            this.cbocatNewProduct.DisplayMember = "CategoryName";
            this.cbocatNewProduct.FormattingEnabled = true;
            this.cbocatNewProduct.Location = new System.Drawing.Point(121, 137);
            this.cbocatNewProduct.Name = "cbocatNewProduct";
            this.cbocatNewProduct.Size = new System.Drawing.Size(121, 21);
            this.cbocatNewProduct.TabIndex = 19;
            this.cbocatNewProduct.ValueMember = "CategoryID";
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.northwindDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(56, 211);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 20;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cbocatNewProduct);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.btnAddProducttoDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductDiscontinued);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductDiscontinued;
        private System.Windows.Forms.Button btnAddProducttoDB;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox cbocatNewProduct;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private NorthwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label lblError;
    }
}