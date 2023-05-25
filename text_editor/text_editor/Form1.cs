using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_editor
{
    public partial class Form1 : Form
    {
        private String filestr = "";
        public Form1()
        {
            InitializeComponent();
            filestr = "";
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = openFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                StreamReader readFile = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = readFile.ReadToEnd();
                readFile.Close();
                filestr = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filestr == "")
            {
                DialogResult DR = saveFileDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    StreamWriter writefile = new StreamWriter(saveFileDialog1.FileName);
                    writefile.Write(richTextBox1.Text);
                    writefile.Close();
                    filestr = saveFileDialog1.FileName;
                }
                else
                {
                    StreamWriter writefile = new StreamWriter(filestr);
                    writefile.Write(richTextBox1.Text);
                    writefile.Close();
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = fontDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;

            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = colorDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = colorDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String message = "Hey ! I am Text Editor,  Use Me";
            String title = "Help";
            MessageBox.Show(message, title);
        }
    }
}
