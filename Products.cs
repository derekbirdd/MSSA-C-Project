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
    public partial class Products : Form
    {
        public static List<Cart> cart = new List<Cart>();
       
        public Products()
        {
          InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            comboShirtBlack.Items.AddRange(new String[] { "S", "M", "L" });
            comboShirtGray.Items.AddRange(new String[] { "S", "M", "L" });
            comboShirtRed.Items.AddRange(new String[] { "S", "M", "L" });
            comboSweatpantsGray.Items.AddRange(new String[] { "S", "M", "L" });
            comboSweatpantsBlack.Items.AddRange(new String[] { "S", "M", "L" });
            comboSweatpantShorts.Items.AddRange(new String[] { "S", "M", "L" });
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void HeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Products tops = new Products();
            tops.Show();
        }

        private void BottomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void merchandiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
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
            this.Close();
            Gallery gallery = new Gallery();
            gallery.Show();
        }

        private void blogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Blog blog = new Blog();
            blog.Show();
        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        public void btnAddtoCartBlackShirt_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show($"Black shirt sized {comboShirtBlack.SelectedItem} has been added to your cart!" );
            cart.Add( new Cart() { Name = "Shirt", Color = "Black", Size = (string)comboShirtBlack.SelectedItem, Price =19.99m });
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void btnAddtoCartGrayShirt_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Gray shirt sized {comboShirtGray.SelectedItem} has been added to your cart!");           
            cart.Add(new Cart() { Name = "Shirt", Color = "Gray", Size = (string)comboShirtGray.SelectedItem, Price = 19.99m });
            
            
        }

        private void btnAddtoCartRedShirt_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show($"Red shirt sized {comboShirtRed.SelectedItem} has been added to your cart!");
            cart.Add( new Cart() { Name = "Shirt", Color = "Red", Size = (string)comboShirtRed.SelectedItem, Price = 19.99m });
            
          
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAddtoCartGraySweatpants_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Gray sweatpants sized {comboSweatpantsGray.SelectedItem} has been added to your cart!");
            cart.Add(new Cart() { Name = "SweatPants", Color = "Gray", Size = (string)comboSweatpantsGray.SelectedItem, Price = 29.99m });
           
        }

        private void btnAddtoCartBlackSweatpants_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Black sweatpants sized {comboSweatpantsBlack.SelectedItem} has been added to your cart!");
            cart.Add(new Cart() { Name = "SweatPants", Color = "Black", Size = (string)comboSweatpantsBlack.SelectedItem, Price = 29.99m });
            
        }

        private void btnAddtoCartGraySweatshorts_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Gray sweatpant shorts sized {comboSweatpantShorts.SelectedItem} has been added to your cart!");
            cart.Add(new Cart() { Name = "SweatPant Shorts", Color = "Gray", Size = (string)comboSweatpantShorts.SelectedItem, Price = 29.99m });
            
        }

        private void btnAddtoCartHatGray_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Gray Trucker hat has been added to your cart!");
            cart.Add(new Cart() { Name = "Trucker Hat", Color = "Gray", Size = "All", Price = 24.99m });
           
        }

        private void btnAddtoCartHatBlack_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Black Trucker hat has been added to your cart!");
            cart.Add(new Cart() { Name = "Trucker Hat", Color = "Black", Size = "All", Price = 24.99m });
            
        }

        private void btnAddtoCartHatRed_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Red Trucker hat has been added to your cart!");
            cart.Add(new Cart() { Name = "Trucker Hat", Color = "Red", Size = "All", Price = 24.99m });
            
        }

        private void btnAddtoCartCoaster_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Wooden Coasters have been added to your cart!");
            cart.Add(new Cart() { Name = "Coasters", Color = "Wooden", Size = "All", Price = 14.99m });
            
        }

        private void btnAddtoCartMug_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Wooden Mug has been added to your cart!");
            cart.Add(new Cart() { Name = "Mug", Color = "Wooden", Size = "All", Price = 19.99m });
           
        }

        private void btnAddtoCartFlag_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pine Whiskey Productions flag has been added to your cart!");
            cart.Add(new Cart() { Name = "Flag", Color = "Black", Size = "All", Price = 24.99m });
            
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {           
            if(Products.cart != null)
            {
                Checkout checkout = new Checkout(Products.cart);
                this.Hide();
                checkout.Show();
            }
            else
            {
                Checkout checkout1 = new Checkout();
                this.Hide();
                checkout1.Show();
            }
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
