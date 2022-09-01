using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DistinctWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var distinctContent = Regex.Split(textBox1.Text, "\r\n", RegexOptions.IgnoreCase)
                .Distinct()
                .OrderBy(s => s)
                .ToList();
            var result = new StringBuilder();
            foreach (var content in distinctContent)
            {
                result.Append(content).Append("\r\n");
            }

            textBox2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox2.Text);
        }
    }
}