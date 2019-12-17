namespace CourseWork
{
    partial class EditIngredientsHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIngredientsHelp));
            this.EditIngredientsTextBoxOld = new System.Windows.Forms.TextBox();
            this.EditIngredientsTextBoxNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButtonEditIngredientsHelp = new System.Windows.Forms.Label();
            this.EditIngredientsButtonChangesDone = new System.Windows.Forms.Button();
            this.ReturnPanelEditIngredients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditIngredientsTextBoxOld
            // 
            this.EditIngredientsTextBoxOld.Location = new System.Drawing.Point(211, 30);
            this.EditIngredientsTextBoxOld.Name = "EditIngredientsTextBoxOld";
            this.EditIngredientsTextBoxOld.Size = new System.Drawing.Size(100, 20);
            this.EditIngredientsTextBoxOld.TabIndex = 0;
            // 
            // EditIngredientsTextBoxNew
            // 
            this.EditIngredientsTextBoxNew.Location = new System.Drawing.Point(211, 56);
            this.EditIngredientsTextBoxNew.Name = "EditIngredientsTextBoxNew";
            this.EditIngredientsTextBoxNew.Size = new System.Drawing.Size(100, 20);
            this.EditIngredientsTextBoxNew.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 32);
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
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите новое значение";
            // 
            // ExitButtonEditIngredientsHelp
            // 
            this.ExitButtonEditIngredientsHelp.AutoSize = true;
            this.ExitButtonEditIngredientsHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonEditIngredientsHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonEditIngredientsHelp.ForeColor = System.Drawing.Color.White;
            this.ExitButtonEditIngredientsHelp.Location = new System.Drawing.Point(304, -3);
            this.ExitButtonEditIngredientsHelp.Name = "ExitButtonEditIngredientsHelp";
            this.ExitButtonEditIngredientsHelp.Size = new System.Drawing.Size(27, 25);
            this.ExitButtonEditIngredientsHelp.TabIndex = 11;
            this.ExitButtonEditIngredientsHelp.Text = "X";
            this.ExitButtonEditIngredientsHelp.Click += new System.EventHandler(this.ExitButtonEditIngredientsHelp_Click);
            // 
            // EditIngredientsButtonChangesDone
            // 
            this.EditIngredientsButtonChangesDone.Location = new System.Drawing.Point(104, 91);
            this.EditIngredientsButtonChangesDone.Name = "EditIngredientsButtonChangesDone";
            this.EditIngredientsButtonChangesDone.Size = new System.Drawing.Size(113, 23);
            this.EditIngredientsButtonChangesDone.TabIndex = 12;
            this.EditIngredientsButtonChangesDone.Text = "Внести изменения";
            this.EditIngredientsButtonChangesDone.UseVisualStyleBackColor = true;
            this.EditIngredientsButtonChangesDone.Click += new System.EventHandler(this.EditIngredientsButtonChangesDone_Click);
            // 
            // ReturnPanelEditIngredients
            // 
            this.ReturnPanelEditIngredients.Location = new System.Drawing.Point(58, 120);
            this.ReturnPanelEditIngredients.Name = "ReturnPanelEditIngredients";
            this.ReturnPanelEditIngredients.Size = new System.Drawing.Size(213, 23);
            this.ReturnPanelEditIngredients.TabIndex = 16;
            this.ReturnPanelEditIngredients.Text = "Вернуться в панель администратора";
            this.ReturnPanelEditIngredients.UseVisualStyleBackColor = true;
            this.ReturnPanelEditIngredients.Click += new System.EventHandler(this.ReturnPanelEditIngredients_Click);
            // 
            // EditIngredientsHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(325, 159);
            this.Controls.Add(this.ReturnPanelEditIngredients);
            this.Controls.Add(this.EditIngredientsButtonChangesDone);
            this.Controls.Add(this.ExitButtonEditIngredientsHelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditIngredientsTextBoxNew);
            this.Controls.Add(this.EditIngredientsTextBoxOld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditIngredientsHelp";
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
        private System.Windows.Forms.Label ExitButtonEditIngredientsHelp;
        private System.Windows.Forms.Button EditIngredientsButtonChangesDone;
        private System.Windows.Forms.Button ReturnPanelEditIngredients;
    }
}