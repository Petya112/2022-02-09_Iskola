
namespace IskolaGUI
{
    partial class Form1
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
            this.btnTörlés = new System.Windows.Forms.Button();
            this.gMentés = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTörlés
            // 
            this.btnTörlés.Location = new System.Drawing.Point(12, 311);
            this.btnTörlés.Name = "btnTörlés";
            this.btnTörlés.Size = new System.Drawing.Size(75, 23);
            this.btnTörlés.TabIndex = 0;
            this.btnTörlés.Text = "Törlés";
            this.btnTörlés.UseVisualStyleBackColor = true;
            this.btnTörlés.Click += new System.EventHandler(this.btnTörlés_Click);
            // 
            // gMentés
            // 
            this.gMentés.Location = new System.Drawing.Point(93, 311);
            this.gMentés.Name = "gMentés";
            this.gMentés.Size = new System.Drawing.Size(101, 23);
            this.gMentés.TabIndex = 1;
            this.gMentés.Text = "Állomány mentés";
            this.gMentés.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 277);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(210, 348);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gMentés);
            this.Controls.Add(this.btnTörlés);
            this.Name = "Form1";
            this.Text = "IskolaGUI";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTörlés;
        private System.Windows.Forms.Button gMentés;
        private System.Windows.Forms.ListBox listBox1;
    }
}

