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
        int[,] seek = new int[26, 26];
        int b;
        int prekey;
        Stopwatch sw = new Stopwatch();
        Stopwatch sek = new Stopwatch();
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
            sek.Stop();
        }

        private void InBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            b = (int)e.KeyChar;
            seek[prekey, b - 97] = (int)sek.ElapsedMilliseconds;
        }

        private void InBx_KeyUp(object sender, KeyEventArgs e)
        {
            sw.Stop();
            a[b] = (int)sw.ElapsedMilliseconds;
            Dwell_time.Text = a[b].ToString();
            sw.Reset();
            prekey = b - 97;
            sek.Start();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            TextWriter tsw = new StreamWriter("kmb_dwell.csv", true);
            TextWriter sk = new StreamWriter("kmbseek.csv", true);
            for (int i = 97; i < 123; i++)
            {
                tsw.Write(a[i]);
                tsw.Write(",");
            }
            tsw.Write("\n");
            for(int i=0;i<26; i++)
            {
                for(int j=0;j<26;j++)
                {
                    sk.Write(seek[i, j]);
                    if(j!=25)
                        sk.Write(",");
                    else
                        sk.Write("\n");
                }
            }
            //Close the file.
            sk.Close();
            tsw.Close();
            this.Close();

        }
    }
}
