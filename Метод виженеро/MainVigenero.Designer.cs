namespace Метод_виженеро
{
    partial class MainVigenero
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.Encode = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключеов слово";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Слово для шифрования";
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Word.Location = new System.Drawing.Point(65, 71);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(525, 22);
            this.Word.TabIndex = 2;
            // 
            // KeyWord
            // 
            this.KeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyWord.Location = new System.Drawing.Point(65, 139);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(525, 22);
            this.KeyWord.TabIndex = 3;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(65, 210);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(525, 22);
            this.result.TabIndex = 4;
            // 
            // Encode
            // 
            this.Encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encode.Location = new System.Drawing.Point(66, 330);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(134, 45);
            this.Encode.TabIndex = 5;
            this.Encode.Text = "Зашифровать";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Decode
            // 
            this.Decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decode.Location = new System.Drawing.Point(206, 330);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(134, 44);
            this.Decode.TabIndex = 6;
            this.Decode.Text = "Расшифровать";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileBtn.Location = new System.Drawing.Point(495, 330);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(134, 44);
            this.saveFileBtn.TabIndex = 8;
            this.saveFileBtn.Text = "Сохранить в файл";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // MainVigenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 412);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.result);
            this.Controls.Add(this.KeyWord);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainVigenero";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveFileBtn;
    }
}

