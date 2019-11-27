using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int[] abc = new int[3];
            int max = 0;
            int t = 0;

            abc[0] = int.Parse(tbxA.Text);
            abc[1] = int.Parse(tbxB.Text);
            abc[2] = int.Parse(tbxC.Text);

            for (int i = 0; i < abc.Length - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < abc.Length; j++)
                {
                    if (abc[max] < abc[j])
                        max = j;
                }
                if (i == max)
                    continue;

                t = abc[max];
                abc[max] = abc[i];
                abc[i] = t;
            }

            lblmax.Text = Convert.ToString(abc[0]);
            lblmid.Text = Convert.ToString(abc[1]);
            lblmin.Text = Convert.ToString(abc[2]);
        }
    }
}

