namespace Квалификационная_работа
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.lblMenu = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.Normal = new System.Windows.Forms.Label();
            this.WithRegistration = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Image = ((System.Drawing.Image)(resources.GetObject("lblMenu.Image")));
            this.lblMenu.Location = new System.Drawing.Point(18, -1);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(100, 65);
            this.lblMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblMenu.TabIndex = 10;
            this.lblMenu.TabStop = false;
            this.toolTip1.SetToolTip(this.lblMenu, "Перейти до головного меню");
            this.lblMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            this.lblMenu.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.lblMenu.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.Color.Transparent;
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(464, 22);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(562, 459);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 11;
            this.picture1.TabStop = false;
            // 
            // Normal
            // 
            this.Normal.BackColor = System.Drawing.Color.Transparent;
            this.Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Normal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Normal.Location = new System.Drawing.Point(59, 183);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(263, 42);
            this.Normal.TabIndex = 12;
            this.Normal.Text = "Звичайний";
            this.Normal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            this.Normal.MouseEnter += new System.EventHandler(this.Normal_MouseEnter);
            this.Normal.MouseLeave += new System.EventHandler(this.Normal_MouseLeave);
            // 
            // WithRegistration
            // 
            this.WithRegistration.BackColor = System.Drawing.Color.Transparent;
            this.WithRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WithRegistration.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WithRegistration.Location = new System.Drawing.Point(59, 278);
            this.WithRegistration.Name = "WithRegistration";
            this.WithRegistration.Size = new System.Drawing.Size(263, 48);
            this.WithRegistration.TabIndex = 13;
            this.WithRegistration.Text = "З реєстрацією";
            this.WithRegistration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WithRegistration.Click += new System.EventHandler(this.WithRegistration_Click);
            this.WithRegistration.MouseEnter += new System.EventHandler(this.WithRegistration_MouseEnter);
            this.WithRegistration.MouseLeave += new System.EventHandler(this.WithRegistration_MouseLeave);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(12, 472);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(1014, 112);
            this.Info.TabIndex = 14;
            this.Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1038, 615);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.WithRegistration);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оберіть необхідний для вас режим проходження тестів.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTest_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.lblMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lblMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label Normal;
        private System.Windows.Forms.Label WithRegistration;
        private System.Windows.Forms.Label Info;
    }
}