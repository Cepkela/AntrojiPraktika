namespace ApskaitaKar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGulint = new System.Windows.Forms.TextBox();
            this.txtStovint = new System.Windows.Forms.TextBox();
            this.txtIsApkaso = new System.Windows.Forms.TextBox();
            this.txtPriklaupus = new System.Windows.Forms.TextBox();
            this.txtSedint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAtstumas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbVardas = new System.Windows.Forms.ComboBox();
            this.btnIšsaugoti = new System.Windows.Forms.Button();
            this.btnGryžti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Karys";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pratimo rezultatai";
            // 
            // txtGulint
            // 
            this.txtGulint.Location = new System.Drawing.Point(75, 73);
            this.txtGulint.Name = "txtGulint";
            this.txtGulint.Size = new System.Drawing.Size(121, 20);
            this.txtGulint.TabIndex = 5;
            // 
            // txtStovint
            // 
            this.txtStovint.Location = new System.Drawing.Point(75, 177);
            this.txtStovint.Name = "txtStovint";
            this.txtStovint.Size = new System.Drawing.Size(121, 20);
            this.txtStovint.TabIndex = 6;
            // 
            // txtIsApkaso
            // 
            this.txtIsApkaso.Location = new System.Drawing.Point(75, 99);
            this.txtIsApkaso.Name = "txtIsApkaso";
            this.txtIsApkaso.Size = new System.Drawing.Size(121, 20);
            this.txtIsApkaso.TabIndex = 7;
            // 
            // txtPriklaupus
            // 
            this.txtPriklaupus.Location = new System.Drawing.Point(75, 125);
            this.txtPriklaupus.Name = "txtPriklaupus";
            this.txtPriklaupus.Size = new System.Drawing.Size(121, 20);
            this.txtPriklaupus.TabIndex = 8;
            // 
            // txtSedint
            // 
            this.txtSedint.Location = new System.Drawing.Point(74, 151);
            this.txtSedint.Name = "txtSedint";
            this.txtSedint.Size = new System.Drawing.Size(121, 20);
            this.txtSedint.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gulint";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Iš apkaso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Priklaupus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sėdint";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Stovint";
            // 
            // cbAtstumas
            // 
            this.cbAtstumas.FormattingEnabled = true;
            this.cbAtstumas.Items.AddRange(new object[] {
            "100m"});
            this.cbAtstumas.Location = new System.Drawing.Point(74, 203);
            this.cbAtstumas.Name = "cbAtstumas";
            this.cbAtstumas.Size = new System.Drawing.Size(121, 21);
            this.cbAtstumas.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Atstumas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Rezultatu ivedimas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbVardas
            // 
            this.cbVardas.FormattingEnabled = true;
            this.cbVardas.Location = new System.Drawing.Point(74, 46);
            this.cbVardas.Name = "cbVardas";
            this.cbVardas.Size = new System.Drawing.Size(121, 21);
            this.cbVardas.TabIndex = 18;
            // 
            // btnIšsaugoti
            // 
            this.btnIšsaugoti.Location = new System.Drawing.Point(12, 297);
            this.btnIšsaugoti.Name = "btnIšsaugoti";
            this.btnIšsaugoti.Size = new System.Drawing.Size(75, 23);
            this.btnIšsaugoti.TabIndex = 19;
            this.btnIšsaugoti.Text = "Išsaugoti";
            this.btnIšsaugoti.UseVisualStyleBackColor = true;
            this.btnIšsaugoti.Click += new System.EventHandler(this.BtnIšsaugoti_Click);
            // 
            // btnGryžti
            // 
            this.btnGryžti.Location = new System.Drawing.Point(126, 297);
            this.btnGryžti.Name = "btnGryžti";
            this.btnGryžti.Size = new System.Drawing.Size(75, 23);
            this.btnGryžti.TabIndex = 20;
            this.btnGryžti.Text = "Gryžti";
            this.btnGryžti.UseVisualStyleBackColor = true;
            this.btnGryžti.Click += new System.EventHandler(this.BtnGryžti_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 328);
            this.Controls.Add(this.btnGryžti);
            this.Controls.Add(this.btnIšsaugoti);
            this.Controls.Add(this.cbVardas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAtstumas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSedint);
            this.Controls.Add(this.txtPriklaupus);
            this.Controls.Add(this.txtIsApkaso);
            this.Controls.Add(this.txtStovint);
            this.Controls.Add(this.txtGulint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGulint;
        private System.Windows.Forms.TextBox txtStovint;
        private System.Windows.Forms.TextBox txtIsApkaso;
        private System.Windows.Forms.TextBox txtPriklaupus;
        private System.Windows.Forms.TextBox txtSedint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAtstumas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbVardas;
        private System.Windows.Forms.Button btnIšsaugoti;
        private System.Windows.Forms.Button btnGryžti;
    }
}