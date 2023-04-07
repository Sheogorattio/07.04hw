using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07._04hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                string path = this.textBox1.Text;
                string[] words;
                try {
                    using (var fs = new StreamReader(path))
                    {
                        words = fs.ReadToEnd().Split(new char[] { ' ' });
                    }
                    this.progressBar1.Maximum = 1000;
                    this.progressBar1.Value = words.Length;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
