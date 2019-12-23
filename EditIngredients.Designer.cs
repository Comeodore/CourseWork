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
            this.EditIngredientsTextBoxOld = new System.Windows.Forms.TextBox();
            this.EditIngredientsTextBoxNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButtonEditIngredients = new System.Windows.Forms.Label();
            this.EditIngredientsButtonChangesDone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonWeight = new System.Windows.Forms.RadioButton();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.BackButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditIngredientsTextBoxOld
            // 
            this.EditIngredientsTextBoxOld.Location = new System.Drawing.Point(211, 75);
            this.EditIngredientsTextBoxOld.Name = "EditIngredientsTextBoxOld";
            this.EditIngredientsTextBoxOld.Size = new System.Drawing.Size(100, 20);
            this.EditIngredientsTextBoxOld.TabIndex = 0;
            // 
            // EditIngredientsTextBoxNew
            // 
            this.EditIngredientsTextBoxNew.Location = new System.Drawing.Point(211, 101);
            this.EditIngredientsTextBoxNew.Name = "EditIngredientsTextBoxNew";
            this.EditIngredientsTextBoxNew.Size = new System.Drawing.Size(100, 20);
            this.EditIngredientsTextBoxNew.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите старое значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите новое значение";
            // 
            // ExitButtonEditIngredients
            // 
            this.ExitButtonEditIngredients.AutoSize = true;
            this.ExitButtonEditIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonEditIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonEditIngredients.ForeColor = System.Drawing.Color.White;
            this.ExitButtonEditIngredients.Location = new System.Drawing.Point(304, -3);
            this.ExitButtonEditIngredients.Name = "ExitButtonEditIngredients";
            this.ExitButtonEditIngredients.Size = new System.Drawing.Size(27, 25);
            this.ExitButtonEditIngredients.TabIndex = 11;
            this.ExitButtonEditIngredients.Text = "X";
            this.ExitButtonEditIngredients.Click += new System.EventHandler(this.ExitButtonEditIngredientsHelp_Click);
            this.ExitButtonEditIngredients.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButtonEditIngredients.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // EditIngredientsButtonChangesDone
            // 
            this.EditIngredientsButtonChangesDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditIngredientsButtonChangesDone.Location = new System.Drawing.Point(104, 136);
            this.EditIngredientsButtonChangesDone.Name = "EditIngredientsButtonChangesDone";
            this.EditIngredientsButtonChangesDone.Size = new System.Drawing.Size(113, 23);
            this.EditIngredientsButtonChangesDone.TabIndex = 12;
            this.EditIngredientsButtonChangesDone.Text = "Внести изменения";
            this.EditIngredientsButtonChangesDone.UseVisualStyleBackColor = true;
            this.EditIngredientsButtonChangesDone.Click += new System.EventHandler(this.EditIngredientsButtonChangesDone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Укажите что хотите изменить";
            this.label3.UseWaitCursor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonName.Location = new System.Drawing.Point(62, 48);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(75, 17);
            this.radioButtonName.TabIndex = 18;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Название";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeight
            // 
            this.radioButtonWeight.AutoSize = true;
            this.radioButtonWeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonWeight.Location = new System.Drawing.Point(151, 48);
            this.radioButtonWeight.Name = "radioButtonWeight";
            this.radioButtonWeight.Size = new System.Drawing.Size(44, 17);
            this.radioButtonWeight.TabIndex = 19;
            this.radioButtonWeight.TabStop = true;
            this.radioButtonWeight.Text = "Вес";
            this.radioButtonWeight.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonPrice.Location = new System.Drawing.Point(201, 48);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(50, 17);
            this.radioButtonPrice.TabIndex = 20;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "Цену";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(-1, -6);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 25);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "←";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // EditIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(325, 170);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.radioButtonPrice);
            this.Controls.Add(this.radioButtonWeight);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditIngredientsButtonChangesDone);
            this.Controls.Add(this.ExitButtonEditIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditIngredientsTextBoxNew);
            this.Controls.Add(this.EditIngredientsTextBoxOld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditIngredientsHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditIngredientsTextBoxOld;
        private System.Windows.Forms.TextBox EditIngredientsTextBoxNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ExitButtonEditIngredients;
        private System.Windows.Forms.Button EditIngredientsButtonChangesDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonWeight;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.Label BackButton;
    }
}