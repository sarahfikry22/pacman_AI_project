
namespace Pac_Man_GUI
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
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pac_man = new System.Windows.Forms.PictureBox();
            this.pac_man_beta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pac_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pac_man_beta)).BeginInit();
            this.SuspendLayout();
            // 
            // pinkGhost
            // 
            this.pinkGhost.Image = global::Pac_Man_GUI.Properties.Resources.pink_guy;
            this.pinkGhost.Location = new System.Drawing.Point(251, 101);
            this.pinkGhost.Margin = new System.Windows.Forms.Padding(1);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(35, 51);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 2;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // yellowGhost
            // 
            this.yellowGhost.Image = global::Pac_Man_GUI.Properties.Resources.yellow_guy;
            this.yellowGhost.Location = new System.Drawing.Point(276, 230);
            this.yellowGhost.Margin = new System.Windows.Forms.Padding(1);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(35, 51);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 2;
            this.yellowGhost.TabStop = false;
            this.yellowGhost.Tag = "ghost";
            // 
            // redGhost
            // 
            this.redGhost.Image = global::Pac_Man_GUI.Properties.Resources.red_guy;
            this.redGhost.Location = new System.Drawing.Point(169, 58);
            this.redGhost.Margin = new System.Windows.Forms.Padding(1);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(35, 51);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 2;
            this.redGhost.TabStop = false;
            this.redGhost.Tag = "ghost";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Blue;
            this.pictureBox6.Location = new System.Drawing.Point(310, 306);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 154);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "wall";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Location = new System.Drawing.Point(111, 306);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 154);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.Location = new System.Drawing.Point(310, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 154);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(139, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 154);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox66
            // 
            this.pictureBox66.Image = global::Pac_Man_GUI.Properties.Resources.coin;
            this.pictureBox66.Location = new System.Drawing.Point(204, 341);
            this.pictureBox66.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(22, 25);
            this.pictureBox66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox66.TabIndex = 14;
            this.pictureBox66.TabStop = false;
            this.pictureBox66.Tag = "coin";
            this.pictureBox66.Click += new System.EventHandler(this.pictureBox66_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimer);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(4, 3);
            this.pictureBox22.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(96, 38);
            this.pictureBox22.TabIndex = 18;
            this.pictureBox22.TabStop = false;
            // 
            // pac_man
            // 
            this.pac_man.Image = global::Pac_Man_GUI.Properties.Resources.right;
            this.pac_man.Location = new System.Drawing.Point(52, 132);
            this.pac_man.Margin = new System.Windows.Forms.Padding(1);
            this.pac_man.Name = "pac_man";
            this.pac_man.Size = new System.Drawing.Size(48, 58);
            this.pac_man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pac_man.TabIndex = 3;
            this.pac_man.TabStop = false;
            this.pac_man.Click += new System.EventHandler(this.pac_man_Click);
            // 
            // pac_man_beta
            // 
            this.pac_man_beta.Location = new System.Drawing.Point(21, 62);
            this.pac_man_beta.Margin = new System.Windows.Forms.Padding(1);
            this.pac_man_beta.Name = "pac_man_beta";
            this.pac_man_beta.Size = new System.Drawing.Size(45, 45);
            this.pac_man_beta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pac_man_beta.TabIndex = 5;
            this.pac_man_beta.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(423, 456);
            this.Controls.Add(this.pac_man);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.pictureBox66);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox22);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Pac_Man_Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pac_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pac_man_beta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox redGhost;
        private System.Windows.Forms.PictureBox yellowGhost;
        private System.Windows.Forms.PictureBox pinkGhost;
        private System.Windows.Forms.PictureBox pac_man_beta;
        private System.Windows.Forms.PictureBox pictureBox66;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pac_man;
    }
}

