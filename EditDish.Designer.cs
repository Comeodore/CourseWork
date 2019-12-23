namespace CourseWork
{
    partial class EditDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDish));
            this.BackButton = new System.Windows.Forms.Label();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.radioButtonWeight = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.buttonChangesDone = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.radioButtonIngr = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(0, -1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 25);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "←";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonPrice.Location = new System.Drawing.Point(255, 53);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(50, 17);
            this.radioButtonPrice.TabIndex = 31;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "Цену";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeight
            // 
            this.radioButtonWeight.AutoSize = true;
            this.radioButtonWeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonWeight.Location = new System.Drawing.Point(198, 53);
            this.radioButtonWeight.Name = "radioButtonWeight";
            this.radioButtonWeight.Size = new System.Drawing.Size(44, 17);
            this.radioButtonWeight.TabIndex = 30;
            this.radioButtonWeight.TabStop = true;
            this.radioButtonWeight.Text = "Вес";
            this.radioButtonWeight.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonName.Location = new System.Drawing.Point(25, 53);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(75, 17);
            this.radioButtonName.TabIndex = 29;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Название";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // buttonChangesDone
            // 
            this.buttonChangesDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangesDone.Location = new System.Drawing.Point(105, 141);
            this.buttonChangesDone.Name = "buttonChangesDone";
            this.buttonChangesDone.Size = new System.Drawing.Size(113, 23);
            this.buttonChangesDone.TabIndex = 27;
            this.buttonChangesDone.Text = "Внести изменения";
            this.buttonChangesDone.UseVisualStyleBackColor = true;
            this.buttonChangesDone.Click += new System.EventHandler(this.buttonChangesDone_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(305, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(27, 25);
            this.ExitButton.TabIndex = 26;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите новое значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Введите старое значение";
            // 
            // textBoxNew
            // 
            this.textBoxNew.Location = new System.Drawing.Point(212, 106);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(100, 20);
            this.textBoxNew.TabIndex = 23;
            // 
            // textBoxOld
            // 
            this.textBoxOld.Location = new System.Drawing.Point(212, 80);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.Size = new System.Drawing.Size(100, 20);
            this.textBoxOld.TabIndex = 22;
            // 
            // radioButtonIngr
            // 
            this.radioButtonIngr.AutoSize = true;
            this.radioButtonIngr.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonIngr.Location = new System.Drawing.Point(102, 53);
            this.radioButtonIngr.Name = "radioButtonIngr";
            this.radioButtonIngr.Size = new System.Drawing.Size(93, 17);
            this.radioButtonIngr.TabIndex = 33;
            this.radioButtonIngr.TabStop = true;
            this.radioButtonIngr.Text = "Ингридиенты";
            this.radioButtonIngr.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 53);
            this.label3.TabIndex = 34;
            this.label3.Text = "Укажите что хотите изменить";
            // 
            // EditDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(328, 176);
            this.Controls.Add(this.radioButtonIngr);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.radioButtonPrice);
            this.Controls.Add(this.radioButtonWeight);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.buttonChangesDone);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNew);
            this.Controls.Add(this.textBoxOld);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.RadioButton radioButtonWeight;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.Button buttonChangesDone;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNew;
        private System.Windows.Forms.TextBox textBoxOld;
        private System.Windows.Forms.RadioButton radioButtonIngr;
        private System.Windows.Forms.Label label3;
    }
}