namespace deniz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.testbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eslestirmebutton = new System.Windows.Forms.Button();
            this.yerlestirmebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(219, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game of Hardware";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // testbutton
            // 
            this.testbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.testbutton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.testbutton.Location = new System.Drawing.Point(40, 247);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(256, 56);
            this.testbutton.TabIndex = 1;
            this.testbutton.Text = "TEST";
            this.testbutton.UseVisualStyleBackColor = false;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(115, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Donanım Parçalarını Öğrenmeye Hazır Mısın?";
            // 
            // eslestirmebutton
            // 
            this.eslestirmebutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eslestirmebutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eslestirmebutton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.eslestirmebutton.Location = new System.Drawing.Point(40, 157);
            this.eslestirmebutton.Name = "eslestirmebutton";
            this.eslestirmebutton.Size = new System.Drawing.Size(256, 56);
            this.eslestirmebutton.TabIndex = 3;
            this.eslestirmebutton.Text = "EŞLEŞTİRME";
            this.eslestirmebutton.UseVisualStyleBackColor = false;
            this.eslestirmebutton.Click += new System.EventHandler(this.eslestirmebutton_Click);
            // 
            // yerlestirmebutton
            // 
            this.yerlestirmebutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yerlestirmebutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.yerlestirmebutton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.yerlestirmebutton.Location = new System.Drawing.Point(40, 334);
            this.yerlestirmebutton.Name = "yerlestirmebutton";
            this.yerlestirmebutton.Size = new System.Drawing.Size(256, 56);
            this.yerlestirmebutton.TabIndex = 4;
            this.yerlestirmebutton.Text = "YERLEŞTİRME";
            this.yerlestirmebutton.UseVisualStyleBackColor = false;
            this.yerlestirmebutton.Click += new System.EventHandler(this.yerlestirmebutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(661, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hazırlayanlar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yerlestirmebutton);
            this.Controls.Add(this.eslestirmebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GameofHardware";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eslestirmebutton;
        private System.Windows.Forms.Button yerlestirmebutton;
        private System.Windows.Forms.Button button1;
    }
}

