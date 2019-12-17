namespace CourseWork
{
    partial class EditIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIngredients));
            this.ExitButtonEditIngredients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonChoseEditIngredientsName = new System.Windows.Forms.Button();
            this.ButtonChoseEditIngredientsWeight = new System.Windows.Forms.Button();
            this.ButtonChoseEditIngredientsPrice = new System.Windows.Forms.Button();
            this.ReturnPanelEditIngredients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButtonEditIngredients
            // 
            this.ExitButtonEditIngredients.AutoSize = true;
            this.ExitButtonEditIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonEditIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonEditIngredients.ForeColor = System.Drawing.Color.White;
            this.ExitButtonEditIngredients.Location = new System.Drawing.Point(317, -3);
            this.ExitButtonEditIngredients.Name = "ExitButtonEditIngredients";
            this.ExitButtonEditIngredients.Size = new System.Drawing.Size(27, 25);
            this.ExitButtonEditIngredients.TabIndex = 10;
            this.ExitButtonEditIngredients.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Укажите что хотите изменить";
            this.label1.UseWaitCursor = true;
            // 
            // ButtonChoseEditIngredientsName
            // 
            this.ButtonChoseEditIngredientsName.Location = new System.Drawing.Point(34, 41);
            this.ButtonChoseEditIngredientsName.Name = "ButtonChoseEditIngredientsName";
            this.ButtonChoseEditIngredientsName.Size = new System.Drawing.Size(75, 23);
            this.ButtonChoseEditIngredientsName.TabIndex = 12;
            this.ButtonChoseEditIngredientsName.Text = "Название";
            this.ButtonChoseEditIngredientsName.UseVisualStyleBackColor = true;
            this.ButtonChoseEditIngredientsName.Click += new System.EventHandler(this.ButtonChoseEditIngredientsName_Click);
            // 
            // ButtonChoseEditIngredientsWeight
            // 
            this.ButtonChoseEditIngredientsWeight.Location = new System.Drawing.Point(131, 41);
            this.ButtonChoseEditIngredientsWeight.Name = "ButtonChoseEditIngredientsWeight";
            this.ButtonChoseEditIngredientsWeight.Size = new System.Drawing.Size(75, 23);
            this.ButtonChoseEditIngredientsWeight.TabIndex = 13;
            this.ButtonChoseEditIngredientsWeight.Text = "Вес";
            this.ButtonChoseEditIngredientsWeight.UseVisualStyleBackColor = true;
            this.ButtonChoseEditIngredientsWeight.Click += new System.EventHandler(this.ButtonChoseEditIngredientsWeight_Click);
            // 
            // ButtonChoseEditIngredientsPrice
            // 
            this.ButtonChoseEditIngredientsPrice.Location = new System.Drawing.Point(225, 41);
            this.ButtonChoseEditIngredientsPrice.Name = "ButtonChoseEditIngredientsPrice";
            this.ButtonChoseEditIngredientsPrice.Size = new System.Drawing.Size(75, 23);
            this.ButtonChoseEditIngredientsPrice.TabIndex = 14;
            this.ButtonChoseEditIngredientsPrice.Text = "Цену";
            this.ButtonChoseEditIngredientsPrice.UseVisualStyleBackColor = true;
            this.ButtonChoseEditIngredientsPrice.Click += new System.EventHandler(this.ButtonChoseEditIngredientsPrice_Click);
            // 
            // ReturnPanelEditIngredients
            // 
            this.ReturnPanelEditIngredients.Location = new System.Drawing.Point(59, 71);
            this.ReturnPanelEditIngredients.Name = "ReturnPanelEditIngredients";
            this.ReturnPanelEditIngredients.Size = new System.Drawing.Size(213, 23);
            this.ReturnPanelEditIngredients.TabIndex = 15;
            this.ReturnPanelEditIngredients.Text = "Вернуться в панель администратора";
            this.ReturnPanelEditIngredients.UseVisualStyleBackColor = true;
            this.ReturnPanelEditIngredients.Click += new System.EventHandler(this.ReturnPanelEditIngredients_Click);
            // 
            // EditIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(339, 113);
            this.Controls.Add(this.ReturnPanelEditIngredients);
            this.Controls.Add(this.ButtonChoseEditIngredientsPrice);
            this.Controls.Add(this.ButtonChoseEditIngredientsWeight);
            this.Controls.Add(this.ButtonChoseEditIngredientsName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButtonEditIngredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditIngredients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitButtonEditIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonChoseEditIngredientsName;
        private System.Windows.Forms.Button ButtonChoseEditIngredientsWeight;
        private System.Windows.Forms.Button ButtonChoseEditIngredientsPrice;
        private System.Windows.Forms.Button ReturnPanelEditIngredients;
    }
}