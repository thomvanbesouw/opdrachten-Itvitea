using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_naar_Nederlands_en_terug
{
    public partial class Form1 : Form
    {
        string OriginalText = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MorseKnop_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            string Morse = "";
            OriginalText = textBox1.Text;

            
            foreach (char c in textBox1.Text.ToLower())
            {
               

                switch (c)
                    {
                        case 'a':
                            Morse += ". - / ";
                            break;
                        case 'b':
                            Morse += "- . . . / ";
                            break;
                        case 'c':
                            Morse += "- . - . / ";
                            break;
                        case 'd':
                            Morse += ". - - / ";
                            break;
                        case 'e':
                            Morse += ". / ";
                            break;
                        case 'f':
                            Morse += ". . - . / ";
                            break;
                        case 'g':
                            Morse += "- - . / ";
                            break;
                        case 'h':
                            Morse += ". . . . / ";
                            break;
                        case 'i':
                            Morse += ". . / ";
                            break;
                        case 'j':
                            Morse += ". - - - / ";
                            break;
                        case 'k':
                            Morse += "- . - / ";
                            break;
                        case 'l':
                            Morse += ". - . . / ";
                            break;
                        case 'm':
                            Morse += "- - / ";
                            break;
                        case 'n':
                            Morse += "- . / ";
                            break;
                        case 'o':
                            Morse += "- - - / ";
                            break;
                        case 'p':
                            Morse += ". - - . / ";
                            break;
                        case 'q':
                            Morse += "- - . - / ";
                            break;
                        case 'r':
                            Morse += ". - . / ";
                            break;
                        case 's':
                            Morse += ". . . / ";
                            break;
                        case 't':
                            Morse += "- / ";
                            break;
                        case 'u':
                            Morse += ". . - / ";
                            break;
                        case 'v':
                            Morse += ". . . - / ";
                            break;
                        case 'w':
                            Morse += ". - - / ";
                            break;
                        case 'x':
                            Morse += "- . . - / ";
                            break;
                        case 'y':
                            Morse += "- . - - / ";
                            break;
                        case 'z':
                            Morse += "- - . . / ";
                            break;
                        case ' ':
                            Morse += "   ";
                            break;
                    default:
                        Morse += c + " ";
                        break;
                    


                }
                switch (a)
                {
                    case 0:
                        if (textBox1.Text.Length > 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 1:
                        if (textBox1.Text.Length > b + 72 )
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 2:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 3:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 4:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 5:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 6:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 7:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 8:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 9:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 10:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 11:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 12:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 13:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 14:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 15:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 16:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;
                    case 17:
                        if (textBox1.Text.Length > b + 72)
                        {
                            b = textBox1.Text.Length;
                            textBox1.Text += "\n";
                            a++;
                        }
                        break;

                }
                
            }
            textBox1.Clear();
            textBox1.Text += Morse;
        }

        private void NederlandsKnop_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += OriginalText;
        }
    }
}
