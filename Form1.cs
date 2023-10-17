using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcsf20a014
{
    public partial class Form1 : Form
    {
        enum Subjects
        {
            DSA,
            ALGO,
            TOA,
            PP,
            DSALAB,
            CC,
            QURAN
        }

        public Form1()
        {
            InitializeComponent();
            foreach (Subjects subject in Enum.GetValues(typeof(Subjects)))
            {
                comboBox1.Items.Add(subject.ToString());
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
         

            string selectedSubject = comboBox1.SelectedItem as string;
            bool prerequisiteClear = checkBox1.Checked;

            string result = "First Name: " + firstName + Environment.NewLine +
                            "Last Name: " + lastName + Environment.NewLine +
                            "Selected Subject: " + selectedSubject + Environment.NewLine +
                            "Prerequisite Clear: " + prerequisiteClear;

        
            label3.Text = result;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
