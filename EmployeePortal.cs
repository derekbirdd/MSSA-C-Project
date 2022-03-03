using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class EmployeePortal : Form
    {

        List<Cart> _cart;
        StoreInventory inventory;
       
        
        public EmployeePortal()
        {
            InitializeComponent();
            
        }
        public EmployeePortal(List<Cart> cart, List<int> orderNumbers)
        {
            InitializeComponent();
            Orders.DataSource = cart.ToList();
            grpAdd.Visible = false;
            _cart = cart;
            
           

        }

        private void EmployeePortal_Load(object sender, EventArgs e)
        {
          
            inventory = new StoreInventory();
            dataGridView1.DataSource = inventory.GetInventory();
            comboName.Items.AddRange(new string[] { "Trucker Hat" ,"Shirt", "Sweat Pants", "Sweat Pant Shorts", "Coasters", "Mug", "Flag" });
            comboSize.Items.AddRange(new string[] { "S", "M", "L", "All"});
            comboColor.Items.AddRange(new string[] { "Black", "Gray", "Red" });

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            _cart.RemoveAt(Orders.CurrentRow.Index);
            Orders.DataSource = null;
            Orders.DataSource = _cart;
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            var ID = dataGridView1.CurrentRow.Cells[0].Value;
            var prodtodel = inventory.FindProd((int)ID);
            inventory.RemoveProduct(prodtodel);
            MessageBox.Show("Product has been removed.");
            dataGridView1.DataSource = inventory.GetInventory();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var newprod = new Inventory();
            newprod.ProductID = Convert.ToInt32(NumericBox.Text);
            newprod.Name = comboName.SelectedItem.ToString();
            newprod.Color = comboColor.SelectedItem.ToString();
            newprod.Size = comboSize.SelectedItem.ToString();
            newprod.Cost = Convert.ToDecimal(txtCost.Text);
            inventory.AddProduct(newprod);
            Clear();
            MessageBox.Show("Product has been added to the inventory.");
            dataGridView1.DataSource=inventory.GetInventory();
            
            
        }
        private void Clear()
        {

            comboName.SelectedIndex = -1;
            comboColor.SelectedIndex = -1;
            comboSize.SelectedIndex = -1;
            txtCost.Clear();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            
        }
        
      
        private void txtName_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumericBox_ValueChanged(object sender, EventArgs e)
        {
          
            NumericBox.Maximum = 1000;
            NumericBox.Minimum = 0;
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
           
        }
    }
    }

