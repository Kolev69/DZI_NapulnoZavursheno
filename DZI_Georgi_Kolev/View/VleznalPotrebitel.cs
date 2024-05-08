using DZI_Georgi_Kolev.DZI_Georgi_12ADataSetTableAdapters;
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
    public partial class VleznalPotrebitel : Form
    {
        public VleznalPotrebitel()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VleznalPotrebitel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dZI_Georgi_12ADataSet1.potrebitel' table. You can move, or remove it, as needed.
            this.potrebitelTableAdapter.Fill(this.dZI_Georgi_12ADataSet1.potrebitel);
            // TODO: This line of code loads data into the 'dZI_Georgi_12ADataSet.potrebitel' table. You can move, or remove it, as needed.
          //  this.potrebitelTableAdapter.Fill(this.dZI_Georgi_12ADataSet.potrebitel);
            // TODO: This line of code loads data into the 'dZI_Georgi_12ADataSet.potrebitel' table. You can move, or remove it, as needed.
          //  this.potrebitelTableAdapter.Fill(this.dZI_Georgi_12ADataSet.potrebitel);
            // TODO: This line of code loads data into the 'dZI_Georgi_12ADataSet.nov_potrebitel' table. You can move, or remove it, as needed.
           // this.nov_potrebitelTableAdapter.Fill(this.dZI_Georgi_12ADataSet.nov_potrebitel);
            // TODO: This line of code loads data into the 'dZI_Georgi_12ADataSet.potrebitel' table. You can move, or remove it, as needed.
         //   this.potrebitelTableAdapter.Fill(this.dZI_Georgi_12ADataSet.potrebitel);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            potrebitelBindingSource.RemoveCurrent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // dZI_Georgi_12ADataSet.admin.AddadminRow(textBox3.Text, textBox1.Text, comboBox2.Text, comboBox1.Text, comboBox3.Text, textBox2.Text, dateTimePicker1.Text);
             dZI_Georgi_12ADataSet1.potrebitel.AddpotrebitelRow(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, comboBox2.Text);
          //  dZI_Georgi_12ADataSet.nov_potrebitel.AddnovpotrebitelRow(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, comboBox2.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        
        {
            potrebitelBindingSource.EndEdit();
            potrebitelTableAdapter.Update(dZI_Georgi_12ADataSet1.potrebitel);


            MessageBox.Show("Изпратена поръчка за обработка!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
