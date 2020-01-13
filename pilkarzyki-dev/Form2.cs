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
    public partial class Form2 : Form
    {
        public Team list;
        public Form2(Team k)
        {
            this.list = k;
            BackColor = Color.White;
            InitializeComponent();
            this.Text = "Add";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1(this.list);
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddTrainer = new AddTrainer(this.list);
            AddTrainer.Closed += (s, args) => this.Close();
            AddTrainer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddPlayer = new AddPlayer(this.list);
            AddPlayer.Closed += (s, args) => this.Close();
            AddPlayer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddOthers = new AddOthers(this.list);
            AddOthers.Closed += (s, args) => this.Close();
            AddOthers.Show();
        }
    }
}
