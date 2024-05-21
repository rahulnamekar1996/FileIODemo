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
using System.Xml.Linq;

namespace FileIODemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\ProductData";
                if (Directory.Exists(path)) // if folder is present then returns true
                {
                    MessageBox.Show("Directory exits");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory Created..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {

            try
            {

                string path = @"D:\ProductData\product.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File exits");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\ProductData\pro.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtpid.Text));
                bw.Write(txtpname.Text);
                bw.Write(Convert.ToDouble(txtPprice.Text));
                bw.Close();
                fs.Close(); // file will be closed from buffer
                MessageBox.Show("Add the data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\ProductData\pro.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtpid.Text = br.ReadInt32().ToString();
                txtpname.Text = br.ReadString();
                txtPprice.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStreamWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\ProductData\sample.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStreamReader_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"D:\ProductData\sample.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
