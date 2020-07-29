using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !e.KeyChar.Equals((char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(IsNullOrEmptyFields())
            {
                if(IsValidEmail())
                {
                    if(IsPasswordValid())
                    {
                        if(IsValidPhoneNumber())
                        {
                            MessageBox.Show("REGISTRO FEITO COM SUCESSO!");
                        }
                        else
                        {
                            MessageBox.Show("O NÚMERO DE TELEFONE ESTÁ INCORRETO!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("OS PASSWORDS NÃO ESTÃO IGUAIS!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("O EMAIL COLOCADO NÃO É VÁLIDO!");
                }
            }
            else
            {
                MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS!");
            }    
        }

        private bool IsNullOrEmptyFields()
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                !string.IsNullOrWhiteSpace(textBoxEmail.Text) &&
                !string.IsNullOrWhiteSpace(textBoxPassword.Text) &&
                !string.IsNullOrWhiteSpace(textBoxConfPassword.Text) &&
                !string.IsNullOrWhiteSpace(textBoxCountry.Text) &&
                !string.IsNullOrWhiteSpace(cbGender.Text) &&
                !string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsValidEmail()
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            if (!reg.IsMatch(textBoxEmail.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsPasswordValid()
        {
            if (textBoxPassword.Text.Equals(textBoxConfPassword.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber()
        {
            if(textBoxPhoneNumber.Text.Length.Equals(9))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = textBoxEmail.Text = textBoxPassword.Text = textBoxConfPassword.Text =
            textBoxCountry.Text = cbGender.Text = textBoxPhoneNumber.Text = string.Empty;
        }
    }
}
