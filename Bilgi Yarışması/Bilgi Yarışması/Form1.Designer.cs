namespace Bilgi_Yarışması
{
    partial class f1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f1));
            this.r1 = new System.Windows.Forms.RichTextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // r1
            // 
            this.r1.Location = new System.Drawing.Point(6, 12);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(412, 228);
            this.r1.TabIndex = 0;
            this.r1.Text = "";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(480, 33);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(60, 13);
            this.l1.TabIndex = 1;
            this.l1.Text = "SORU NO:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(480, 74);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(50, 13);
            this.l2.TabIndex = 2;
            this.l2.Text = "DOĞRU:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(480, 118);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(48, 13);
            this.l3.TabIndex = 3;
            this.l3.Text = "YANLIŞ:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(551, 33);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(13, 13);
            this.l4.TabIndex = 6;
            this.l4.Text = "0";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(551, 74);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(13, 13);
            this.l5.TabIndex = 5;
            this.l5.Text = "0";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(551, 118);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(13, 13);
            this.l6.TabIndex = 4;
            this.l6.Text = "0";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(29, 255);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(158, 43);
            this.b1.TabIndex = 7;
            this.b1.Text = "A";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(234, 255);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(158, 43);
            this.b2.TabIndex = 8;
            this.b2.Text = "B";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(29, 304);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(158, 43);
            this.b3.TabIndex = 10;
            this.b3.Text = "C";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(234, 304);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(158, 43);
            this.b4.TabIndex = 9;
            this.b4.Text = "D";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(483, 161);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(158, 43);
            this.b5.TabIndex = 11;
            this.b5.Text = "SONRAKİ";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(443, 253);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 94);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 12;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            // 
            // p2
            // 
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(570, 253);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 94);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 13;
            this.p2.TabStop = false;
            this.p2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // f1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(682, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.r1);
            this.Name = "f1";
            this.Text = "BİLGİ YARIŞI";
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox r1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

