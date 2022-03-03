namespace Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnDiscord = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(492, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = " PineWhiskey Productions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnTwitter);
            this.panel1.Controls.Add(this.btnDiscord);
            this.panel1.Controls.Add(this.btnFacebook);
            this.panel1.Controls.Add(this.btnInstagram);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 918);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1812, 69);
            this.panel1.TabIndex = 4;
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackColor = System.Drawing.Color.Silver;
            this.btnTwitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTwitter.BackgroundImage")));
            this.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Location = new System.Drawing.Point(944, 0);
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
            this.btnDiscord.Location = new System.Drawing.Point(1011, 0);
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
            this.btnFacebook.Location = new System.Drawing.Point(810, 0);
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
            this.btnInstagram.Location = new System.Drawing.Point(877, 0);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(61, 59);
            this.btnInstagram.TabIndex = 0;
            this.btnInstagram.UseVisualStyleBackColor = false;
            this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1812, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1812, 894);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1664, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1812, 987);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Button btnDiscord;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnInstagram;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galleryToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
    }
}

