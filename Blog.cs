using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Blog : Form
    {
        public Blog()
        {
            InitializeComponent();
        }

        private void HeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void TopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void BottomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void merchandiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Gallery gallery = new Gallery();
            gallery.Show();
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/pine_whiskey");
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/bdRGaYuk");
        }

        private void blogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Blog blog = new Blog();
            blog.Show();
        }

        private void btnHumpbackRock_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void btnOldRag_Click(object sender, EventArgs e)
        {
            this.Close();
            OldRagMountain old = new OldRagMountain();
            old.Show();
        }

        private void btnHumpbackRocks_Click(object sender, EventArgs e)
        {
            this.Close();
            HumpBackRocks back = new HumpBackRocks();
            back.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Products products = new Products();
            products.Show();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/PineWhiskeyProductions");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/pinewhiskeyproduction/");
        }
    }
}
