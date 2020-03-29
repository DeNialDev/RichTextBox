using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Input;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;


namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Código para abrir un archivo en formato rtf
            openFileDialog1.DefaultExt = ".rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        { 

            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily family in fonts.Families)
            {
                toolStripDropDownButton1.DropDownItems.Add(family.Name);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

           
            }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }


            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;
                if (richTextBox1.SelectionFont.Bold)
                {

                    style &= ~FontStyle.Bold;
                }
                else
                {
                    style |= FontStyle.Bold;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, style);
            }
    }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }


            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;
                if (richTextBox1.SelectionFont.Italic)
                {

                    style &= ~FontStyle.Italic;
                }
                else
                {
                    style |= FontStyle.Italic;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, style);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }


            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;
                if (richTextBox1.SelectionFont.Underline)
                {

                    style &= ~FontStyle.Underline;
                }
                else
                {
                    style |= FontStyle.Underline;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, style);
            }
        }

        private void toolStripDropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(e.ClickedItem.Text, richTextBox1.Font.Size);
            }
            richTextBox1.SelectionFont = new Font(e.ClickedItem.Text, richTextBox1.SelectionFont.Size);

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
