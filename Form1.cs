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

namespace Caesar
{
    public partial class Form1 : Form
    {
        private Caesar caesar;
        public Form1()
        {
            InitializeComponent();

            keyField.Text = "4";

            caesar = new Caesar();
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        void UpdateAll()
        {
            if (keyField.Text.Length == 0) {
                encode.Enabled = false; 
                decode.Enabled = false;
                return;
            }

            if (inputText.Text.Length > 0)
            {
                encode.Enabled = true;
            }
            else
            {
                encode.Enabled = false;
            }

            if(outputText.Text.Length > 0)
            {
                decode.Enabled = true;
            }
            else
            {
                decode.Enabled = false;
            }
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void keyField_TextChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void encode_Click(object sender, EventArgs e)
        {
            int key;
            if(Regex.IsMatch(keyField.Text, @"^\d+$"))
            {
                key = Convert.ToInt32(keyField.Text);
            }
            else
            {
                MessageBox.Show("Ключ невірний", "Помилка");
                return;
            }

            outputText.Text = caesar.Encrypt(inputText.Text, key);
        }

        private void decode_Click(object sender, EventArgs e)
        {
            int key;
            if (Regex.IsMatch(keyField.Text, @"^\d+$"))
            {
                key = Convert.ToInt32(keyField.Text);
            }
            else
            {
                MessageBox.Show("Ключ невірний", "Помилка");
                return;
            }

            inputText.Text = caesar.Decrypt(outputText.Text, key);
        }

        private void frequencyButton_Click(object sender, EventArgs e)
        {
            frequency.Text = "";

            string text = outputText.Text.Replace(" ", string.Empty).ToLower();

            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
                if (dict.ContainsKey(text[i]))
                    dict[text[i]]++;
                else
                    dict.Add(text[i], 1);

            var sortDict = dict.OrderByDescending(x => x.Value);

            foreach (KeyValuePair<char, int> kvp in sortDict)
                frequency.Text += ($"Символ: {kvp.Key}, зустрічається {kvp.Value} раз.\r\n");
        }
    }
}
