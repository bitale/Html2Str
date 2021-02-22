using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Html2Str
{
    public partial class Form1 : Form
    {
        private Dictionary<String, Encoding> data = new Dictionary<string, Encoding>();
        FileDialog fd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.Add("ASCII", Encoding.ASCII);
            data.Add("UTF-8", Encoding.UTF8);
            data.Add("Unicode", Encoding.Unicode);
            InputFileEncodingComboBox.Items.AddRange(data.Keys.ToArray());
            InputFileEncodingComboBox.SelectedIndex = 1;
            OutputFileEncodingComboBox.Items.AddRange(data.Keys.ToArray());
            OutputFileEncodingComboBox.SelectedIndex = 1;


            LineEndComboBox.Items.AddRange(new string[]{ "\\r\\n", "\\n"});
            LineEndComboBox.SelectedIndex = 0;
        }

        private void InputFileButton_Click(object sender, EventArgs e)
        {
            fd = new OpenFileDialog();
            fd.DefaultExt = "html";
            fd.Filter = "HTML files (*.htm;*.html;*.jsp;*.php)|*.htm;*.html;*.jsp;*.php";
            if (fd.ShowDialog() == DialogResult.OK) InputFileTextBox.Text = fd.FileName;
        }

        private void OutputFileButton_Click(object sender, EventArgs e)
        {
            fd = new SaveFileDialog();
            fd.DefaultExt = "html";
            fd.Filter = "HTML files (*.htm;*.html;*.jsp;*.php)|*.htm;*.html;*.jsp;*.php";
            if (fd.ShowDialog() == DialogResult.OK) OutputFileTextBox.Text = fd.FileName;
        }

        private void ClipBoardCopy_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(InputFileTextBox.Text))
            {
                string save = "";
                String[] a = System.IO.File.ReadAllLines(InputFileTextBox.Text, data[InputFileEncodingComboBox.SelectedItem.ToString()]);
                for (var i = 0; i < a.Length; i++)
                {
                    a[i] = a[i].Replace("\"", "\\\"");
                    a[i] = a[i].Replace("\\t", "\\\\t");
                    a[i] = "\"" + a[i] + "\"" + "+";
                }
                foreach (var b in a) save += b + "\n";
                Clipboard.SetText(save);
                
            }
            else
            {
                MessageBox.Show("지정된 경로에 파일이 존재하지 않습니다.");
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(InputFileTextBox.Text))
            {
                MessageBox.Show(InputFileEncodingComboBox.SelectedItem.ToString());
                String[] a = System.IO.File.ReadAllLines(InputFileTextBox.Text, data[InputFileEncodingComboBox.SelectedItem.ToString()]);
                for (var i = 0; i < a.Length; i++)
                {
                    a[i] = a[i].Replace("\"", "\\\"");
                    a[i] = a[i].Replace("\\t", "\\\\t");
                    a[i] = "\"" + a[i] + "\"" + "+";
                }
                System.IO.File.WriteAllLines(OutputFileTextBox.Text, a);
            }
            else
            {
                MessageBox.Show("지정된 경로에 파일이나 폴더가 존재하지 않습니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lineend = LineEndComboBox.SelectedIndex == 0 ? "\r\n" : "\n";
            String[] a = Clipboard.GetText().Split(lineend.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < a.Length; i++)
            {
                a[i] = a[i].Replace("\"", "\\\"");
                a[i] = a[i].Replace("\\t", "\\\\t");
                a[i] = "\"" + a[i] + "\"" + (i + 1 == a.Length ? ";" : "+" + lineend);
            }
            Clipboard.SetText(string.Join("", a));
        }
    }
}
