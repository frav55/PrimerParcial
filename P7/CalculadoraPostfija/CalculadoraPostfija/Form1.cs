using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPostfija
{
    public partial class Form1 : Form
    {
        int numa = 0, numb = 0;
        bool numaIns = false, numbIns = false;
        public Form1()
        {
            InitializeComponent();
            disable_ops();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button8.Text;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonSup_Click(object sender, EventArgs e)
        {
            textScreen.Clear();
            numa = 0;
            numaIns = false;
            numb = 0;
            numbIns = false;
            enable_nums();
            disable_ops();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            disable_nums();
            if (numaIns&&numbIns)
                textScreen.Text = (numa + numb)+"";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button0.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + button9.Text;
        }

        private void buttonNtr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textScreen.Text))
            {
                if (!numaIns)
                {
                    numa = int.Parse(textScreen.Text);
                    numaIns = true;
                    textScreen.Clear();
                }
                else if (!numbIns)
                {
                    numb = int.Parse(textScreen.Text);
                    numbIns = true;
                    textScreen.Clear();
                    enable_ops();
                }
                else
                {
                    //textScreen.Clear();
                    textScreen.Text = "Presiona una operación o Clear";
                }
            }
        }
        private void disable_nums()
        {
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void enable_nums()
        {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            disable_nums();
            textScreen.Text = (numa - numb) + "";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            disable_nums();
            textScreen.Text = (numa * numb) + "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            disable_nums();
            float div = (float)numa / numb;

            textScreen.Text = div+"";
        }

        private void disable_ops()
        {
            buttonSum.Enabled = false;
            buttonRes.Enabled = false;
            buttonMul.Enabled = false;
            buttonDiv.Enabled = false;
        }
        private void enable_ops()
        {
            buttonSum.Enabled = true;
            buttonRes.Enabled = true;
            buttonMul.Enabled = true;
            buttonDiv.Enabled = true;
        }
    }
}
