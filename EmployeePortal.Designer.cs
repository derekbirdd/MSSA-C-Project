namespace Project
{
    partial class EmployeePortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePortal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Orders = new System.Windows.Forms.DataGridView();
            this.btnDeleteInventory = new System.Windows.Forms.Button();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.NumericBox = new System.Windows.Forms.NumericUpDown();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(679, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Portal";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(107, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 503);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(724, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1630, 1027);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(274, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 59);
            this.label3.TabIndex = 5;
            this.label3.Text = "In Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(1261, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 59);
            this.label2.TabIndex = 6;
            this.label2.Text = "Orders";
            // 
            // Orders
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Orders.DefaultCellStyle = dataGridViewCellStyle4;
            this.Orders.Location = new System.Drawing.Point(1121, 340);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(435, 503);
            this.Orders.TabIndex = 7;
            // 
            // btnDeleteInventory
            // 
            this.btnDeleteInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInventory.Location = new System.Drawing.Point(366, 849);
            this.btnDeleteInventory.Name = "btnDeleteInventory";
            this.btnDeleteInventory.Size = new System.Drawing.Size(117, 52);
            this.btnDeleteInventory.TabIndex = 8;
            this.btnDeleteInventory.Text = "Delete Item";
            this.btnDeleteInventory.UseVisualStyleBackColor = true;
            this.btnDeleteInventory.Click += new System.EventHandler(this.btnDeleteInventory_Click);
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteOrder.Location = new System.Drawing.Point(1299, 849);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(117, 52);
            this.btnCompleteOrder.TabIndex = 9;
            this.btnCompleteOrder.Text = "Complete Item";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.BackColor = System.Drawing.Color.Silver;
            this.grpAdd.Controls.Add(this.comboSize);
            this.grpAdd.Controls.Add(this.comboColor);
            this.grpAdd.Controls.Add(this.comboName);
            this.grpAdd.Controls.Add(this.NumericBox);
            this.grpAdd.Controls.Add(this.txtCost);
            this.grpAdd.Controls.Add(this.btnEnter);
            this.grpAdd.Controls.Add(this.lblSize);
            this.grpAdd.Controls.Add(this.lblCost);
            this.grpAdd.Controls.Add(this.lblColor);
            this.grpAdd.Controls.Add(this.lblName);
            this.grpAdd.Controls.Add(this.lblProductID);
            this.grpAdd.Location = new System.Drawing.Point(633, 591);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(327, 252);
            this.grpAdd.TabIndex = 10;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Product Details";
            // 
            // comboSize
            // 
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Location = new System.Drawing.Point(148, 161);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(143, 21);
            this.comboSize.TabIndex = 14;
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(148, 92);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(143, 21);
            this.comboColor.TabIndex = 13;
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(147, 58);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(144, 21);
            this.comboName.TabIndex = 12;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            // 
            // NumericBox
            // 
            this.NumericBox.Location = new System.Drawing.Point(148, 32);
            this.NumericBox.Name = "NumericBox";
            this.NumericBox.Size = new System.Drawing.Size(144, 20);
            this.NumericBox.TabIndex = 11;
            this.NumericBox.ValueChanged += new System.EventHandler(this.NumericBox_ValueChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(147, 129);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(145, 20);
            this.txtCost.TabIndex = 9;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(227, 208);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(64, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(33, 163);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(49, 20);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(33, 127);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(51, 20);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Cost:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(33, 94);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(56, 20);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(33, 29);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(100, 20);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(213, 849);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(117, 52);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add Item";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // EmployeePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1717, 1062);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.btnDeleteInventory);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePortal";
            this.Text = "EmployeePortal";
            this.Load += new System.EventHandler(this.EmployeePortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Orders;
        private System.Windows.Forms.Button btnDeleteInventory;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown NumericBox;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.ComboBox comboName;
    }
}