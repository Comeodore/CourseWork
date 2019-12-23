namespace CourseWork
{
    partial class AddIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredient));
            this.AddIngredientNameBox = new System.Windows.Forms.TextBox();
            this.AddIngredientWeightBox = new System.Windows.Forms.TextBox();
            this.AddIngredientPriceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.ExitButtonAddIngredients = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddIngredientNameBox
            // 
            this.AddIngredientNameBox.Location = new System.Drawing.Point(185, 23);
            this.AddIngredientNameBox.Name = "AddIngredientNameBox";
            this.AddIngredientNameBox.Size = new System.Drawing.Size(100, 20);
            this.AddIngredientNameBox.TabIndex = 0;
            // 
            // AddIngredientWeightBox
            // 
            this.AddIngredientWeightBox.Location = new System.Drawing.Point(185, 47);
            this.AddIngredientWeightBox.Name = "AddIngredientWeightBox";
            this.AddIngredientWeightBox.Size = new System.Drawing.Size(100, 20);
            this.AddIngredientWeightBox.TabIndex = 1;
            // 
            // AddIngredientPriceBox
            // 
            this.AddIngredientPriceBox.Location = new System.Drawing.Point(185, 71);
            this.AddIngredientPriceBox.Name = "AddIngredientPriceBox";
            this.AddIngredientPriceBox.Size = new System.Drawing.Size(100, 20);
            this.AddIngredientPriceBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите вес (гр.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите цену (грн)";
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(90, 97);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(124, 23);
            this.AddIngredientButton.TabIndex = 6;
            this.AddIngredientButton.Text = "Добавить ингридент";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // ExitButtonAddIngredients
            // 
            this.ExitButtonAddIngredients.AutoSize = true;
            this.ExitButtonAddIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonAddIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonAddIngredients.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButtonAddIngredients.Location = new System.Drawing.Point(282, -3);
            this.ExitButtonAddIngredients.Name = "ExitButtonAddIngredients";
            this.ExitButtonAddIngredients.Size = new System.Drawing.Size(27, 25);
            this.ExitButtonAddIngredients.TabIndex = 7;
            this.ExitButtonAddIngredients.Text = "X";
            this.ExitButtonAddIngredients.Click += new System.EventHandler(this.ExitButtonAddIngredients_Click);
            this.ExitButtonAddIngredients.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButtonAddIngredients.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(-2, -5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 25);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "←";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // AddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(304, 132);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButtonAddIngredients);
            this.Controls.Add(this.AddIngredientButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddIngredientPriceBox);
            this.Controls.Add(this.AddIngredientWeightBox);
            this.Controls.Add(this.AddIngredientNameBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIngredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddIngredientNameBox;
        private System.Windows.Forms.TextBox AddIngredientWeightBox;
        private System.Windows.Forms.TextBox AddIngredientPriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.Label ExitButtonAddIngredients;
        private System.Windows.Forms.Label BackButton;
    }
}