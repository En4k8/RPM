using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown_и_DomainUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> states = new List<string>
        {
            "Аргентина", "Бразилия", "Венесуэла", "Колумбия", "Чили","Россия", "США","Япония"
        };


            domainUpDown1.Items.AddRange(states);
            domainUpDown1.TextChanged += domainUpDown1_TextChanged;
        }

        void domainUpDown1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.Text);
        }
    }
}
