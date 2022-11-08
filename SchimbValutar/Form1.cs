using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchimbValutar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DeSchimbat.Items.Add("US DOLLARS"); 
            DeSchimbat.Items.Add("EURO");
            DeSchimbat.Items.Add("BRITISH POUND");
            DeSchimbat.Items.Add("LEI");
            DeSchimbat.Items.Add("CANADIAN DOLLARS");


            //---------------------------------


            ceSeObtine.Items.Add("US DOLLARS");
            ceSeObtine.Items.Add("EURO");
            ceSeObtine.Items.Add("BRITISH POUND");
            ceSeObtine.Items.Add("CANADIAN DOLLARS");
            ceSeObtine.Items.Add("LEI");


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DeSchimbat.Text == "US DOLLARS" && ceSeObtine.Text == "EURO")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.89882)).ToString();
            }
            if (DeSchimbat.Text == "US DOLLARS" && ceSeObtine.Text == "BRITISH POUND")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.76554)).ToString();
            }
            if (DeSchimbat.Text == "US DOLLARS" && ceSeObtine.Text == "LEI")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (4.28175)).ToString();
            }
            if (DeSchimbat.Text == "US DOLLARS" && ceSeObtine.Text == "CANADIAN DOLLARS")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (1.31188)).ToString();
            }
            if (DeSchimbat.Text == "EURO" && ceSeObtine.Text == "US DOLLARS")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (1.11243)).ToString();
            }
            if (DeSchimbat.Text == "EURO" && ceSeObtine.Text == "CANADIAN DOLLARS")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (1.45938)).ToString();
            }
            if (DeSchimbat.Text == "EURO" && ceSeObtine.Text == "BRITISH POUND")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.85164)).ToString();
            }
            if (DeSchimbat.Text == "EURO" && ceSeObtine.Text == "LEI")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (4.76317)).ToString();
            }
            if (DeSchimbat.Text == "BRITISH POUND" && ceSeObtine.Text == "US DOLLARS")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (1.30606)).ToString();
            }
            if (DeSchimbat.Text == "BRITISH POUND" && ceSeObtine.Text == "LEI")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (5.59221)).ToString();
            }
            if (DeSchimbat.Text == "BRITISH POUND" && ceSeObtine.Text == "EURO")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (1.17394)).ToString();         
            } 
            if (DeSchimbat.Text == "BRITISH POUND" && ceSeObtine.Text == "CANADIAN DOLLARS")
                {
                    tbx2.Text = (double.Parse(tbx1.Text) * (1.71339)).ToString();
                }
            if (DeSchimbat.Text == "LEI" && ceSeObtine.Text == "EURO")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.20946)).ToString();
            }
            if (DeSchimbat.Text == "LEI" && ceSeObtine.Text == "US DOLLARS")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.23304)).ToString();
            }
            if (DeSchimbat.Text == "LEI" && ceSeObtine.Text == "CANADIAN DOLLARS")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.30572)).ToString();
            }
            if (DeSchimbat.Text == "LEI" && ceSeObtine.Text == "BRITISH POUND")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.17840)).ToString();
            }
            if (DeSchimbat.Text == "CANADIAN DOLLARS" && ceSeObtine.Text == "BRITISH POUND")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.58347)).ToString();
            }
            if (DeSchimbat.Text == "CANADIAN DOLLARS" && ceSeObtine.Text == "US DOLLARS")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.76216)).ToString();
            }
            if (DeSchimbat.Text == "CANADIAN DOLLARS" && ceSeObtine.Text == "EURO")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (0.68504)).ToString();
            }
            if (DeSchimbat.Text == "CANADIAN DOLLARS" && ceSeObtine.Text == "LEI")
            {
                tbx2.Text = (double.Parse(tbx1.Text) * (3.26337)).ToString();
            }
            if (DeSchimbat.Text==ceSeObtine.Text)
            {
                tbx2.Text = tbx1.Text;
            }
        }

     
    }
}
