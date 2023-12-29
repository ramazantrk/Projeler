namespace NTP2
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
            this.lbliste = new System.Windows.Forms.ListBox();
            this.txtara = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteriler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Adı:";
            // 
            // lbliste
            // 
            this.lbliste.FormattingEnabled = true;
            this.lbliste.Items.AddRange(new object[] {
            "Doruk",
            "Elif",
            "Derya",
            "Zeliha",
            "Muhammet Ali",
            "Halil",
            "Lütfi",
            "Mustafa",
            "Muzaffer",
            "Mehmet",
            "Furkan"});
            this.lbliste.Location = new System.Drawing.Point(116, 9);
            this.lbliste.Name = "lbliste";
            this.lbliste.Size = new System.Drawing.Size(120, 160);
            this.lbliste.TabIndex = 1;
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(116, 175);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(120, 20);
            this.txtara.TabIndex = 2;
            // 
            // btnara
            // 
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.Location = new System.Drawing.Point(116, 211);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(120, 36);
            this.btnara.TabIndex = 3;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.lbliste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbliste;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button btnara;
    }
}

