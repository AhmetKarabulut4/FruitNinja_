namespace FruitNinja
{
    partial class Form2
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
            this.cilek = new System.Windows.Forms.PictureBox();
            this.nar = new System.Windows.Forms.PictureBox();
            this.domates = new System.Windows.Forms.PictureBox();
            this.bomba = new System.Windows.Forms.PictureBox();
            this.cilek1 = new System.Windows.Forms.Timer(this.components);
            this.cilek2 = new System.Windows.Forms.Timer(this.components);
            this.cilek3 = new System.Windows.Forms.Timer(this.components);
            this.nar1 = new System.Windows.Forms.Timer(this.components);
            this.nar2 = new System.Windows.Forms.Timer(this.components);
            this.nar3 = new System.Windows.Forms.Timer(this.components);
            this.domates1 = new System.Windows.Forms.Timer(this.components);
            this.domates2 = new System.Windows.Forms.Timer(this.components);
            this.domates3 = new System.Windows.Forms.Timer(this.components);
            this.bomba1 = new System.Windows.Forms.Timer(this.components);
            this.bomba2 = new System.Windows.Forms.Timer(this.components);
            this.bomba3 = new System.Windows.Forms.Timer(this.components);
            this.gerisayim = new System.Windows.Forms.Timer(this.components);
            this.PuanLabel = new System.Windows.Forms.Label();
            this.ZamanLabel = new System.Windows.Forms.Label();
            this.deneme = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.bomb1 = new System.Windows.Forms.Timer(this.components);
            this.bomb2 = new System.Windows.Forms.Timer(this.components);
            this.bomb3 = new System.Windows.Forms.Timer(this.components);
            this.baslangıc = new System.Windows.Forms.Timer(this.components);
            this.basLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cilek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            this.SuspendLayout();
            // 
            // cilek
            // 
            this.cilek.BackColor = System.Drawing.Color.Transparent;
            this.cilek.Image = global::FruitNinja.Properties.Resources.Strawberry_icon;
            this.cilek.Location = new System.Drawing.Point(254, 446);
            this.cilek.Name = "cilek";
            this.cilek.Size = new System.Drawing.Size(58, 38);
            this.cilek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cilek.TabIndex = 0;
            this.cilek.TabStop = false;
            this.cilek.Visible = false;
            this.cilek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cilek_MouseMove);
            // 
            // nar
            // 
            this.nar.BackColor = System.Drawing.Color.Transparent;
            this.nar.Image = global::FruitNinja.Properties.Resources.Pomegranate;
            this.nar.Location = new System.Drawing.Point(318, 446);
            this.nar.Name = "nar";
            this.nar.Size = new System.Drawing.Size(58, 38);
            this.nar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nar.TabIndex = 1;
            this.nar.TabStop = false;
            this.nar.Visible = false;
            this.nar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nar_MouseMove);
            // 
            // domates
            // 
            this.domates.BackColor = System.Drawing.Color.Transparent;
            this.domates.Image = global::FruitNinja.Properties.Resources.Tomato;
            this.domates.Location = new System.Drawing.Point(389, 446);
            this.domates.Name = "domates";
            this.domates.Size = new System.Drawing.Size(58, 38);
            this.domates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.domates.TabIndex = 2;
            this.domates.TabStop = false;
            this.domates.Visible = false;
            this.domates.MouseMove += new System.Windows.Forms.MouseEventHandler(this.domates_MouseMove);
            // 
            // bomba
            // 
            this.bomba.BackColor = System.Drawing.Color.Transparent;
            this.bomba.Image = global::FruitNinja.Properties.Resources.Bomb1;
            this.bomba.Location = new System.Drawing.Point(453, 446);
            this.bomba.Name = "bomba";
            this.bomba.Size = new System.Drawing.Size(58, 38);
            this.bomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomba.TabIndex = 3;
            this.bomba.TabStop = false;
            this.bomba.Visible = false;
            this.bomba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bomba_MouseMove);
            // 
            // cilek1
            // 
            this.cilek1.Interval = 3000;
            this.cilek1.Tick += new System.EventHandler(this.cilek1_Tick);
            // 
            // cilek2
            // 
            this.cilek2.Tick += new System.EventHandler(this.cilek2_Tick);
            // 
            // cilek3
            // 
            this.cilek3.Tick += new System.EventHandler(this.cilek3_Tick);
            // 
            // nar1
            // 
            this.nar1.Interval = 3000;
            this.nar1.Tick += new System.EventHandler(this.nar1_Tick);
            // 
            // nar2
            // 
            this.nar2.Tick += new System.EventHandler(this.nar2_Tick);
            // 
            // nar3
            // 
            this.nar3.Tick += new System.EventHandler(this.nar3_Tick);
            // 
            // domates1
            // 
            this.domates1.Interval = 3000;
            this.domates1.Tick += new System.EventHandler(this.domates1_Tick);
            // 
            // domates2
            // 
            this.domates2.Tick += new System.EventHandler(this.domates2_Tick);
            // 
            // domates3
            // 
            this.domates3.Tick += new System.EventHandler(this.domates3_Tick);
            // 
            // bomba1
            // 
            this.bomba1.Interval = 3000;
            this.bomba1.Tick += new System.EventHandler(this.bomba1_Tick);
            // 
            // bomba2
            // 
            this.bomba2.Tick += new System.EventHandler(this.bomba2_Tick);
            // 
            // bomba3
            // 
            this.bomba3.Tick += new System.EventHandler(this.bomba3_Tick);
            // 
            // gerisayim
            // 
            this.gerisayim.Interval = 1000;
            this.gerisayim.Tick += new System.EventHandler(this.gerisayim_Tick);
            // 
            // PuanLabel
            // 
            this.PuanLabel.AutoSize = true;
            this.PuanLabel.BackColor = System.Drawing.Color.Transparent;
            this.PuanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PuanLabel.ForeColor = System.Drawing.Color.Gold;
            this.PuanLabel.Location = new System.Drawing.Point(98, 31);
            this.PuanLabel.Name = "PuanLabel";
            this.PuanLabel.Size = new System.Drawing.Size(0, 25);
            this.PuanLabel.TabIndex = 4;
            // 
            // ZamanLabel
            // 
            this.ZamanLabel.AutoSize = true;
            this.ZamanLabel.BackColor = System.Drawing.Color.Transparent;
            this.ZamanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZamanLabel.ForeColor = System.Drawing.Color.Gold;
            this.ZamanLabel.Location = new System.Drawing.Point(696, 31);
            this.ZamanLabel.Name = "ZamanLabel";
            this.ZamanLabel.Size = new System.Drawing.Size(0, 25);
            this.ZamanLabel.TabIndex = 5;
            // 
            // deneme
            // 
            this.deneme.Interval = 1;
            this.deneme.Tick += new System.EventHandler(this.deneme_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FruitNinja.Properties.Resources.ZOmqOZ;
            this.pictureBox1.Location = new System.Drawing.Point(27, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.Image = global::FruitNinja.Properties.Resources._10_Bomb;
            this.bomb.Location = new System.Drawing.Point(190, 446);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(58, 38);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb.TabIndex = 7;
            this.bomb.TabStop = false;
            this.bomb.Visible = false;
            this.bomb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bomb_MouseMove);
            // 
            // bomb1
            // 
            this.bomb1.Interval = 3000;
            this.bomb1.Tick += new System.EventHandler(this.bomb1_Tick);
            // 
            // bomb2
            // 
            this.bomb2.Tick += new System.EventHandler(this.bomb2_Tick);
            // 
            // bomb3
            // 
            this.bomb3.Tick += new System.EventHandler(this.bomb3_Tick);
            // 
            // baslangıc
            // 
            this.baslangıc.Interval = 1000;
            this.baslangıc.Tick += new System.EventHandler(this.baslangıc_Tick);
            // 
            // basLabel
            // 
            this.basLabel.AutoSize = true;
            this.basLabel.BackColor = System.Drawing.Color.Transparent;
            this.basLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basLabel.ForeColor = System.Drawing.Color.Gold;
            this.basLabel.Location = new System.Drawing.Point(375, 230);
            this.basLabel.Name = "basLabel";
            this.basLabel.Size = new System.Drawing.Size(37, 39);
            this.basLabel.TabIndex = 8;
            this.basLabel.Text = "3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FruitNinja.Properties.Resources.Wiki_background_800x500;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.basLabel);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.PuanLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ZamanLabel);
            this.Controls.Add(this.bomba);
            this.Controls.Add(this.domates);
            this.Controls.Add(this.nar);
            this.Controls.Add(this.cilek);
            this.Name = "Form2";
            this.Text = "Fruit Ninja";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cilek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cilek;
        private System.Windows.Forms.PictureBox nar;
        private System.Windows.Forms.PictureBox domates;
        private System.Windows.Forms.PictureBox bomba;
        private System.Windows.Forms.Timer cilek1;
        private System.Windows.Forms.Timer cilek2;
        private System.Windows.Forms.Timer cilek3;
        private System.Windows.Forms.Timer nar1;
        private System.Windows.Forms.Timer nar2;
        private System.Windows.Forms.Timer nar3;
        private System.Windows.Forms.Timer domates1;
        private System.Windows.Forms.Timer domates2;
        private System.Windows.Forms.Timer domates3;
        private System.Windows.Forms.Timer bomba1;
        private System.Windows.Forms.Timer bomba2;
        private System.Windows.Forms.Timer bomba3;
        private System.Windows.Forms.Timer gerisayim;
        private System.Windows.Forms.Label PuanLabel;
        private System.Windows.Forms.Label ZamanLabel;
        private System.Windows.Forms.Timer deneme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Timer bomb1;
        private System.Windows.Forms.Timer bomb2;
        private System.Windows.Forms.Timer bomb3;
        private System.Windows.Forms.Timer baslangıc;
        private System.Windows.Forms.Label basLabel;
    }
}