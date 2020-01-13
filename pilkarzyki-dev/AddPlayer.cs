using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class AddPlayer : Form
    {
        public Team list;
        public AddPlayer(Team k)
        {
            this.list = k;
            BackColor = Color.White;
            InitializeComponent();
            this.Text = "Add player";
            comboBox1.Items.Add(new ItemDisplay<int>(1, "GoalKeeper"));
            comboBox1.Items.Add(new ItemDisplay<int>(2, "Defender"));
            comboBox1.Items.Add(new ItemDisplay<int>(3, "Midfilder"));
            comboBox1.Items.Add(new ItemDisplay<int>(4, "Forward"));
            comboBox1.Items.Add(new ItemDisplay<int>(5, "Reserve"));
            comboBox1.SelectedIndex = 0;

        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form2 = new Form2(this.list);
            Form2.Closed += (s, args) => this.Close();
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var firstname = textBox1.Text;
            var surname = textBox2.Text;
            var age = (int)numericUpDown1.Value;
            var role = comboBox1.Text;
            this.list.Push2(firstname, surname, age, role);
            this.Hide();
            var Form2 = new Form2(this.list);
            Form2.Closed += (s, args) => this.Close();
            Form2.Show();
        }

        
    }

}
