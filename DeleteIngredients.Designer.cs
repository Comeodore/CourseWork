namespace CourseWork
{
    partial class DeleteIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteIngredients));
            this.ExitButtonDeleteIngredients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteIngredientsBox = new System.Windows.Forms.TextBox();
            this.DeleteIngredientsButton = new System.Windows.Forms.Button();
            this.ButtonReturnToPanelDeleteIngredients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButtonDeleteIngredients
            // 
            this.ExitButtonDeleteIngredients.AutoSize = true;
            this.ExitButtonDeleteIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonDeleteIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonDeleteIngredients.ForeColor = System.Drawing.Color.White;
            this.ExitButtonDeleteIngredients.Location = new System.Drawing.Point(304, -3);
            this.ExitButtonDeleteIngredients.Name = "ExitButtonDeleteIngredients";
            this.ExitButtonDeleteIngredients.Size = new System.Drawing.Size(27, 25);
            this.ExitButtonDeleteIngredients.TabIndex = 11;
            this.ExitButtonDeleteIngredients.Text = "X";
            this.ExitButtonDeleteIngredients.Click += new System.EventHandler(this.ExitButtonDeleteIngredients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите название ингридиента, \r\nкоторый хотите удалить";
            // 
            // DeleteIngredientsBox
            // 
            this.DeleteIngredientsBox.Location = new System.Drawing.Point(16, 53);
            this.DeleteIngredientsBox.Name = "DeleteIngredientsBox";
            this.DeleteIngredientsBox.Size = new System.Drawing.Size(288, 20);
            this.DeleteIngredientsBox.TabIndex = 13;
            // 
            // DeleteIngredientsButton
            // 
            this.DeleteIngredientsButton.Location = new System.Drawing.Point(87, 79);
            this.DeleteIngredientsButton.Name = "DeleteIngredientsButton";
            this.DeleteIngredientsButton.Size = new System.Drawing.Size(158, 23);
            this.DeleteIngredientsButton.TabIndex = 14;
            this.DeleteIngredientsButton.Text = "Удалить ингридиент";
            this.DeleteIngredientsButton.UseVisualStyleBackColor = true;
            this.DeleteIngredientsButton.Click += new System.EventHandler(this.DeleteIngredientsButton_Click);
            // 
            // ButtonReturnToPanelDeleteIngredients
            // 
            this.ButtonReturnToPanelDeleteIngredients.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReturnToPanelDeleteIngredients.Location = new System.Drawing.Point(61, 108);
            this.ButtonReturnToPanelDeleteIngredients.Name = "ButtonReturnToPanelDeleteIngredients";
            this.ButtonReturnToPanelDeleteIngredients.Size = new System.Drawing.Size(207, 23);
            this.ButtonReturnToPanelDeleteIngredients.TabIndex = 15;
            this.ButtonReturnToPanelDeleteIngredients.Text = "Вернуться в панель администратора";
            this.ButtonReturnToPanelDeleteIngredients.UseVisualStyleBackColor = true;
            this.ButtonReturnToPanelDeleteIngredients.Click += new System.EventHandler(this.ButtonReturnToPanelDeleteIngredients_Click);
            // 
            // DeleteIngredients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(327, 143);
            this.Controls.Add(this.ButtonReturnToPanelDeleteIngredients);
            this.Controls.Add(this.DeleteIngredientsButton);
            this.Controls.Add(this.DeleteIngredientsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButtonDeleteIngredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteIngredients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitButtonDeleteIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteIngredientsBox;
        private System.Windows.Forms.Button DeleteIngredientsButton;
        private System.Windows.Forms.Button ButtonReturnToPanelDeleteIngredients;
    }
}