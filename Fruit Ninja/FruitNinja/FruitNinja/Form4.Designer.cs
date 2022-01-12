namespace FruitNinja
{
    partial class Form4
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
            this.cilek1 = new System.Windows.Forms.Timer(this.components);
            this.cilek2 = new System.Windows.Forms.Timer(this.components);
            this.cilek3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nar = new System.Windows.Forms.PictureBox();
            this.nar1 = new System.Windows.Forms.Timer(this.components);
            this.nar2 = new System.Windows.Forms.Timer(this.components);
            this.nar3 = new System.Windows.Forms.Timer(this.components);
            this.domates1 = new System.Windows.Forms.Timer(this.components);
            this.domates2 = new System.Windows.Forms.Timer(this.components);
            this.domates3 = new System.Windows.Forms.Timer(this.components);
            this.domates = new System.Windows.Forms.PictureBox();
            this.bomba1 = new System.Windows.Forms.Timer(this.components);
            this.bomba2 = new System.Windows.Forms.Timer(this.components);
            this.bomba3 = new System.Windows.Forms.Timer(this.components);
            this.bomba = new System.Windows.Forms.PictureBox();
            this.gerisayım = new System.Windows.Forms.Timer(this.components);
            this.ZamanLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.baslangıc = new System.Windows.Forms.Timer(this.components);
            this.basLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cilek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cilek
            // 
            this.cilek.BackColor = System.Drawing.Color.Transparent;
            this.cilek.Image = global::FruitNinja.Properties.Resources.Strawberry_icon;
            this.cilek.Location = new System.Drawing.Point(234, 446);
            this.cilek.Name = "cilek";
            this.cilek.Size = new System.Drawing.Size(58, 38);
            this.cilek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cilek.TabIndex = 0;
            this.cilek.TabStop = false;
            this.cilek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cilek_MouseMove);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(269, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Devam Etmek İçin Tıkla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nar
            // 
            this.nar.BackColor = System.Drawing.Color.Transparent;
            this.nar.Image = global::FruitNinja.Properties.Resources.Pomegranate;
            this.nar.Location = new System.Drawing.Point(316, 446);
            this.nar.Name = "nar";
            this.nar.Size = new System.Drawing.Size(58, 38);
            this.nar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nar.TabIndex = 3;
            this.nar.TabStop = false;
            this.nar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nar_MouseMove);
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
            // domates
            // 
            this.domates.BackColor = System.Drawing.Color.Transparent;
            this.domates.Image = global::FruitNinja.Properties.Resources.Strawberry_icon1;
            this.domates.Location = new System.Drawing.Point(391, 446);
            this.domates.Name = "domates";
            this.domates.Size = new System.Drawing.Size(58, 38);
            this.domates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.domates.TabIndex = 4;
            this.domates.TabStop = false;
            this.domates.MouseMove += new System.Windows.Forms.MouseEventHandler(this.domates_MouseMove);
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
            // bomba
            // 
            this.bomba.BackColor = System.Drawing.Color.Transparent;
            this.bomba.Image = global::FruitNinja.Properties.Resources.Bomb1;
            this.bomba.Location = new System.Drawing.Point(455, 446);
            this.bomba.Name = "bomba";
            this.bomba.Size = new System.Drawing.Size(58, 38);
            this.bomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomba.TabIndex = 5;
            this.bomba.TabStop = false;
            this.bomba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bomba_MouseMove);
            // 
            // gerisayım
            // 
            this.gerisayım.Interval = 1000;
            this.gerisayım.Tick += new System.EventHandler(this.gerisayım_Tick);
            // 
            // ZamanLabel
            // 
            this.ZamanLabel.AutoSize = true;
            this.ZamanLabel.BackColor = System.Drawing.Color.Transparent;
            this.ZamanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZamanLabel.ForeColor = System.Drawing.Color.Gold;
            this.ZamanLabel.Location = new System.Drawing.Point(696, 9);
            this.ZamanLabel.Name = "ZamanLabel";
            this.ZamanLabel.Size = new System.Drawing.Size(0, 25);
            this.ZamanLabel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FruitNinja.Properties.Resources.LbP8BV;
            this.pictureBox1.Location = new System.Drawing.Point(-260, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.basLabel.Location = new System.Drawing.Point(384, 217);
            this.basLabel.Name = "basLabel";
            this.basLabel.Size = new System.Drawing.Size(37, 39);
            this.basLabel.TabIndex = 9;
            this.basLabel.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(271, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Süreniz 30 Saniyedir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(258, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Puan yoktur, antreman modudur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(271, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FruitNinja.Properties.Resources.Wiki_background;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.basLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZamanLabel);
            this.Controls.Add(this.bomba);
            this.Controls.Add(this.domates);
            this.Controls.Add(this.nar);
            this.Controls.Add(this.cilek);
            this.Name = "Form4";
            this.Text = "3";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cilek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cilek;
        private System.Windows.Forms.Timer cilek1;
        private System.Windows.Forms.Timer cilek2;
        private System.Windows.Forms.Timer cilek3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nar;
        private System.Windows.Forms.Timer nar1;
        private System.Windows.Forms.Timer nar2;
        private System.Windows.Forms.Timer nar3;
        private System.Windows.Forms.Timer domates1;
        private System.Windows.Forms.Timer domates2;
        private System.Windows.Forms.Timer domates3;
        private System.Windows.Forms.PictureBox domates;
        private System.Windows.Forms.Timer bomba1;
        private System.Windows.Forms.Timer bomba2;
        private System.Windows.Forms.Timer bomba3;
        private System.Windows.Forms.PictureBox bomba;
        private System.Windows.Forms.Timer gerisayım;
        private System.Windows.Forms.Label ZamanLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer baslangıc;
        private System.Windows.Forms.Label basLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}