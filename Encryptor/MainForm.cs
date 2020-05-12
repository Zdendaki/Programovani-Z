using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class MainForm : Form
    {
        Vigener Vigener;
        
        public MainForm()
        {
            InitializeComponent();

            Vigener = new Vigener();
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (!Vigener.Alphabet.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            Output.Text = Vigener.Encrypt(Input.Text, Password.Text);
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            Output.Text = Vigener.Decrypt(Input.Text, Password.Text);
        }

        private void Output_Click(object sender, EventArgs e)
        {
            Output.SelectionStart = 0;
            Output.SelectionLength = Output.TextLength;
        }
    }
}
