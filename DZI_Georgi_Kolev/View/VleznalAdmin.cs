using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DZI_Georgi_Kolev
{
    public partial class VleznalAdmin : Form
    {
        public VleznalAdmin()
        {
            InitializeComponent();
        }

        private void VleznalAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dZI_Georgi_12ADataSet.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.dZI_Georgi_12ADataSet.admin);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            //adminBindingSource.AddNew();
          //  adminBindingSource.MoveNext();
            adminBindingSource.EndEdit();
           //  adminTableAdapter.Update(dZI_Georgi_12ADataSet.admin);


              MessageBox.Show("Record saved!");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dZI_Georgi_12ADataSet.admin.AddadminRow(textBox3.Text,textBox1.Text, comboBox2.Text, comboBox1.Text, comboBox3.Text, textBox2.Text, dateTimePicker1.Text) ;
           // adminBindingSource.AddNew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
