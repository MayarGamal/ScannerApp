using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerGUI
{
    public partial class ScannerApp : Form
    {
        public ScannerApp()
        {
            InitializeComponent();
            output = new List<String>();
        }
        //output list of strings
        public List<string> output;
        bool my_error = false;

        //function to check letters
        public bool Is_letter(char a)
        {
            if ((a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //fuction to check digits
        public bool Is_number(char a)
        {
            if ((a >= '0' && a <= '9'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //scanner function to scan tokens
        public void scanner(string s)
        {

            if (s == "if")
            {
                output.Add("if\tIF");
            }
            else if (s == "then")
            {
                output.Add("then\tTHEN");
            }
            else if (s == "read")
            {
                output.Add("read\tREAD");
            }
            else if (s == "else")
            {
                output.Add("else\tELSE");
            }
            else if (s == "return")
            {
                output.Add("return\tRETURN");
            }
            else if (s == "begin")
            {
                output.Add("begin\tBEGIN");
            }
            else if (s == "end")
            {
                output.Add("end\tEND");
            }
            else if (s == "main")
            {
                output.Add("main\tMAIN");
            }
            else if (s == "string")
            {
                output.Add("string\tSTRING");
            }
            else if (s == "int")
            {
                output.Add("int\tINT");
            }
            else if (s == "until")
            {
                output.Add("until\tUNTIL");
            }
            else if (s == "+")
            {
                output.Add("+\tPLUS");
            }

            else if (s == "-")
            {
                output.Add("-\tMINUS");
            }
            else if (s == "*")
            {
                output.Add("*\tMUL");
            }
            else if (s == "/")
            {
                output.Add("/\tDIVIDE");
            }
            else if (s == ";")
            {
                output.Add(";\tSEMI");
            }
            else if (s == "=")
            {
                output.Add("=\tEQUAL");
            }
            else if (s == "<=")
            {
                output.Add("<=\tLESS THAN OR EQUAL");
            }
            else if (s == ">=")
            {
                output.Add(">=\tMORE THAN OR EQUAL");
            }
            else if (s == ":=")
            {
                output.Add(":=\tassign");
            }
            else if (s == "[")
            {
                output.Add("[\tLeft bracket");
            }
            else if (s == "(")
            {
                output.Add("(\tLeft bracket");
            }
            else if (s == "]")
            {
                output.Add("]\tright bracket");
            }
            else if (s == ")")
            {
                output.Add(")\tright bracket");
            }
            else if (s == "<")
            {
                output.Add("<\tAngle bracket");
            }
            else if (s == ">")
            {
                output.Add(">\tAngle bracket");
            }
            else if (Is_letter(s[0]))
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (!Is_letter(s[i]))
                    {
                        my_error = true;
                    }
                    /*else
                    {
                        output.Add(s + "\tidentifier");
                    }*/
                }
                output.Add(s + "\tidentifier");
            }
            else if (Is_number(s[0]))
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (!Is_number(s[i]))
                    {
                        my_error = true;
                      
                    }
                }

                output.Add(s + "\tnumber");
            }
            else
            {
                my_error = true;
               

            }

        }


        public string input;
        public int input_size;
        public string temp;
        public int count = 0;


        private void InputText_TextChanged(object sender, EventArgs e)
        {
            input = InputText.Text;
            input_size = input.Length;
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {

            Tokenstext.Text = String.Empty;
            output.Clear();

            for (int i = 0; i < input_size; )
            {
                count = 0;
                temp = string.Empty;
                if (Is_letter(input[i]) || Is_number(input[i]))
                {
                    char ip = input[i];
                    string input_s = ip.ToString();
                    int length = temp.Length;
                   temp = temp.Insert(length, input_s);
                    i++;

                    /* temp.resize(temp.Length + 1);
                     temp[count] = input[i];
                     count++;
                     i++;*/

                    while ((i < input_size) && (Is_letter(input[i]) || Is_number(input[i])))
                    {

                        ip = input[i];
                        input_s = ip.ToString();
                        length = temp.Length;
                        temp = temp.Insert(length, input_s);
                        i++;

                        /*  temp.resize(temp.Length + 1);
                          temp[count] = input[i];
                        
                          count++;*/
                    }
                    scanner(temp);
                }else if (Is_number(input[i]))
                {
                    char ip = input[i];
                    string input_s = ip.ToString();
                    int length = temp.Length;
                    temp = temp.Insert(length, input_s);
                    i++;

                    /* temp.resize(temp.Length + 1);
                     temp[count] = input[i];
                     count++;
                     i++;*/

                    while ( Is_number(input[i]))
                    {

                        ip = input[i];
                        input_s = ip.ToString();
                        length = temp.Length;
                        temp = temp.Insert(length, input_s);
                        i++;

                        /*  temp.resize(temp.Length + 1);
                          temp[count] = input[i];
                        
                          count++;*/
                    }
                    scanner(temp);
                }
                else if (input[i] == ' ')
                {
                    i++;
                }
                else if (input[i] == ':' || input[i] == '>' || input[i] == '<')
                {

                    char ip = input[i];
                    string input_s = ip.ToString();
                    int length = temp.Length;
                    temp = temp.Insert(length, input_s);
                    i++;

                    /*  temp.resize(temp.Length + 1);
                      temp[count] = input[i];
                      i++;
                      count++;*/

                    if (i < input_size && input[i] == '=' )
                    {

                        ip = input[i];
                        input_s = ip.ToString();
                        length = temp.Length;
                        temp = temp.Insert(length, input_s);
                        i++;

                        /*  temp.resize(temp.Length + 1);
                          temp[count] = input[i];
                          i++;
                          count++;*/
                    }
                    else
                    {
                        my_error = true;
                    }
                    scanner(temp);
                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == ';' || input[i] == '*' || input[i] == '/'
                    || input[i] == '[' || input[i] == ']' || input[i] == '(' || input[i] == ')' || input[i] == '=')
                {

                    char ip = input[i];
                    string input_s = ip.ToString();
                    int length = temp.Length;
                    temp = temp.Insert(length, input_s);
                    i++;

                    /* temp.resize(temp.Length + 1);
                     temp[count] = input[i];
                     i++;
                     count++;*/
                    scanner(temp);
                }
                else if (input[i] == '{')
                {

                    i++;
                    while (input[i] != '}' && i < input_size)
                    {
                        i++;
                    }
                    i++;
                }
                else
                {
                    my_error = true;
                    break;
                }
            }

            if (my_error)
            {
                string value = "ERROR!!!";
                Tokenstext.Text = value ;
                my_error = false;
            }
            else
            {
                for (int i = 0 ; i < output.Count; i++)
                {
                    string value = output[i];
                    Tokenstext.Text += value + "\r\n";
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tokenstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Tokenstext.Text = String.Empty;
            InputText.Text = String.Empty;
        }
    }
}


