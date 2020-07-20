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

namespace CSharp_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                if (richTextBox1.Text != "")
                {
                    SaveFileDialog sdf = new SaveFileDialog();
                    sdf.ShowDialog();
                    if (sdf.FileName.ToString() != "")
                    {
                        StreamWriter sw = new StreamWriter(sdf.FileName);
                        sw.Write(richTextBox1.Text);
                        sw.Close();
                    }
                    else
                    {
                        MessageBox.Show("File Not Saved");
                    }
                }
                else
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            MessageBox.Show(fd.FileName);
            StreamReader sr = new StreamReader(fd.FileName);
            string str = sr.ReadLine();
            while (str != null)
            {
                richTextBox1.Text = str;
                str = sr.ReadLine();

            }
            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();
            sdf.ShowDialog();
            StreamWriter sw = new StreamWriter(sdf.FileName);
            sw.Write(richTextBox1.Text);
            sw.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
if (richTextBox1.Text != "")
            {
                richTextBox1.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
