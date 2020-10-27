using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rekenmachine1
{
    
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnsKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += ResultText.Text;
            
        }

        private void IsKnop_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(Boventext.Text);
                float num2 = float.Parse(UserInputText.Text);
                if (EuroKnop.BackColor == Color.LightBlue)
                {
                    if (SymboolText.Text == "+")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += Math.Round(num1 + num2, 2);

                    }
                    else if (SymboolText.Text == "-")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += Math.Round(num1 - num2, 2);

                    }
                    else if (SymboolText.Text == "*")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += Math.Round(num1 * num2, 2);

                    }
                    else if (SymboolText.Text == "/")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += Math.Round(num1 / num2, 2);


                    }
                    else if (SymboolText.Text == "%")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += Math.Round((num1 / 100) * num2, 2);
                    }
                }
                else
                {
                    if (SymboolText.Text == "+")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += num1 + num2;

                    }
                    else if (SymboolText.Text == "-")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += num1 - num2;

                    }
                    else if (SymboolText.Text == "*")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += num1 * num2;

                    }
                    else if (SymboolText.Text == "/")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += num1 / num2;

                    }
                    else if (SymboolText.Text == "%")
                    {
                        UserInputText.Clear();
                        Boventext.Clear();
                        SymboolText.Clear();
                        ResultText.Clear();
                        ResultText.Text += (num1 / 100) * num2;
                    }
                }


            }
            catch (Exception )
            {
                UserInputText.Clear();
                Boventext.Clear();
                SymboolText.Clear();
                ResultText.Clear();
            }


        }
        private void EuroKnop_Click(object sender, EventArgs e)
        {
            if (EuroKnop.BackColor == Color.LightBlue)
            {
                EuroKnop.BackColor = Color.White;
            }
            else
            {
                EuroKnop.BackColor = Color.LightBlue;
            }
            FocusInputText();
        }

        private void EuroKnop_Load(object sender, EventArgs e)
        {
            
        }

        private void zevenKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "7";
            FocusInputText();
        }

        private void NulKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "0";
            FocusInputText();
        }

        private void ClearKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Clear();
            Boventext.Clear();
            SymboolText.Clear();
            FocusInputText();

        }

  

        private void FocusInputText()
        {
            UserInputText.Focus();
        }

        private void EenKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "1";
            FocusInputText();
        }

        private void TweeKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "2";
            FocusInputText();
        }

        private void DrieKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "3";
            FocusInputText();
        }

        private void AchtKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "8";
            FocusInputText();
        }

        private void deelKnop_Click(object sender, EventArgs e)
        {
            Boventext.Clear();
            Boventext.Text += UserInputText.Text;
            SymboolText.Clear();
            SymboolText.Text += "/";
            UserInputText.Clear();
            FocusInputText();
        }

        private void KeerKnop_Click(object sender, EventArgs e)
        {
            Boventext.Clear();
            Boventext.Text += UserInputText.Text;
            SymboolText.Clear();
            SymboolText.Text += "*";
            UserInputText.Clear();
            FocusInputText();
        }

        private void KommaKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += ",";
            FocusInputText();
        }

        private void minKnop_Click(object sender, EventArgs e)
        {
            Boventext.Clear();
            Boventext.Text += UserInputText.Text;
            SymboolText.Clear();
            SymboolText.Text += "-";
            UserInputText.Clear();
            FocusInputText();
        }

        private void negenKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "9";
            FocusInputText();
        }

        private void plusKnop_Click(object sender, EventArgs e)
        {
            Boventext.Clear();
            Boventext.Text += UserInputText.Text;
            SymboolText.Clear();
            SymboolText.Text += "+";
            UserInputText.Clear();
            FocusInputText();
        }

        private void VierKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "4";
            FocusInputText();
        }

        private void VijfKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "5";
            FocusInputText();
        }

        private void ZesKnop_Click(object sender, EventArgs e)
        {
            UserInputText.Text += "6";
            FocusInputText();
        }

   

        private void ProcentKnop_Click(object sender, EventArgs e)
        {
            Boventext.Clear();
            Boventext.Text += UserInputText.Text;
            SymboolText.Clear();
            SymboolText.Text += "%";
            UserInputText.Clear();
            FocusInputText();
        }

        private void UserInputText_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
