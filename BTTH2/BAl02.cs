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

namespace WindowsFormsApplication2
{
    public partial class BAI02 : Form
    {
        public BAI02()
        {
            InitializeComponent();
        }
        private string FormatFileSize(long fileSizeInBytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            double size = fileSizeInBytes;

            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }
            return $"{size:0.#}{sizes[order]}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    // Open the file dialog to select a file
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
                    openFileDialog1.Title = "Select a Text File";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        // Get the selected file path and file info
                        string filePath = openFileDialog1.FileName;
                        FileInfo fileInfo = new FileInfo(filePath);

                        // Get file name of the file
                        name_textbox.Text = Path.GetFileName(filePath);
                        
                        // Get file size
                        size_textbox.Text = FormatFileSize(fileInfo.Length);
                        
                        // Get url of the file
                        url_textbox.Text = filePath.ToString();    

                        // Read the contents of the file
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                                    string fileContents = reader.ReadToEnd();
                                    string[] fileLines = fileContents.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

                                    string[] fileWords = fileContents.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        // Display the contents in a richTextBox

                                    content_richtext.Text = fileContents;
                                    linecount_textbox.Text = fileLines.Length.ToString();
                                    wordcount_textbox.Text = fileWords.Length.ToString();
                                    charcount_textbox.Text = fileContents.Length.ToString();

                         }
                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
