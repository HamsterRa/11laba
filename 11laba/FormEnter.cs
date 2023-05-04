using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11laba
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            using (ApplicationDrawers db = new())
            {
                foreach (Drawer oneDrawer in db.Drawers)
                {
                    string password = new Hashing(passwordBox.Text).ToHash();
                    if (oneDrawer.Password == password && oneDrawer.Email == emailBox.Text)
                    {
                        new Cabinet(oneDrawer.Id).ShowDialog();
                    }
                }
            }
            groupBox1.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Enabled = false;
            if(emailBox.Text == "")
            {
                groupBox1.Enabled = true;
                MessageBox.Show("Введите почту");
                return;
            }
            string password = new GeneratePassword(9).Generate();
            new EmailSender(emailBox.Text).SendMessage($"Новый пароль: {password}");
            using (ApplicationDrawers db = new())
            {
                foreach (Drawer oneDrawer in db.Drawers)
                {
                    if (oneDrawer.Email == emailBox.Text)
                    {
                        oneDrawer.Password = new Hashing(password).ToHash();
                        break;
                    }
                }
                db.SaveChanges();
            }

            groupBox1.Enabled = true;
        }
    }
}
