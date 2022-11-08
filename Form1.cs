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

namespace Activity05
{
    public partial class txtVowel : Form
    {
        public txtVowel()
        {
            InitializeComponent();
        }
        String str;
        int max_val = 0, max_index = 0, vow_count = 0, vow_index;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //here we can see the open file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                str = System.IO.File.ReadAllText(openFileDialog1.FileName); //read text file from our string file s
                txtDisplay.Text = str.ToLower();//make it in lower
                string[] array = str.Split(' ');//split string with blank seperator
                txtFirst.Text = array[0];//it is first word
                txtLast.Text = array[array.Length - 1];//it is last word
                for (int i = 0; i < array.Length - 1; i++)//here loop from start to end to make our appropriate output
                {
                    if (max_val < array[i].Length)
                    {
                        max_val = array[i].Length;
                        max_index = i;
                    }
                    if (vow_count < VowelCount(array[i]))
                    {
                        vow_count = VowelCount(array[i]);
                        vow_index = i;
                    }
                }
                txtLongest.Text = array[max_index];//output dispaly
                txtBoxVowel.Text = array[vow_index];//output dispaly
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\write.txt");//Textfile write here
                sw.WriteLine("Converting in Lower ::" + txtDisplay.Text);//Textfile write here
                sw.WriteLine("First Word ::" + txtFirst.Text);//Textfile write here
                sw.WriteLine("Last Word ::" + txtLast.Text);//Textfile write here
                sw.WriteLine("Longest word ::" + txtLongest.Text);//Textfile write here
                sw.WriteLine("Longest Vowel Word ::" + txtBoxVowel.Text);//Textfile write here
                sw.Close();
                MessageBox.Show("Text file is Created");//output display for message
            }

        }
        public int VowelCount(string sentence)//function for vowel count here
        {
            int vowels = 0;
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u') || (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
                'I' || sentence[i] == 'O' || sentence[i] == 'U'))
                {
                    vowels = vowels + 1;
                }

            }
            return vowels;
        }
        private void txtVowel_Load(object sender, EventArgs e)
        {

        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        private void lblLower_Click(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLast_Click(object sender, EventArgs e)
        {

        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLongest_Click(object sender, EventArgs e)
        {

        }

        private void txtLongest_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVowel_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxVowel_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
