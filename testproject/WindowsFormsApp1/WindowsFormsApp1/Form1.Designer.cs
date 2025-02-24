namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonMed = new System.Windows.Forms.Button();
            this.buttonPolis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMed
            // 
            this.buttonMed.Location = new System.Drawing.Point(66, 115);
            this.buttonMed.Name = "buttonMed";
            this.buttonMed.Size = new System.Drawing.Size(140, 90);
            this.buttonMed.TabIndex = 0;
            this.buttonMed.Text = "Результаты медицинского освидетельствования";
            this.buttonMed.UseVisualStyleBackColor = true;
            this.buttonMed.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // buttonPolis
            // 
            this.buttonPolis.Location = new System.Drawing.Point(380, 115);
            this.buttonPolis.Name = "buttonPolis";
            this.buttonPolis.Size = new System.Drawing.Size(140, 90);
            this.buttonPolis.TabIndex = 1;
            this.buttonPolis.Text = "Полис дополнительного или обязательного медицинского страхования";
            this.buttonPolis.UseVisualStyleBackColor = true;
            this.buttonPolis.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Получение мед освидетельствования и полиса";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 196);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить System32";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPolis);
            this.Controls.Add(this.buttonMed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMed;
        private System.Windows.Forms.Button buttonPolis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

