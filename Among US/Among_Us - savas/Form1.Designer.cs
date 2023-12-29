namespace Among_Us
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
            this.Map_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player1_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.this_player_timer1 = new System.Windows.Forms.Timer(this.components);
            this.server_timer1 = new System.Windows.Forms.Timer(this.components);
            this.player2_pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Map_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Map_pictureBox1
            // 
            this.Map_pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.Map_pictureBox1.Image = global::Among_Us.Properties.Resources.AmongUsMap;
            this.Map_pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.Map_pictureBox1.Name = "Map_pictureBox1";
            this.Map_pictureBox1.Size = new System.Drawing.Size(2100, 1500);
            this.Map_pictureBox1.TabIndex = 0;
            this.Map_pictureBox1.TabStop = false;
            // 
            // player1_pictureBox1
            // 
            this.player1_pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player1_pictureBox1.BackgroundImage")));
            this.player1_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1_pictureBox1.Image = global::Among_Us.Properties.Resources.red_stop;
            this.player1_pictureBox1.Location = new System.Drawing.Point(118, 110);
            this.player1_pictureBox1.Name = "player1_pictureBox1";
            this.player1_pictureBox1.Size = new System.Drawing.Size(67, 75);
            this.player1_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1_pictureBox1.TabIndex = 1;
            this.player1_pictureBox1.TabStop = false;
            // 
            // this_player_timer1
            // 
            this.this_player_timer1.Tick += new System.EventHandler(this.this_player_timer1_Tick);
            // 
            // player2_pictureBox1
            // 
            this.player2_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2_pictureBox1.Location = new System.Drawing.Point(1910, 110);
            this.player2_pictureBox1.Name = "player2_pictureBox1";
            this.player2_pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.player2_pictureBox1.TabIndex = 3;
            this.player2_pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Among_Us.Properties.Resources.uzayla;
            this.ClientSize = new System.Drawing.Size(629, 451);
            this.Controls.Add(this.player2_pictureBox1);
            this.Controls.Add(this.player1_pictureBox1);
            this.Controls.Add(this.Map_pictureBox1);
            this.Name = "Form1";
            this.Text = "Among US";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Map_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Map_pictureBox1;
        private System.Windows.Forms.PictureBox player1_pictureBox1;
        private System.Windows.Forms.Timer this_player_timer1;
        private System.Windows.Forms.Timer server_timer1;
        private System.Windows.Forms.PictureBox player2_pictureBox1;
    }
}

