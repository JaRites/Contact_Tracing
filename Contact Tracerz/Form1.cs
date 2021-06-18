using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracerz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NameFormatLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveInfo(NameTxtBx.Text, SexTxtBx.Text, byte.Parse(AgeTxtBx.Text), AddTxtBx.Text, byte.Parse(TempTxtBx.Text));
        }

        private void saveInfo(string Name, string Sex, byte Age, string Address, byte Temperature)
        {
            StreamWriter output = File.AppendText("Output.txt");
            output.WriteLine(Name);
            output.WriteLine(Sex);
            output.WriteLine(Age.ToString());
            output.WriteLine(Address);
            output.WriteLine(Temperature.ToString());
            output.WriteLine("==========");
            output.Close();

        }
    }
}
