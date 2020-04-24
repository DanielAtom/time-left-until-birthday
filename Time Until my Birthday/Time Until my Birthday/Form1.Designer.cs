namespace Time_Until_my_Birthday
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.utilsDragControl1 = new Utils.Framework.UtilsDragControl();
            this.seconds = new Utils.Framework.utilsLabel();
            this.utilsLabel2 = new Utils.Framework.utilsLabel();
            this.minutes = new Utils.Framework.utilsLabel();
            this.utilsLabel1 = new Utils.Framework.utilsLabel();
            this.utilsLabel3 = new Utils.Framework.utilsLabel();
            this.hours = new Utils.Framework.utilsLabel();
            this.utilsLabel4 = new Utils.Framework.utilsLabel();
            this.days = new Utils.Framework.utilsLabel();
            this.utilsLabel5 = new Utils.Framework.utilsLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.utilsLabel6 = new Utils.Framework.utilsLabel();
            this.miliseconds = new Utils.Framework.utilsLabel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // utilsDragControl1
            // 
            this.utilsDragControl1.DragControl = this;
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.seconds, BunifuAnimatorNS.DecorationType.None);
            this.seconds.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.ForeColor = System.Drawing.Color.White;
            this.seconds.Location = new System.Drawing.Point(556, 174);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(56, 55);
            this.seconds.TabIndex = 0;
            this.seconds.Text = "0";
            // 
            // utilsLabel2
            // 
            this.utilsLabel2.AutoSize = true;
            this.utilsLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.utilsLabel2, BunifuAnimatorNS.DecorationType.None);
            this.utilsLabel2.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsLabel2.ForeColor = System.Drawing.Color.White;
            this.utilsLabel2.Location = new System.Drawing.Point(480, 174);
            this.utilsLabel2.Name = "utilsLabel2";
            this.utilsLabel2.Size = new System.Drawing.Size(39, 55);
            this.utilsLabel2.TabIndex = 1;
            this.utilsLabel2.Text = ":";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.minutes, BunifuAnimatorNS.DecorationType.None);
            this.minutes.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.ForeColor = System.Drawing.Color.White;
            this.minutes.Location = new System.Drawing.Point(391, 174);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(56, 55);
            this.minutes.TabIndex = 2;
            this.minutes.Text = "0";
            // 
            // utilsLabel1
            // 
            this.utilsLabel1.AutoSize = true;
            this.utilsLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.utilsLabel1, BunifuAnimatorNS.DecorationType.None);
            this.utilsLabel1.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsLabel1.ForeColor = System.Drawing.Color.White;
            this.utilsLabel1.Location = new System.Drawing.Point(320, 174);
            this.utilsLabel1.Name = "utilsLabel1";
            this.utilsLabel1.Size = new System.Drawing.Size(39, 55);
            this.utilsLabel1.TabIndex = 3;
            this.utilsLabel1.Text = ":";
            // 
            // utilsLabel3
            // 
            this.utilsLabel3.AutoSize = true;
            this.utilsLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.utilsLabel3, BunifuAnimatorNS.DecorationType.None);
            this.utilsLabel3.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsLabel3.ForeColor = System.Drawing.Color.White;
            this.utilsLabel3.Location = new System.Drawing.Point(294, 174);
            this.utilsLabel3.Name = "utilsLabel3";
            this.utilsLabel3.Size = new System.Drawing.Size(0, 55);
            this.utilsLabel3.TabIndex = 4;
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.hours, BunifuAnimatorNS.DecorationType.None);
            this.hours.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.ForeColor = System.Drawing.Color.White;
            this.hours.Location = new System.Drawing.Point(206, 174);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(56, 55);
            this.hours.TabIndex = 5;
            this.hours.Text = "0";
            // 
            // utilsLabel4
            // 
            this.utilsLabel4.AutoSize = true;
            this.utilsLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.utilsLabel4, BunifuAnimatorNS.DecorationType.None);
            this.utilsLabel4.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsLabel4.ForeColor = System.Drawing.Color.White;
            this.utilsLabel4.Location = new System.Drawing.Point(126, 174);
            this.utilsLabel4.Name = "utilsLabel4";
            this.utilsLabel4.Size = new System.Drawing.Size(39, 55);
            this.utilsLabel4.TabIndex = 6;
            this.utilsLabel4.Text = ":";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.days, BunifuAnimatorNS.DecorationType.None);
            this.days.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.ForeColor = System.Drawing.Color.White;
            this.days.Location = new System.Drawing.Point(12, 174);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(56, 55);
            this.days.TabIndex = 7;
            this.days.Text = "0";
            // 
            // utilsLabel5
            // 
            this.utilsLabel5.AutoSize = true;
            this.utilsLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.utilsLabel5, BunifuAnimatorNS.DecorationType.None);
            this.utilsLabel5.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsLabel5.ForeColor = System.Drawing.Color.White;
            this.utilsLabel5.Location = new System.Drawing.Point(111, 39);
            this.utilsLabel5.Name = "utilsLabel5";
            this.utilsLabel5.Size = new System.Drawing.Size(611, 55);
            this.utilsLabel5.TabIndex = 8;
            this.utilsLabel5.Text = "Days until my birthday";
            // 
            // pictureBox4
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::Time_Until_my_Birthday.Properties.Resources.icons8_Gift_48px;
            this.pictureBox4.Location = new System.Drawing.Point(566, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::Time_Until_my_Birthday.Properties.Resources.icons8_Birthday_48px;
            this.pictureBox3.Location = new System.Drawing.Point(103, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Time_Until_my_Birthday.Properties.Resources.icons8_Calendar_48px;
            this.pictureBox2.Location = new System.Drawing.Point(755, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Time_Until_my_Birthday.Properties.Resources.icons8_Calendar_48px;
            this.pictureBox1.Location = new System.Drawing.Point(10, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // utilsLabel6
            // 
            this.utilsLabel6.AutoSize = true;
            this.utilsLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.utilsLabel6, BunifuAnimatorNS.DecorationType.None);
            this.utilsLabel6.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsLabel6.ForeColor = System.Drawing.Color.White;
            this.utilsLabel6.Location = new System.Drawing.Point(648, 174);
            this.utilsLabel6.Name = "utilsLabel6";
            this.utilsLabel6.Size = new System.Drawing.Size(39, 55);
            this.utilsLabel6.TabIndex = 13;
            this.utilsLabel6.Text = ":";
            // 
            // miliseconds
            // 
            this.miliseconds.AutoSize = true;
            this.miliseconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.bunifuTransition1.SetDecoration(this.miliseconds, BunifuAnimatorNS.DecorationType.None);
            this.miliseconds.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miliseconds.ForeColor = System.Drawing.Color.White;
            this.miliseconds.Location = new System.Drawing.Point(703, 174);
            this.miliseconds.Name = "miliseconds";
            this.miliseconds.Size = new System.Drawing.Size(56, 55);
            this.miliseconds.TabIndex = 14;
            this.miliseconds.Text = "0";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.miliseconds);
            this.Controls.Add(this.utilsLabel6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.utilsLabel5);
            this.Controls.Add(this.days);
            this.Controls.Add(this.utilsLabel4);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.utilsLabel3);
            this.Controls.Add(this.utilsLabel1);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.utilsLabel2);
            this.Controls.Add(this.seconds);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.Framework.UtilsDragControl utilsDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Utils.Framework.utilsLabel utilsLabel5;
        private Utils.Framework.utilsLabel days;
        private Utils.Framework.utilsLabel utilsLabel4;
        private Utils.Framework.utilsLabel hours;
        private Utils.Framework.utilsLabel utilsLabel3;
        private Utils.Framework.utilsLabel utilsLabel1;
        private Utils.Framework.utilsLabel minutes;
        private Utils.Framework.utilsLabel utilsLabel2;
        private Utils.Framework.utilsLabel seconds;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private Utils.Framework.utilsLabel miliseconds;
        private Utils.Framework.utilsLabel utilsLabel6;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}

