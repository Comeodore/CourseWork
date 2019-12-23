namespace CourseWork
{
    partial class DeleteAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAdmin));
            this.BackButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeleteAdmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(-2, -1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 25);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "←";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(284, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(27, 25);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 112);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите логин администратора, профиль которого хотите удалить";
            // 
            // textBoxDeleteAdmin
            // 
            this.textBoxDeleteAdmin.Location = new System.Drawing.Point(60, 135);
            this.textBoxDeleteAdmin.Name = "textBoxDeleteAdmin";
            this.textBoxDeleteAdmin.Size = new System.Drawing.Size(181, 20);
            this.textBoxDeleteAdmin.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Удалить администратора";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(308, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDeleteAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeleteAdmin;
        private System.Windows.Forms.Button button1;
    }
}