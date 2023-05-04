using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11laba
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
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
                foreach (Drawer oneDrawer in  db.Drawers)
                {
                    if(oneDrawer.Email == emailBox.Text)
                    {
                        MessageBox.Show("Такой email уже существует");
                        groupBox1.Enabled = true;
                        return;
                    }
                }
                db.Drawers.Add(new Drawer(nameBox.Text, surnameBox.Text, dateTimePicker1.Value, emailBox.Text, phoneBox.Text, WhyRadioButton(),dateTimePicker2.Value,new Hashing(passwordBox.Text).ToHash()));
                db.SaveChanges();
                new EmailSender(emailBox.Text).SendMessage("Вы успешно зарегистрировались");
                groupBox1.Enabled = true;
                Close();
            }
        }
        private string WhyRadioButton()
        {
            if (radioButton1.Checked) return radioButton1.Text;
            if (radioButton2.Checked) return radioButton2.Text;
            if (radioButton3.Checked) return radioButton3.Text;
            else return "";
        }
    }
}
