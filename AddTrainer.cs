﻿using System;
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
    public partial class AddTrainer : Form
    {
        public Team list;
        public AddTrainer(Team k)
        {
            this.list = k;
            BackColor = Color.White;
            InitializeComponent();
            this.Text = "Add trainer";
            comboBox1.Items.Add(new ItemDisplay<int>(1, "Main Trainer"));
            comboBox1.Items.Add(new ItemDisplay<int>(2, "Second Trainer"));
            comboBox1.Items.Add(new ItemDisplay<int>(3, "Third Trainer"));
            comboBox1.SelectedIndex = 0;
        }

        private void AddTrainer_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            this.list.Push(firstname, surname, age, role);
            this.Hide();
            var Form2 = new Form2(this.list);
            Form2.Closed += (s, args) => this.Close();
            Form2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class ItemDisplay<TValue>
    {
        private readonly string m_displayText;

        public ItemDisplay(TValue value, String displayText)
        {
            this.Value = value;
            m_displayText = displayText;
        }

        public TValue Value { get; set; }

        public override string ToString()
        {
            return m_displayText;
        }
    }
}
