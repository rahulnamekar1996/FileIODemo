namespace FileIODemo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStreamReader = new System.Windows.Forms.Button();
            this.btnStreamWriter = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStreamReader
            // 
            this.btnStreamReader.Location = new System.Drawing.Point(649, 214);
            this.btnStreamReader.Name = "btnStreamReader";
            this.btnStreamReader.Size = new System.Drawing.Size(144, 23);
            this.btnStreamReader.TabIndex = 25;
            this.btnStreamReader.Text = "Stream Reader";
            this.btnStreamReader.UseVisualStyleBackColor = true;
            this.btnStreamReader.Click += new System.EventHandler(this.btnStreamReader_Click);
            // 
            // btnStreamWriter
            // 
            this.btnStreamWriter.Location = new System.Drawing.Point(466, 214);
            this.btnStreamWriter.Name = "btnStreamWriter";
            this.btnStreamWriter.Size = new System.Drawing.Size(158, 23);
            this.btnStreamWriter.TabIndex = 24;
            this.btnStreamWriter.Text = "Stream Writer";
            this.btnStreamWriter.UseVisualStyleBackColor = true;
            this.btnStreamWriter.Click += new System.EventHandler(this.btnStreamWriter_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(494, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(299, 96);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(286, 121);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(120, 23);
            this.btnCreateFile.TabIndex = 22;
            this.btnCreateFile.Text = "Cretae File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(286, 72);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(120, 23);
            this.btnCreateDirectory.TabIndex = 21;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(119, 241);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 20;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(7, 241);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 19;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtPprice
            // 
            this.txtPprice.Location = new System.Drawing.Point(132, 175);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(100, 20);
            this.txtPprice.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enter Price";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(132, 128);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(100, 20);
            this.txtpname.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Product  Name";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(132, 75);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(100, 20);
            this.txtpid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Product Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStreamReader);
            this.Controls.Add(this.btnStreamWriter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtPprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStreamReader;
        private System.Windows.Forms.Button btnStreamWriter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label1;
    }
}