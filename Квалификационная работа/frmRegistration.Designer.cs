namespace Квалификационная_работа
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPochta = new System.Windows.Forms.TextBox();
            this.lPochta = new System.Windows.Forms.Label();
            this.lSave = new System.Windows.Forms.Label();
            this.lNext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.BackColor = System.Drawing.Color.Transparent;
            this.lName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(12, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(67, 32);
            this.lName.TabIndex = 13;
            this.lName.Text = "Ім\'я";
            this.lName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(12, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 37);
            this.txtName.TabIndex = 14;
            // 
            // lSurname
            // 
            this.lSurname.BackColor = System.Drawing.Color.Transparent;
            this.lSurname.Cursor = System.Windows.Forms.Cursors.Default;
            this.lSurname.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSurname.Location = new System.Drawing.Point(12, 86);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(111, 32);
            this.lSurname.TabIndex = 15;
            this.lSurname.Text = "Прізвище";
            this.lSurname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.Location = new System.Drawing.Point(12, 122);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(214, 37);
            this.txtSurname.TabIndex = 16;
            // 
            // txtPochta
            // 
            this.txtPochta.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPochta.Location = new System.Drawing.Point(12, 199);
            this.txtPochta.Name = "txtPochta";
            this.txtPochta.Size = new System.Drawing.Size(214, 37);
            this.txtPochta.TabIndex = 17;
            // 
            // lPochta
            // 
            this.lPochta.BackColor = System.Drawing.Color.Transparent;
            this.lPochta.Cursor = System.Windows.Forms.Cursors.Default;
            this.lPochta.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPochta.Location = new System.Drawing.Point(12, 163);
            this.lPochta.Name = "lPochta";
            this.lPochta.Size = new System.Drawing.Size(87, 32);
            this.lPochta.TabIndex = 18;
            this.lPochta.Text = "Пошта";
            this.lPochta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lSave
            // 
            this.lSave.BackColor = System.Drawing.Color.Transparent;
            this.lSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lSave.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSave.Location = new System.Drawing.Point(232, 45);
            this.lSave.Name = "lSave";
            this.lSave.Size = new System.Drawing.Size(153, 73);
            this.lSave.TabIndex = 19;
            this.lSave.Text = "Зберегти дані";
            this.lSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lSave.Click += new System.EventHandler(this.lSave_Click);
            this.lSave.MouseEnter += new System.EventHandler(this.lSave_MouseEnter);
            this.lSave.MouseLeave += new System.EventHandler(this.lSave_MouseLeave);
            // 
            // lNext
            // 
            this.lNext.BackColor = System.Drawing.Color.Transparent;
            this.lNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lNext.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNext.Location = new System.Drawing.Point(232, 153);
            this.lNext.Name = "lNext";
            this.lNext.Size = new System.Drawing.Size(153, 70);
            this.lNext.TabIndex = 20;
            this.lNext.Text = "Розпочати тестування";
            this.lNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lNext.Click += new System.EventHandler(this.lNext_Click);
            this.lNext.MouseEnter += new System.EventHandler(this.lNext_MouseEnter);
            this.lNext.MouseLeave += new System.EventHandler(this.lNext_MouseLeave);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lNext);
            this.Controls.Add(this.lSave);
            this.Controls.Add(this.lPochta);
            this.Controls.Add(this.txtPochta);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введіть ваші дані";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistration_FormClosing);
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPochta;
        private System.Windows.Forms.Label lPochta;
        private System.Windows.Forms.Label lSave;
        private System.Windows.Forms.Label lNext;
    }
}