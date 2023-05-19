namespace KlausurPrefab
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblHorsepower = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 95);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(287, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(343, 290);
            this.listBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show Car List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(636, 70);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(132, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Farbe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Geschwindigkeit";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(731, 113);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(10, 13);
            this.lblBrand.TabIndex = 10;
            this.lblBrand.Text = "-";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(731, 126);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(10, 13);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "-";
            // 
            // lblHorsepower
            // 
            this.lblHorsepower.AutoSize = true;
            this.lblHorsepower.Location = new System.Drawing.Point(731, 139);
            this.lblHorsepower.Name = "lblHorsepower";
            this.lblHorsepower.Size = new System.Drawing.Size(10, 13);
            this.lblHorsepower.TabIndex = 12;
            this.lblHorsepower.Text = "-";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(731, 152);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(10, 13);
            this.lblSpeed.TabIndex = 13;
            this.lblSpeed.Text = "-";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Save in TXT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Load from TXT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 405);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblHorsepower);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblHorsepower;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

