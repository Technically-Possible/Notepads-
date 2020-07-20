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


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }
    }
}
