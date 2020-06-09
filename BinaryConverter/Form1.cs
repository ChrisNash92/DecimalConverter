using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BinaryConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Decimal_textbox.KeyPress += Decimal_textbox_KeyPress;
            Binary_textbox.KeyPress += Binary_textbox_KeyPress;
            Hexidecimal_textbox.KeyPress += Hexidecimal_textbox_KeyPress;
        }

        private void Hexidecimal_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "[^\b0-9a-fA-F]"))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(e.KeyChar.ToString(), "[a-f]"))
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
        }

        private void Binary_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "[^\b0-1]"))
            {
                e.Handled = true; 
            }
        }

        private void Decimal_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Regex.IsMatch(e.KeyChar.ToString(), "[^\b0-9]"))
            {
                e.Handled = true;
            }

        }

        private void Decimal_radioButton_CheckedChanged(object sender, EventArgs e)
        {            
            if(Decimal_radioButton.Checked)
            {
                
                Decimal_textbox.ReadOnly = false;

                Binary_radioButton.Checked = false;
                Binary_textbox.ReadOnly = true;
                Binary_textbox.BackColor = Color.White;

                Hexidecimal_radioButton.Checked = false;
                Hexidecimal_textbox.ReadOnly = true;
                Hexidecimal_textbox.BackColor = Color.White; 

            }
        }

        private void Binary_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Binary_radioButton.Checked)
            {
                Binary_textbox.ReadOnly = false;

                Decimal_radioButton.Checked = false;
                Decimal_textbox.ReadOnly = true;
                Decimal_textbox.BackColor = Color.White;

                Hexidecimal_radioButton.Checked = false;
                Hexidecimal_textbox.ReadOnly = true;
                Hexidecimal_textbox.BackColor = Color.White;

            }

        }

        private void Hexidecimal_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Hexidecimal_radioButton.Checked)
            {
                Hexidecimal_textbox.ReadOnly = false; 

                Decimal_radioButton.Checked = false;
                Decimal_textbox.ReadOnly = true;
                Decimal_textbox.BackColor = Color.White;

                Binary_radioButton.Checked = false;
                Binary_textbox.ReadOnly = true;
                Binary_textbox.BackColor = Color.White;

            }

        }

        private void Decimal_textbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Decimal_textbox.Text) || Decimal_textbox.Text.Equals("0"))
            {
                Binary_textbox.Text = "0";
                Hexidecimal_textbox.Text = "0";
                Decimal_textbox.SelectAll();
            }
            else
            {
                try
                {
                    Binary_textbox.Text = Program.NumToBin(Convert.ToDouble(Decimal_textbox.Text));
                    Hexidecimal_textbox.Text = Program.NumToHex(Convert.ToDouble(Decimal_textbox.Text));
                }
                catch(OverflowException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().FullName);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show($"{ex.Message} \nPlease only use numbers", ex.GetType().FullName);
                    Decimal_textbox.Text = "0";
                }

            }
            
        }

        private void Binary_textbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Binary_textbox.Text) || Binary_textbox.Text.Equals("0"))
            {
                Decimal_textbox.Text = "0";
                Hexidecimal_textbox.Text = "0";
                Binary_textbox.SelectAll();
            }
            else
            {
                try
                {
                    Decimal_textbox.Text = Program.BinToNum(Binary_textbox.Text);
                    Hexidecimal_textbox.Text = Program.NumToHex(Convert.ToDouble(Program.BinToNum(Binary_textbox.Text)));
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().FullName);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"{ex.Message} \nPlease only use 1s and 0s", ex.GetType().FullName);
                    Binary_textbox.Text = "0";
                }

            }

        }

        private void Hexidecimal_textbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Hexidecimal_textbox.Text) || Hexidecimal_textbox.Text.Equals("0"))
            {
                Decimal_textbox.Text = "0";
                Binary_textbox.Text = "0";
                Hexidecimal_textbox.SelectAll();
            }
            else
            {
                try
                {
                    Decimal_textbox.Text = Program.HexToNum(Hexidecimal_textbox.Text);
                    Binary_textbox.Text = Program.NumToBin(Convert.ToDouble(Program.HexToNum(Hexidecimal_textbox.Text)));
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().FullName);
                }
                catch (KeyNotFoundException ex)
                {
                    MessageBox.Show($"Please only use numbers and A-F", ex.GetType().FullName);
                    Hexidecimal_textbox.Text = "0";
                }

            }
        }


    }
}
