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
        private const string MyProg = @"KBoard.exe";
        int[] a = new int[123];
        int[,] seek = new int[26, 26];
        int b;
        char pr;
        int prekey;
        Stopwatch dw = new Stopwatch();
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
            dw.Start();
            sek.Stop();
        }

        private void InBx_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                b = (int)e.KeyChar;
                pr = e.KeyChar;
                seek[prekey, b - 97] = (int)sek.ElapsedMilliseconds;
            }
            catch(Exception)
            {

            }
        }

        private void InBx_KeyUp(object sender, KeyEventArgs e)
        {
            dw.Stop();
            a[b] = (int)dw.ElapsedMilliseconds;
            Dwell_time.Text = a[b].ToString();
            PreLetter.Text = pr.ToString();
            dw.Reset();
            prekey = b - 97;
            sek.Start();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            TextWriter dwe = new StreamWriter("kmb_dwell.csv", true);
            //TextWriter sk = new StreamWriter("kmbseek.csv", true);
            for (int i = 97; i < 123; i++)
            {
                dwe.Write(a[i]);

                dwe.Write(",");
            }
            //dwe.Write("\n");
            for(int i=0;i<26; i++)
            {
                for(int j=0;j<26;j++)
                {
                    //sk.Write(seek[i, j]);
                    dwe.Write(seek[i, j]);
                    dwe.Write(",");
                    /*if (i == 25 || j == 25)
                    {
                        sk.Write("\n");
                    }
                    else
                    {
                        sk.Write(",");
                    }*/
                }
            }
            dwe.Write("\n");
            //Close the file.
            //sk.Close();
            dwe.Close();
            if (DoOpenExcel.Checked == true)
            {
                System.Diagnostics.Process.Start(@"kmb_dwell.csv");
            }
            if(ReOpen.Checked == true)
            {
                Process.Start(MyProg);
            }
            this.Close();

        }

        
    }
}
