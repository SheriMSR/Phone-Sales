
namespace PhoneSales_WinForms
{
    partial class frmOrderDetail
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
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(394, 333);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(290, 27);
            this.txtTotalPrice.TabIndex = 43;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(674, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(461, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(394, 160);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(290, 27);
            this.txtOrderId.TabIndex = 39;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(394, 221);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(290, 27);
            this.txtQuantity.TabIndex = 38;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(394, 280);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(290, 27);
            this.txtDiscount.TabIndex = 37;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(230, 337);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(78, 20);
            this.lbUnitPrice.TabIndex = 36;
            this.lbUnitPrice.Text = "Total Price";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(230, 280);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(67, 20);
            this.lbDiscount.TabIndex = 34;
            this.lbDiscount.Text = "Discount";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(230, 224);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 33;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(230, 160);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(66, 20);
            this.lbOrderID.TabIndex = 32;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(230, 108);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(79, 20);
            this.lbProductID.TabIndex = 31;
            this.lbProductID.Text = "Product ID";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(230, 453);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(538, 201);
            this.dgvMemberList.TabIndex = 69;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(394, 104);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(290, 27);
            this.txtProductID.TabIndex = 70;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(230, 391);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(135, 29);
            this.btnLoad.TabIndex = 71;
            this.btnLoad.Text = "&Load Product";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 669);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.lbProductID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrderDetail";
            this.Text = "frmOrderDDetails";
            this.Load += new System.EventHandler(this.frmOrderDDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnLoad;
    }
}