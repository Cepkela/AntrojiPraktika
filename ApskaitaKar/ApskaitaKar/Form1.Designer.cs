﻿namespace ApskaitaKar
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
        public void InitializeComponent()
        {
            this.btnIkelti = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvKariai = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKartojimas = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKariai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIkelti
            // 
            this.btnIkelti.Location = new System.Drawing.Point(123, 81);
            this.btnIkelti.Name = "btnIkelti";
            this.btnIkelti.Size = new System.Drawing.Size(75, 23);
            this.btnIkelti.TabIndex = 3;
            this.btnIkelti.Text = "Ikelimas";
            this.btnIkelti.UseVisualStyleBackColor = true;
            this.btnIkelti.Click += new System.EventHandler(this.BtnIkelti_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509"});
            this.comboBox1.Location = new System.Drawing.Point(77, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // dgvKariai
            // 
            this.dgvKariai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKariai.Location = new System.Drawing.Point(39, 193);
            this.dgvKariai.Name = "dgvKariai";
            this.dgvKariai.Size = new System.Drawing.Size(640, 150);
            this.dgvKariai.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kuopa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registracija";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registracija į šaudyma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pratimo Kartojimo Kiekis";
            // 
            // txtKartojimas
            // 
            this.txtKartojimas.Location = new System.Drawing.Point(450, 40);
            this.txtKartojimas.Name = "txtKartojimas";
            this.txtKartojimas.Size = new System.Drawing.Size(100, 20);
            this.txtKartojimas.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Rezultatu Ivedimas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtKartojimas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKariai);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIkelti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKariai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIkelti;
        private System.Windows.Forms.DataGridView dgvKariai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKartojimas;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

