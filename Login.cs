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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "User" && txtPassword.Text == "Password")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Sorry you have entered an incorrect Username or password. Please try again.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
           
            
                if (txtUsername.Text == "Employee" && txtPassword.Text == "Password")
                {
                    if(Products.cart != null)
                {
                    EmployeePortal employee1 = new EmployeePortal(Products.cart, Checkout.orderNumbers);
                    this.Hide();
                    employee1.Show();

                }
                else
                {
                    EmployeePortal employee = new EmployeePortal();
                        this.Hide();
                    employee.Show();
                }
                    
                    
                 
                }

                else
                {
                    MessageBox.Show("Sorry you have entered an incorrect Username or password. Please try again.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
