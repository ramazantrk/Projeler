namespace oyun2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yol = new System.Windows.Forms.PictureBox();
            this.maryo = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.engel1 = new System.Windows.Forms.PictureBox();
            this.engel2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maryo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel2)).BeginInit();
            this.SuspendLayout();
            // 
            // yol
            // 
            this.yol.Image = ((System.Drawing.Image)(resources.GetObject("yol.Image")));
            this.yol.Location = new System.Drawing.Point(2, 301);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(672, 83);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            // 
            // maryo
            // 
            this.maryo.Image = ((System.Drawing.Image)(resources.GetObject("maryo.Image")));
            this.maryo.Location = new System.Drawing.Point(16, 232);
            this.maryo.Name = "maryo";
            this.maryo.Size = new System.Drawing.Size(61, 72);
            this.maryo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maryo.TabIndex = 1;
            this.maryo.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // engel1
            // 
            this.engel1.Image = ((System.Drawing.Image)(resources.GetObject("engel1.Image")));
            this.engel1.Location = new System.Drawing.Point(220, 13);
            this.engel1.Name = "engel1";
            this.engel1.Size = new System.Drawing.Size(63, 87);
            this.engel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engel1.TabIndex = 2;
            this.engel1.TabStop = false;
            // 
            // engel2
            // 
            this.engel2.Image = ((System.Drawing.Image)(resources.GetObject("engel2.Image")));
            this.engel2.Location = new System.Drawing.Point(481, -5);
            this.engel2.Name = "engel2";
            this.engel2.Size = new System.Drawing.Size(63, 105);
            this.engel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engel2.TabIndex = 3;
            this.engel2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.engel2);
            this.Controls.Add(this.engel1);
            this.Controls.Add(this.maryo);
            this.Controls.Add(this.yol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyidown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maryo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.PictureBox maryo;
        private System.Windows.Forms.PictureBox engel1;
        private System.Windows.Forms.PictureBox engel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gametimer;
    }
}

