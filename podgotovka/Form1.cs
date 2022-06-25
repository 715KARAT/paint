using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace podgotovka
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // выводит доп. мини окошко
            string shraf;
            string price;
            DialogResult result = MessageBox.Show(price = "C ваc 3500$ долларов", shraf = "ШТРАФ!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // switch case
            switch (textBoxPanel.Text)
            {
                case "1":
                    labelPanel.Text = "1 или 2"; break;               
                case "3":
                    labelPanel.Text = "3"; break;
                default:
                    labelPanel.Text = "хз"; break;
                case "666":
                    labelPanel.Text = "Morgenshtern"; break;

            }
        }

        private void labelPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
