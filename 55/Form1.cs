using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _55
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(50, 50 * count);
            newButton.Text = "Button " + count;
            this.Controls.Add(newButton);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Height *= 2;
                }
                else if (control is TextBox textBox)
                {
                    textBox.Multiline = true;
                    textBox.Height *= 2;
                }
            }
        }
    }
}
