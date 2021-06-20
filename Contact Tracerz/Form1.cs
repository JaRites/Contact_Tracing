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
            saveInfo(NameTxtBx.Text, SexTxtBx.Text, byte.Parse(AgeTxtBx.Text), AddTxtBx.Text, byte.Parse(TempTxtBx.Text), long.Parse(ContactTxtBx.Text), CoughChckBx.Text, FeverChckBx.Text, BodyChckBx.Text, ThroatChckBx.Text, OthersTxtBx.Text, YesChckBx.Text, NoChckBx.Text);        

        }

        private void saveInfo(string Name, string Sex, byte Age, string Address, byte Temperature, long Contact_Number, string Cough, string Fever, string Body_Pain, string Sore_Throat, string Others, string Vaccinated_Yes, string Vaccinated_No)
        {          

            StreamWriter output = File.AppendText("Output.Txt");
            output.WriteLine("Information:");
            output.WriteLine("Name:" + Name);
            output.WriteLine("Sex:" + Sex);
            output.WriteLine("Age:" + Age.ToString());
            output.WriteLine("Address:" + Address);
            output.WriteLine("Temperature:" + Temperature.ToString() + "°C");
            output.WriteLine("Contact Number:0" + Contact_Number);
            output.WriteLine("");
            output.WriteLine("Symptoms:");
            if (CoughChckBx.Checked == true)
                output.WriteLine(Cough);
            if (FeverChckBx.Checked == true)
                output.WriteLine(Fever);
            if (BodyChckBx.Checked == true)
                output.WriteLine(Body_Pain);
            if (ThroatChckBx.Checked == true)
                output.WriteLine(Sore_Throat);
            else
                output.WriteLine(Others);
            output.WriteLine("");
            output.WriteLine("Are you vaccinated?");
            if (YesChckBx.Checked == true)
                output.WriteLine("Yes");
            if (NoChckBx.Checked == true)
                output.WriteLine("No");

            output.WriteLine("=============================");
            output.Close();

        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = File.OpenText("Output.txt");

            while (!inputFile.EndOfStream)
            {
                MessageBox.Show(inputFile.ReadLine());
            }
      

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
