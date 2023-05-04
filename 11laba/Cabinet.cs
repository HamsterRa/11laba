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
    public partial class Cabinet : Form
    {
        public Cabinet(int id)
        {
            InitializeComponent();
            using (ApplicationDrawers db = new())
            {
                foreach (Drawer oneDrawer in db.Drawers)
                {
                    if (oneDrawer.Id == id)
                    {
                        name.Text = oneDrawer.Name;
                        surname.Text = oneDrawer.Surname;
                        emaillabel.Text = oneDrawer.Email;
                        datefirst.Text = oneDrawer.DateFirstPublication.Date.ToString();
                        birthday.Text = oneDrawer.DateOfBirthday.Date.ToString();
                        phone.Text = oneDrawer.PhoneNumber;
                        dictionary.Text = oneDrawer.ArtDirection;
                        break;
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
