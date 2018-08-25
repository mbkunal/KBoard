using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace KBoard
{
    public partial class Form1 : Form
    {
        int[] a = new int[123];
        int b;
        Stopwatch sw = new Stopwatch();
        Stopwatch s2 = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InBx_KeyDown(object sender, KeyEventArgs e)
        {
            sw.Start();
        }

        private void InBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            b = (int)e.KeyChar;
        }

        private void InBx_KeyUp(object sender, KeyEventArgs e)
        {
            sw.Stop();
            a[b] = (int)sw.ElapsedMilliseconds;
            Dwell_time.Text = a[b].ToString();
            sw.Reset();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            TextWriter tsw = new StreamWriter("kmb.csv", true);

            for (int i = 97; i < 123; i++)
            {
                tsw.Write(a[i]);
                tsw.Write(",");
            }
            tsw.Write("\n");

            //Close the file.
            tsw.Close();
            this.Close();

        }
    }
}
