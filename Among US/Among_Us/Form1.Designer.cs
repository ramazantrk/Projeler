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
            this.connetction_panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player2_connection_label1 = new System.Windows.Forms.Label();
            this.player1_connection_label1 = new System.Windows.Forms.Label();
            this.ready_label1 = new System.Windows.Forms.Label();
            this.connection_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.server_timer1 = new System.Windows.Forms.Timer(this.components);
            this.player2_pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Map_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_pictureBox1)).BeginInit();
            this.connetction_panel1.SuspendLayout();
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
            this.player1_pictureBox1.Location = new System.Drawing.Point(110, 110);
            this.player1_pictureBox1.Name = "player1_pictureBox1";
            this.player1_pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.player1_pictureBox1.TabIndex = 1;
            this.player1_pictureBox1.TabStop = false;
            // 
            // this_player_timer1
            // 
            this.this_player_timer1.Tick += new System.EventHandler(this.this_player_timer1_Tick);
            // 
            // connetction_panel1
            // 
            this.connetction_panel1.BackColor = System.Drawing.Color.Transparent;
            this.connetction_panel1.BackgroundImage = global::Among_Us.Properties.Resources.uzayla;
            this.connetction_panel1.Controls.Add(this.label3);
            this.connetction_panel1.Controls.Add(this.label2);
            this.connetction_panel1.Controls.Add(this.player2_connection_label1);
            this.connetction_panel1.Controls.Add(this.player1_connection_label1);
            this.connetction_panel1.Controls.Add(this.ready_label1);
            this.connetction_panel1.Controls.Add(this.connection_label1);
            this.connetction_panel1.Controls.Add(this.label1);
            this.connetction_panel1.Location = new System.Drawing.Point(191, 175);
            this.connetction_panel1.Name = "connetction_panel1";
            this.connetction_panel1.Size = new System.Drawing.Size(630, 450);
            this.connetction_panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player1";
            // 
            // player2_connection_label1
            // 
            this.player2_connection_label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player2_connection_label1.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.player2_connection_label1.ForeColor = System.Drawing.Color.DarkGray;
            this.player2_connection_label1.Location = new System.Drawing.Point(127, 287);
            this.player2_connection_label1.Name = "player2_connection_label1";
            this.player2_connection_label1.Size = new System.Drawing.Size(40, 30);
            this.player2_connection_label1.TabIndex = 4;
            this.player2_connection_label1.Text = "n";
            this.player2_connection_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_connection_label1
            // 
            this.player1_connection_label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player1_connection_label1.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.player1_connection_label1.ForeColor = System.Drawing.Color.DarkGray;
            this.player1_connection_label1.Location = new System.Drawing.Point(127, 230);
            this.player1_connection_label1.Name = "player1_connection_label1";
            this.player1_connection_label1.Size = new System.Drawing.Size(40, 30);
            this.player1_connection_label1.TabIndex = 3;
            this.player1_connection_label1.Text = "n";
            this.player1_connection_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ready_label1
            // 
            this.ready_label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ready_label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready_label1.ForeColor = System.Drawing.Color.White;
            this.ready_label1.Location = new System.Drawing.Point(127, 385);
            this.ready_label1.Name = "ready_label1";
            this.ready_label1.Size = new System.Drawing.Size(365, 39);
            this.ready_label1.TabIndex = 2;
            this.ready_label1.Text = "Hazırım";
            this.ready_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // connection_label1
            // 
            this.connection_label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connection_label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_label1.ForeColor = System.Drawing.Color.White;
            this.connection_label1.Location = new System.Drawing.Point(127, 166);
            this.connection_label1.Name = "connection_label1";
            this.connection_label1.Size = new System.Drawing.Size(365, 39);
            this.connection_label1.TabIndex = 1;
            this.connection_label1.Text = "Baglan";
            this.connection_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connection_label1.Click += new System.EventHandler(this.connection_label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMONG US";
            // 
            // server_timer1
            // 
            this.server_timer1.Tick += new System.EventHandler(this.server_timer1_Tick);
            // 
            // player2_pictureBox1
            // 
            this.player2_pictureBox1.BackgroundImage = global::Among_Us.Properties.Resources.blue_stop;
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
            this.Controls.Add(this.connetction_panel1);
            this.Controls.Add(this.player1_pictureBox1);
            this.Controls.Add(this.Map_pictureBox1);
            this.Name = "Form1";
            this.Text = "Among US";
          
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Map_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_pictureBox1)).EndInit();
            this.connetction_panel1.ResumeLayout(false);
            this.connetction_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Map_pictureBox1;
        private System.Windows.Forms.PictureBox player1_pictureBox1;
        private System.Windows.Forms.Timer this_player_timer1;
        private System.Windows.Forms.Panel connetction_panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player2_connection_label1;
        private System.Windows.Forms.Label player1_connection_label1;
        private System.Windows.Forms.Label ready_label1;
        private System.Windows.Forms.Label connection_label1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer server_timer1;
        private System.Windows.Forms.PictureBox player2_pictureBox1;
    }
}

