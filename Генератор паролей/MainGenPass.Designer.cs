namespace Генератор_паролей
{
    partial class MainGenPass
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
            this.passGenBtn = new System.Windows.Forms.Button();
            this.passList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // passGenBtn
            // 
            this.passGenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passGenBtn.Location = new System.Drawing.Point(314, 393);
            this.passGenBtn.Name = "passGenBtn";
            this.passGenBtn.Size = new System.Drawing.Size(162, 45);
            this.passGenBtn.TabIndex = 1;
            this.passGenBtn.Text = "Сгенерировать пароли";
            this.passGenBtn.UseVisualStyleBackColor = true;
            this.passGenBtn.Click += new System.EventHandler(this.genPass_Click);
            // 
            // passList
            // 
            this.passList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passList.Location = new System.Drawing.Point(12, 12);
            this.passList.Name = "passList";
            this.passList.Size = new System.Drawing.Size(347, 375);
            this.passList.TabIndex = 2;
            this.passList.Text = "";
            // 
            // MainGenPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.passList);
            this.Controls.Add(this.passGenBtn);
            this.Name = "MainGenPass";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button passGenBtn;
        private System.Windows.Forms.RichTextBox passList;
    }
}

