namespace ApskaitaKar
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
            this.btnIkelti = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvKariai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKariai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIkelti
            // 
            this.btnIkelti.Location = new System.Drawing.Point(161, 156);
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
            this.dgvKariai.Location = new System.Drawing.Point(44, 275);
            this.dgvKariai.Name = "dgvKariai";
            this.dgvKariai.Size = new System.Drawing.Size(640, 150);
            this.dgvKariai.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKariai);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIkelti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKariai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIkelti;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvKariai;
    }
}

