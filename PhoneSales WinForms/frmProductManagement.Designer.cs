
namespace PhoneSales_WinForms
{
    partial class frmProductManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textBrand = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.textQuantity);
            this.groupBox1.Controls.Add(this.textPrice);
            this.groupBox1.Controls.Add(this.textBrand);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(983, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(639, 215);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 31);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(427, 215);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 31);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(230, 215);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 31);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(673, 99);
            this.textQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(214, 27);
            this.textQuantity.TabIndex = 9;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(673, 48);
            this.textPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(214, 27);
            this.textPrice.TabIndex = 8;
            // 
            // textBrand
            // 
            this.textBrand.Location = new System.Drawing.Point(136, 143);
            this.textBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(227, 27);
            this.textBrand.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(136, 99);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(227, 27);
            this.textName.TabIndex = 6;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(136, 48);
            this.textID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(227, 27);
            this.textID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ProductName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(369, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 40);
            this.label7.TabIndex = 2;
            this.label7.Text = "Product Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 432);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(983, 248);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search By ProductName";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(226, 372);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(637, 27);
            this.textSearch.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(885, 372);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(86, 31);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 696);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductManagement";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textBrand;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button Search;
    }
}