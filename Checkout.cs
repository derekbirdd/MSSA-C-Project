using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace Project
{
   
    public partial class Checkout : Form
    {
      

        public static Random rnd = new Random();

         int OrderId  = rnd.Next(0, 1000);

       public static List<int> orderNumbers = new List<int>();

        List<Cart> _cart;
        
        public Checkout()
        {
            InitializeComponent();
        }
        public Checkout(List<Cart> cart)
        {
            InitializeComponent();
            CartList.DataSource = cart.ToList();       
            _cart = cart;
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
            this.Hide();
            Blog blog = new Blog();
            blog.Show();
        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void Checkout_Load(object sender, EventArgs e)
        {
          
            
        }

        public void btnClearList_Click(object sender, EventArgs e)
        {
            
            _cart.RemoveAt(CartList.CurrentRow.Index);
            CartList.DataSource = null;
            CartList.DataSource = _cart;
        }

        public void CartList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }

       
        public void btnConfirm_Click(object sender, EventArgs e)
        {
                  
            MessageBox.Show($"Your order has been placed, thank you for shopping with us! Your Order number is #{OrderId}");
            orderNumbers.Add((int)OrderId);
            CartList.DataSource = null;
            CartList.Refresh();

            var fromAddress = new MailAddress("tuser3776@gmail.com", "User");
            var toAddress = new MailAddress("pinewhiskeyproductions@gmail.com", "Pine Whiskey Productions");
            const string fromPassword = "zxcvbnm,./1234567890-=";
            string subject = ($"Order #{OrderId} Details");
            string body = ($"We have a new order to be processed! Have a blessed day!");

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
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