namespace CourseWork
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BackButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.dataGridViewIngredients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(-1, 345);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 25);
            this.BackButton.TabIndex = 25;
            this.BackButton.Text = "←";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(521, 347);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(27, 25);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // dataGridViewIngredients
            // 
            this.dataGridViewIngredients.AllowUserToAddRows = false;
            this.dataGridViewIngredients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dataGridViewIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dataGridViewIngredients.Location = new System.Drawing.Point(-42, -1);
            this.dataGridViewIngredients.Name = "dataGridViewIngredients";
            this.dataGridViewIngredients.Size = new System.Drawing.Size(592, 396);
            this.dataGridViewIngredients.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название блюда";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ингридиенты блюда";
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Вес блюда (гр)";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена блюда (грн)";
            this.Column3.Name = "Column3";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(543, 371);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dataGridViewIngredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.DataGridView dataGridViewIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}