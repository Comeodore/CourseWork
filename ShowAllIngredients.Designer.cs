namespace CourseWork
{
    partial class ShowAllIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllIngredients));
            this.dataGridViewIngredients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnPanelShowAllIngredients = new System.Windows.Forms.Button();
            this.ExitButtonShowAllIngredients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIngredients
            // 
            this.dataGridViewIngredients.AllowUserToAddRows = false;
            this.dataGridViewIngredients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dataGridViewIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewIngredients.Location = new System.Drawing.Point(-42, -2);
            this.dataGridViewIngredients.Name = "dataGridViewIngredients";
            this.dataGridViewIngredients.Size = new System.Drawing.Size(343, 396);
            this.dataGridViewIngredients.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название ингридиента";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Вес ингридиента";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена ингридиента";
            this.Column3.Name = "Column3";
            // 
            // ReturnPanelShowAllIngredients
            // 
            this.ReturnPanelShowAllIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnPanelShowAllIngredients.Location = new System.Drawing.Point(41, 337);
            this.ReturnPanelShowAllIngredients.Name = "ReturnPanelShowAllIngredients";
            this.ReturnPanelShowAllIngredients.Size = new System.Drawing.Size(213, 23);
            this.ReturnPanelShowAllIngredients.TabIndex = 17;
            this.ReturnPanelShowAllIngredients.Text = "Вернуться в панель администратора";
            this.ReturnPanelShowAllIngredients.UseVisualStyleBackColor = true;
            this.ReturnPanelShowAllIngredients.Click += new System.EventHandler(this.ReturnPanelShowAllIngredients_Click);
            // 
            // ExitButtonShowAllIngredients
            // 
            this.ExitButtonShowAllIngredients.AutoSize = true;
            this.ExitButtonShowAllIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ExitButtonShowAllIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonShowAllIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonShowAllIngredients.ForeColor = System.Drawing.Color.White;
            this.ExitButtonShowAllIngredients.Location = new System.Drawing.Point(278, 338);
            this.ExitButtonShowAllIngredients.Name = "ExitButtonShowAllIngredients";
            this.ExitButtonShowAllIngredients.Size = new System.Drawing.Size(27, 25);
            this.ExitButtonShowAllIngredients.TabIndex = 18;
            this.ExitButtonShowAllIngredients.Text = "X";
            this.ExitButtonShowAllIngredients.Click += new System.EventHandler(this.ExitButtonShowAllIngredients_Click);
            // 
            // ShowAllIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(298, 359);
            this.Controls.Add(this.ExitButtonShowAllIngredients);
            this.Controls.Add(this.ReturnPanelShowAllIngredients);
            this.Controls.Add(this.dataGridViewIngredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowAllIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAllIngredients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button ReturnPanelShowAllIngredients;
        private System.Windows.Forms.Label ExitButtonShowAllIngredients;
    }
}