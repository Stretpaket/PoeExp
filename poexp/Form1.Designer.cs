namespace poexp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tbClientPath = new System.Windows.Forms.TextBox();
            this.tbCharacterName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "POEXP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Character name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client.txt path";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(218, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Agency FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save settings + Show graph";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Account name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbAccountName
            // 
            this.tbAccountName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAccountName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::poexp.Properties.Settings.Default, "accountNameSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbAccountName.Location = new System.Drawing.Point(14, 173);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(280, 20);
            this.tbAccountName.TabIndex = 1;
            this.tbAccountName.Text = global::poexp.Properties.Settings.Default.accountNameSetting;
            // 
            // tbClientPath
            // 
            this.tbClientPath.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbClientPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClientPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::poexp.Properties.Settings.Default, "clientPathSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbClientPath.Location = new System.Drawing.Point(13, 292);
            this.tbClientPath.Name = "tbClientPath";
            this.tbClientPath.Size = new System.Drawing.Size(199, 20);
            this.tbClientPath.TabIndex = 3;
            this.tbClientPath.Text = global::poexp.Properties.Settings.Default.clientPathSetting;
            // 
            // tbCharacterName
            // 
            this.tbCharacterName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCharacterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCharacterName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::poexp.Properties.Settings.Default, "characterNameSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbCharacterName.Location = new System.Drawing.Point(13, 231);
            this.tbCharacterName.Name = "tbCharacterName";
            this.tbCharacterName.Size = new System.Drawing.Size(280, 20);
            this.tbCharacterName.TabIndex = 2;
            this.tbCharacterName.Text = global::poexp.Properties.Settings.Default.characterNameSetting;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(305, 387);
            this.Controls.Add(this.tbAccountName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbClientPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCharacterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "POEXP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCharacterName;
        private System.Windows.Forms.TextBox tbClientPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

