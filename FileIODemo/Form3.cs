using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FileIODemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\StudentData";
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

                string path = @"D:\StudentData\student.txt";
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
                FileStream fs = new FileStream(@"D:\StudentData\std.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtid.Text));
                bw.Write(txtname.Text);
                bw.Write(Convert.ToDouble(txtpercentage.Text));
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

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Student employee = new Student();
                employee.Id = Convert.ToInt32(txtid.Text);
                employee.Name = txtname.Text;
                employee.Percentage = Convert.ToDouble(txtpercentage.Text);
                FileStream fs = new FileStream(@"D:\StudentData\stdBinary.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Student std = new Student();
                FileStream fs = new FileStream(@"D:\StudentData\stdBinary.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                std = (Student)bf.Deserialize(fs);
                fs.Close();
                txtid.Text = std.Id.ToString();
                txtname.Text =std.Name;
                txtpercentage.Text = std.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void btnXmlWrite_Click_1(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                student.Id = Convert.ToInt32(txtid.Text);
                student.Name = txtname.Text;
                student.Percentage = Convert.ToDouble(txtpercentage.Text);
                FileStream fs = new FileStream(@"D:\StudentData\stdXml.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                xs.Serialize(fs, student);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXmlRead_Click_1(object sender, EventArgs e)
        {
            try
            {
                Student emp = new Student();
                FileStream fs = new FileStream(@"D:\StudentData\stdXml.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                emp = (Student)xs.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.Id.ToString();
                txtname.Text = emp.Name;
                txtpercentage.Text = emp.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click_1(object sender, EventArgs e)
        {
            try
            {
                Student employee = new Student();
                employee.Id = Convert.ToInt32(txtid.Text);
                employee.Name = txtname.Text;
                employee.Percentage = Convert.ToDouble(txtpercentage.Text);
                FileStream fs = new FileStream(@"D:\StudentData\stdSoap.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapRead_Click_1(object sender, EventArgs e)
        {

            try
            {
                Student employee = new Student();
                FileStream fs = new FileStream(@"D:\StudentData\stdSoap.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                employee = (Student)sf.Deserialize(fs);
                fs.Close();
                txtid.Text = employee.Id.ToString();
                txtname.Text = employee.Name;
                txtpercentage.Text = employee.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonWrite_Click_1(object sender, EventArgs e)
        {
            try
            {
                Student std = new Student();
                std.Id = Convert.ToInt32(txtid.Text);
                std.Name = txtname.Text;
                std.Percentage = Convert.ToDouble(txtpercentage.Text);
                FileStream fs = new FileStream(@"D:\StudentData\stdJson.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Student>(fs, std);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJsonRead_Click_1(object sender, EventArgs e)
        {
            try
            {
                Student std = new Student();
                FileStream fs = new FileStream(@"D:\StudentData\stdJson.json", FileMode.Open, FileAccess.Read);
                std = JsonSerializer.Deserialize<Student>(fs);
                fs.Close();
                txtid.Text = std.Id.ToString();
                txtname.Text = std.Name;
                txtpercentage.Text = std.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
