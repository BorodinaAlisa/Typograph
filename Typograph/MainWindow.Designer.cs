namespace TypographApp
{
    partial class Typograph
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypographLabel = new System.Windows.Forms.Label();
            this.TypographTextBox = new System.Windows.Forms.TextBox();
            this.TypographButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TypographLabel
            // 
            this.TypographLabel.AutoSize = true;
            this.TypographLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypographLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TypographLabel.Location = new System.Drawing.Point(279, 27);
            this.TypographLabel.Name = "TypographLabel";
            this.TypographLabel.Size = new System.Drawing.Size(269, 45);
            this.TypographLabel.TabIndex = 0;
            this.TypographLabel.Text = "   Типограф    ";
            // 
            // TypographTextBox
            // 
            this.TypographTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypographTextBox.Location = new System.Drawing.Point(12, 102);
            this.TypographTextBox.Multiline = true;
            this.TypographTextBox.Name = "TypographTextBox";
            this.TypographTextBox.Size = new System.Drawing.Size(824, 308);
            this.TypographTextBox.TabIndex = 1;
            this.TypographTextBox.Text = "Введите текст …";
            this.TypographTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypographTextBox_KeyPress);
            // 
            // TypographButton
            // 
            this.TypographButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TypographButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypographButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TypographButton.Location = new System.Drawing.Point(287, 434);
            this.TypographButton.Name = "TypographButton";
            this.TypographButton.Size = new System.Drawing.Size(261, 54);
            this.TypographButton.TabIndex = 2;
            this.TypographButton.Text = "Оттипографить";
            this.TypographButton.UseVisualStyleBackColor = false;
            this.TypographButton.Click += new System.EventHandler(this.TypographButton_Click);
            // 
            // Typograph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 614);
            this.Controls.Add(this.TypographButton);
            this.Controls.Add(this.TypographTextBox);
            this.Controls.Add(this.TypographLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Typograph";
            this.Text = "Типограф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypographLabel;
        private System.Windows.Forms.TextBox TypographTextBox;
        private System.Windows.Forms.Button TypographButton;
    }
}

