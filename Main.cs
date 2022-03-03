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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }

        private void seeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/PineWhiskeyProductions");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/bdRGaYuk");


        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/pine_whiskey");
        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gallery gallery = new Gallery();
            gallery.Show();
        }

        private void blogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blog blog = new Blog();
            blog.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
           
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/pinewhiskeyproduction/");
        }
    }
}
