using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        SaveFileDialog sfd1 = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
            label1.Text = ResourceDefault.FullName;
            button1.Text = ResourceDefault.Add;
            button2.Text = ResourceDefault.Write;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox1.Text,
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sfd1.Filter= "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            if (sfd1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd1.Filter);
                writer.WriteLine("FullName");

                foreach (User user in users)
                {
                    writer.Write(user.FullName);
                }
                writer.Close();
            }
        }
    }
}
