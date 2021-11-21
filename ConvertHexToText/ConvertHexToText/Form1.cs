using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertHexToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HexT_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                textBox2.Text = ConvertFromHex(textBox1.Text, Encoding.Default);
                //textBox2.Clear();
                //textBox1.Text = textBox1.Text.Replace(" ", "");
                //textBox1.Text = textBox1.Text.Replace("\n\t", "");
                //textBox1.Text = textBox1.Text.Trim();
                //int strlen = textBox1.Text.Length;
                //for(int i = 0; i < strlen; i = i + 2)
                //{
                //    string textconvert = textBox1.Text.Substring(i, 2);
                //    int n = Convert.ToInt32(textconvert, 10);
                //    char c = (char)n;
                //    textBox2.Text = textBox2.Text + c.ToString();
                //}
            }catch(Exception ex)
            {
                MessageBox.Show("Conversion Error Ocurred: " + ex, "Conversion Error");
            }
        }

        private void TexH_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                //textBox2.Text = textBox2.Text.Replace(" ", "");
                textBox2.Text = textBox2.Text.Replace("\n\t", "");
                textBox2.Text = textBox2.Text.Trim();
                int strlen = textBox2.Text.Length;
                for(int i = 0; i < strlen; i++)
                {
                    string hexconvert = textBox2.Text.Substring(i, 1);
                    char c = hexconvert.ToCharArray(0, 1)[0];
                    string n = Convert.ToString(c, 16);
                    textBox1.Text = textBox1.Text + n;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conversion Error Ocurred: " + ex, "Conversion Error");
            }
        }
        static string ConvertFromHex(ReadOnlySpan<char> hexString, Encoding encoding)
        {
            int realLength = 0;
            for (int i = hexString.Length - 2; i >= 0; i -= 2)
            {
                byte b = byte.Parse(hexString.Slice(i, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                if (b != 0) //not NULL character
                {
                    realLength = i + 2;
                    break;
                }
            }

            var bytes = new byte[realLength / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = byte.Parse(hexString.Slice(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return encoding.GetString(bytes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
