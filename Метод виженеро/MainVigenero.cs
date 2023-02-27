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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Метод_виженеро
{
    public partial class MainVigenero : Form
    {
        public MainVigenero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            if (KeyWord.Text.Length > 0)
            {
                result.Text = Vigenere.Encode(Word.Text, KeyWord.Text).ToLower();
            }
            else
                MessageBox.Show("Введите ключевое слово!");
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0)
            {
                Word.Text = Vigenere.Decode(result.Text, KeyWord.Text).ToLower();
            }
            else
                MessageBox.Show("Введите ключевое слово!");
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            string text = result.Text;

            File.WriteAllText(filename, text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
