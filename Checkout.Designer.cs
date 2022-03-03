namespace Project
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnDiscord = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CartList = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.blogsToolStripMenuItem,
            this.galleryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // blogsToolStripMenuItem
            // 
            this.blogsToolStripMenuItem.Name = "blogsToolStripMenuItem";
            this.blogsToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.blogsToolStripMenuItem.Text = "Blogs";
            this.blogsToolStripMenuItem.Click += new System.EventHandler(this.blogsToolStripMenuItem_Click);
            // 
            // galleryToolStripMenuItem
            // 
            this.galleryToolStripMenuItem.Name = "galleryToolStripMenuItem";
            this.galleryToolStripMenuItem.Size = new System.Drawing.Size(92, 34);
            this.galleryToolStripMenuItem.Text = "Gallery";
            this.galleryToolStripMenuItem.Click += new System.EventHandler(this.galleryToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnTwitter);
            this.panel1.Controls.Add(this.btnDiscord);
            this.panel1.Controls.Add(this.btnFacebook);
            this.panel1.Controls.Add(this.btnInstagram);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 790);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 69);
            this.panel1.TabIndex = 5;
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackColor = System.Drawing.Color.Silver;
            this.btnTwitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTwitter.BackgroundImage")));
            this.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Location = new System.Drawing.Point(518, 7);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(61, 59);
            this.btnTwitter.TabIndex = 3;
            this.btnTwitter.UseVisualStyleBackColor = false;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // btnDiscord
            // 
            this.btnDiscord.BackColor = System.Drawing.Color.Silver;
            this.btnDiscord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscord.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscord.Image")));
            this.btnDiscord.Location = new System.Drawing.Point(585, 7);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(61, 59);
            this.btnDiscord.TabIndex = 2;
            this.btnDiscord.UseVisualStyleBackColor = false;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackColor = System.Drawing.Color.Silver;
            this.btnFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacebook.BackgroundImage")));
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Location = new System.Drawing.Point(384, 7);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(61, 59);
            this.btnFacebook.TabIndex = 1;
            this.btnFacebook.UseVisualStyleBackColor = false;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackColor = System.Drawing.Color.Silver;
            this.btnInstagram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstagram.BackgroundImage")));
            this.btnInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagram.Location = new System.Drawing.Point(451, 7);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(61, 59);
            this.btnInstagram.TabIndex = 0;
            this.btnInstagram.UseVisualStyleBackColor = false;
            this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(474, 519);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 26);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Location = new System.Drawing.Point(474, 551);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(111, 28);
            this.btnClearList.TabIndex = 9;
            this.btnClearList.Text = "Clear Item";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(412, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Shopping Cart";
            // 
            // CartList
            // 
            this.CartList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CartList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CartList.BackgroundColor = System.Drawing.Color.Silver;
            this.CartList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartList.Location = new System.Drawing.Point(399, 310);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(261, 193);
            this.CartList.TabIndex = 13;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(841, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1061, 859);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galleryToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Button btnDiscord;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnInstagram;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CartList;
        private System.Windows.Forms.Button btnLogout;
    }
}