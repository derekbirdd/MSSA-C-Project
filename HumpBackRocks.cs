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
    public partial class HumpBackRocks : Form
    {
        public HumpBackRocks()
        {
            InitializeComponent();
        }

        private void HumpBackRocks_Load(object sender, EventArgs e)
        {

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

        private void blogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Blog blog = new Blog();
            blog.Show();
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
            System.Diagnostics.Process.Start("https://discord.gg/rbrbxE32");
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Products products = new Products();
            products.Show();
        }
    }
}
