namespace CourseWork
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonShowMenu = new System.Windows.Forms.Button();
            this.ButtonLoginAdm = new System.Windows.Forms.Button();
            this.ExitButtonMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здраствуйте, выберите пункт";
            // 
            // ButtonShowMenu
            // 
            this.ButtonShowMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowMenu.Location = new System.Drawing.Point(135, 58);
            this.ButtonShowMenu.Name = "ButtonShowMenu";
            this.ButtonShowMenu.Size = new System.Drawing.Size(199, 23);
            this.ButtonShowMenu.TabIndex = 1;
            this.ButtonShowMenu.Text = "Просмотреть меню ресторана";
            this.ButtonShowMenu.UseVisualStyleBackColor = true;
            this.ButtonShowMenu.Click += new System.EventHandler(this.ButtonShowMenu_Click);
            // 
            // ButtonLoginAdm
            // 
            this.ButtonLoginAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLoginAdm.Location = new System.Drawing.Point(135, 87);
            this.ButtonLoginAdm.Name = "ButtonLoginAdm";
            this.ButtonLoginAdm.Size = new System.Drawing.Size(199, 23);
            this.ButtonLoginAdm.TabIndex = 3;
            this.ButtonLoginAdm.Text = "Войти, как администратор";
            this.ButtonLoginAdm.UseVisualStyleBackColor = true;
            this.ButtonLoginAdm.Click += new System.EventHandler(this.ButtonLoginAdm_Click);
            // 
            // ExitButtonMain
            // 
            this.ExitButtonMain.AutoSize = true;
            this.ExitButtonMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonMain.ForeColor = System.Drawing.Color.White;
            this.ExitButtonMain.Location = new System.Drawing.Point(460, -3);
            this.ExitButtonMain.Name = "ExitButtonMain";
            this.ExitButtonMain.Size = new System.Drawing.Size(27, 25);
            this.ExitButtonMain.TabIndex = 4;
            this.ExitButtonMain.Text = "X";
            this.ExitButtonMain.Click += new System.EventHandler(this.ExitButtonMain_Click);
            this.ExitButtonMain.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButtonMain.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(482, 128);
            this.Controls.Add(this.ExitButtonMain);
            this.Controls.Add(this.ButtonLoginAdm);
            this.Controls.Add(this.ButtonShowMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonShowMenu;
        private System.Windows.Forms.Button ButtonLoginAdm;
        private System.Windows.Forms.Label ExitButtonMain;
    }
}