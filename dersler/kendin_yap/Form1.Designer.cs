namespace kendin_yap
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.txtyazdir = new System.Windows.Forms.TextBox();
            this.btnkontrol = new System.Windows.Forms.Button();
            this.lbliste1 = new System.Windows.Forms.ListBox();
            this.lbliste2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Silver;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb1.Location = new System.Drawing.Point(23, 22);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(82, 17);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "Seçenek1";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Silver;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb2.Location = new System.Drawing.Point(23, 58);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(82, 17);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "Seçenek2";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // txtyazdir
            // 
            this.txtyazdir.BackColor = System.Drawing.Color.Silver;
            this.txtyazdir.Location = new System.Drawing.Point(23, 108);
            this.txtyazdir.Name = "txtyazdir";
            this.txtyazdir.Size = new System.Drawing.Size(85, 20);
            this.txtyazdir.TabIndex = 1;
            // 
            // btnkontrol
            // 
            this.btnkontrol.BackColor = System.Drawing.Color.Silver;
            this.btnkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkontrol.Location = new System.Drawing.Point(23, 159);
            this.btnkontrol.Name = "btnkontrol";
            this.btnkontrol.Size = new System.Drawing.Size(85, 34);
            this.btnkontrol.TabIndex = 2;
            this.btnkontrol.Text = "Kontrol";
            this.btnkontrol.UseVisualStyleBackColor = false;
            this.btnkontrol.Click += new System.EventHandler(this.btnkontrol_Click);
            // 
            // lbliste1
            // 
            this.lbliste1.BackColor = System.Drawing.Color.Silver;
            this.lbliste1.FormattingEnabled = true;
            this.lbliste1.Location = new System.Drawing.Point(150, 22);
            this.lbliste1.Name = "lbliste1";
            this.lbliste1.Size = new System.Drawing.Size(120, 160);
            this.lbliste1.TabIndex = 3;
            // 
            // lbliste2
            // 
            this.lbliste2.BackColor = System.Drawing.Color.Silver;
            this.lbliste2.FormattingEnabled = true;
            this.lbliste2.Location = new System.Drawing.Point(307, 22);
            this.lbliste2.Name = "lbliste2";
            this.lbliste2.Size = new System.Drawing.Size(120, 160);
            this.lbliste2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(467, 255);
            this.Controls.Add(this.lbliste2);
            this.Controls.Add(this.lbliste1);
            this.Controls.Add(this.btnkontrol);
            this.Controls.Add(this.txtyazdir);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.TextBox txtyazdir;
        private System.Windows.Forms.Button btnkontrol;
        private System.Windows.Forms.ListBox lbliste1;
        private System.Windows.Forms.ListBox lbliste2;
    }
}

