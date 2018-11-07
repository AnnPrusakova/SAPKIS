using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string tab = "";
        static string[] list = new string[1];
        static int count;
        static string[] files;
  

        FolderBrowserDialog FBD = new FolderBrowserDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = FBD.SelectedPath;
            }
        }
       


        private void button2_Click(object sender, EventArgs e)
        {


            string ListPatch = "найденные папки и файлы \r\n";
            count = 0;
            vlozhenost(FBD.SelectedPath, Directory.GetCurrentDirectory());
            for (int i = 0; i < list.Length - 1; i++)
            {
                ListPatch += list[i] + Environment.NewLine;
            }
            StreamWriter SW = new StreamWriter(new FileStream("List.txt", FileMode.Create, FileAccess.Write));
            SW.Write(ListPatch);
            SW.Close();
            MessageBox.Show("Information Saved Successfully");

        }

        private void vlozhenost(String path, String dir)
        {
            string[] dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                dirs[i] = dirs[i].Substring(path.Length);
            }
            Array.Resize(ref list, list.Length + 1);
            list[count++] = tab + path.Substring(dir.Length);
            files = Directory.GetFiles(path);
            Array.Resize(ref list, list.Length + files.Length);
            tab += "    ";
            for (int i = 0; i < files.Length; i++)
            {
                list[count] = tab + files[i].Substring(path.Length);
                count += 1;
            }
            tab = tab.Substring(4);
            for (int i = 0; i < dirs.Length; i++)
            {
                tab += "    ";
                vlozhenost(path + dirs[i], path);
                tab = tab.Substring(4);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
