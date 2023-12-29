namespace oyun
{
    partial class wwww
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wwww));
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.flapybird = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flapybird)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-53, 454);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1043, 126);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom.Image")));
            this.pipebottom.Location = new System.Drawing.Point(248, 298);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(108, 160);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = ((System.Drawing.Image)(resources.GetObject("pipetop.Image")));
            this.pipetop.Location = new System.Drawing.Point(485, -43);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 200);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 2;
            this.pipetop.TabStop = false;
            // 
            // flapybird
            // 
            this.flapybird.Image = ((System.Drawing.Image)(resources.GetObject("flapybird.Image")));
            this.flapybird.Location = new System.Drawing.Point(40, 187);
            this.flapybird.Name = "flapybird";
            this.flapybird.Size = new System.Drawing.Size(100, 57);
            this.flapybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flapybird.TabIndex = 3;
            this.flapybird.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score: 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // wwww
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(979, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flapybird);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.ground);
            this.Name = "wwww";
            this.Text = " Farbly oyun";
            this.Load += new System.EventHandler(this.wwww_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyidown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyap);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flapybird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox flapybird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gametimer;
    }
}

