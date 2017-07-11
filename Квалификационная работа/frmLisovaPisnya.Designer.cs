namespace Квалификационная_работа
{
    partial class frmLisovaPisnya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLisovaPisnya));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Istoria = new System.Windows.Forms.Label();
            this.Suzhet = new System.Windows.Forms.Label();
            this.Analiz = new System.Windows.Forms.Label();
            this.Texttvoru = new System.Windows.Forms.Label();
            this.Igra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Перейти до головного меню");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(281, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(745, 591);
            this.webBrowser1.TabIndex = 11;
            // 
            // Istoria
            // 
            this.Istoria.BackColor = System.Drawing.Color.Transparent;
            this.Istoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Istoria.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Istoria.Location = new System.Drawing.Point(12, 129);
            this.Istoria.Name = "Istoria";
            this.Istoria.Size = new System.Drawing.Size(263, 34);
            this.Istoria.TabIndex = 12;
            this.Istoria.Text = "Історія створення";
            this.Istoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Istoria.Click += new System.EventHandler(this.label2_Click);
            this.Istoria.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.Istoria.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // Suzhet
            // 
            this.Suzhet.BackColor = System.Drawing.Color.Transparent;
            this.Suzhet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suzhet.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Suzhet.Location = new System.Drawing.Point(12, 195);
            this.Suzhet.Name = "Suzhet";
            this.Suzhet.Size = new System.Drawing.Size(263, 34);
            this.Suzhet.TabIndex = 13;
            this.Suzhet.Text = "Сюжет";
            this.Suzhet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Suzhet.Click += new System.EventHandler(this.label1_Click);
            this.Suzhet.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.Suzhet.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Analiz
            // 
            this.Analiz.BackColor = System.Drawing.Color.Transparent;
            this.Analiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Analiz.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Analiz.Location = new System.Drawing.Point(12, 261);
            this.Analiz.Name = "Analiz";
            this.Analiz.Size = new System.Drawing.Size(263, 34);
            this.Analiz.TabIndex = 14;
            this.Analiz.Text = "Аналіз твору";
            this.Analiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Analiz.Click += new System.EventHandler(this.label3_Click);
            this.Analiz.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.Analiz.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // Texttvoru
            // 
            this.Texttvoru.BackColor = System.Drawing.Color.Transparent;
            this.Texttvoru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Texttvoru.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Texttvoru.Location = new System.Drawing.Point(12, 327);
            this.Texttvoru.Name = "Texttvoru";
            this.Texttvoru.Size = new System.Drawing.Size(263, 79);
            this.Texttvoru.TabIndex = 15;
            this.Texttvoru.Text = "Перейти до тексту твору";
            this.Texttvoru.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Texttvoru.Click += new System.EventHandler(this.label4_Click);
            this.Texttvoru.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.Texttvoru.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // Igra
            // 
            this.Igra.BackColor = System.Drawing.Color.Transparent;
            this.Igra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Igra.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Igra.Location = new System.Drawing.Point(12, 438);
            this.Igra.Name = "Igra";
            this.Igra.Size = new System.Drawing.Size(263, 34);
            this.Igra.TabIndex = 16;
            this.Igra.Text = "П\'ятнашки";
            this.Igra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Igra.Click += new System.EventHandler(this.Igra_Click);
            this.Igra.MouseEnter += new System.EventHandler(this.Igra_MouseEnter);
            this.Igra.MouseLeave += new System.EventHandler(this.Igra_MouseLeave);
            // 
            // frmLisovaPisnya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1038, 615);
            this.Controls.Add(this.Igra);
            this.Controls.Add(this.Texttvoru);
            this.Controls.Add(this.Analiz);
            this.Controls.Add(this.Suzhet);
            this.Controls.Add(this.Istoria);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLisovaPisnya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Лісова пісня\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLisovaPisnya_FormClosed);
            this.Load += new System.EventHandler(this.frmLisovaPisnya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label Istoria;
        private System.Windows.Forms.Label Suzhet;
        private System.Windows.Forms.Label Analiz;
        private System.Windows.Forms.Label Texttvoru;
        private System.Windows.Forms.Label Igra;
    }
}