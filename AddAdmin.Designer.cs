namespace CourseWork
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginAddAdminBox = new System.Windows.Forms.TextBox();
            this.PasswordAddAdminBox = new System.Windows.Forms.TextBox();
            this.ButtonRegisterAddAdmin = new System.Windows.Forms.Button();
            this.ExitButtonAddAdmin = new System.Windows.Forms.Label();
            this.ButtonReturnToPanelAddAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление администратора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(97, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(84, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // LoginAddAdminBox
            // 
            this.LoginAddAdminBox.Location = new System.Drawing.Point(191, 69);
            this.LoginAddAdminBox.Name = "LoginAddAdminBox";
            this.LoginAddAdminBox.Size = new System.Drawing.Size(100, 20);
            this.LoginAddAdminBox.TabIndex = 3;
            // 
            // PasswordAddAdminBox
            // 
            this.PasswordAddAdminBox.Location = new System.Drawing.Point(191, 108);
            this.PasswordAddAdminBox.Name = "PasswordAddAdminBox";
            this.PasswordAddAdminBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordAddAdminBox.TabIndex = 4;
            // 
            // ButtonRegisterAddAdmin
            // 
            this.ButtonRegisterAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegisterAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegisterAddAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonRegisterAddAdmin.Location = new System.Drawing.Point(120, 143);
            this.ButtonRegisterAddAdmin.Name = "ButtonRegisterAddAdmin";
            this.ButtonRegisterAddAdmin.Size = new System.Drawing.Size(153, 23);
            this.ButtonRegisterAddAdmin.TabIndex = 5;
            this.ButtonRegisterAddAdmin.Text = "Добавить администратора";
            this.ButtonRegisterAddAdmin.UseVisualStyleBackColor = true;
            this.ButtonRegisterAddAdmin.Click += new System.EventHandler(this.ButtonRegisterAddAdmin_Click);
            // 
            // ExitButtonAddAdmin
            // 
            this.ExitButtonAddAdmin.AutoSize = true;
            this.ExitButtonAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonAddAdmin.ForeColor = System.Drawing.Color.White;
            this.ExitButtonAddAdmin.Location = new System.Drawing.Point(366, -2);
            this.ExitButtonAddAdmin.Name = "ExitButtonAddAdmin";
            this.ExitButtonAddAdmin.Size = new System.Drawing.Size(27, 25);
            this.ExitButtonAddAdmin.TabIndex = 10;
            this.ExitButtonAddAdmin.Text = "X";
            this.ExitButtonAddAdmin.Click += new System.EventHandler(this.ExitButtonAddAdmin_Click);
            // 
            // ButtonReturnToPanelAddAdmin
            // 
            this.ButtonReturnToPanelAddAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReturnToPanelAddAdmin.Location = new System.Drawing.Point(92, 175);
            this.ButtonReturnToPanelAddAdmin.Name = "ButtonReturnToPanelAddAdmin";
            this.ButtonReturnToPanelAddAdmin.Size = new System.Drawing.Size(207, 23);
            this.ButtonReturnToPanelAddAdmin.TabIndex = 11;
            this.ButtonReturnToPanelAddAdmin.Text = "Вернуться в панель администратора";
            this.ButtonReturnToPanelAddAdmin.UseVisualStyleBackColor = true;
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(388, 218);
            this.Controls.Add(this.ButtonReturnToPanelAddAdmin);
            this.Controls.Add(this.ExitButtonAddAdmin);
            this.Controls.Add(this.ButtonRegisterAddAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordAddAdminBox);
            this.Controls.Add(this.LoginAddAdminBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginAddAdminBox;
        private System.Windows.Forms.TextBox PasswordAddAdminBox;
        private System.Windows.Forms.Button ButtonRegisterAddAdmin;
        private System.Windows.Forms.Label ExitButtonAddAdmin;
        private System.Windows.Forms.Button ButtonReturnToPanelAddAdmin;
    }
}