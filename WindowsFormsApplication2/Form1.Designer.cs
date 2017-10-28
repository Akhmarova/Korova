namespace WindowsFormsApplication2
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
            this.lbInput = new System.Windows.Forms.Label();
            this.tBnumber = new System.Windows.Forms.TextBox();
            this.lbRes = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(31, 55);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(84, 13);
            this.lbInput.TabIndex = 0;
            this.lbInput.Text = "Введите число:";
            // 
            // tBnumber
            // 
            this.tBnumber.Location = new System.Drawing.Point(122, 47);
            this.tBnumber.Name = "tBnumber";
            this.tBnumber.Size = new System.Drawing.Size(100, 20);
            this.tBnumber.TabIndex = 1;
            this.tBnumber.TextChanged += new System.EventHandler(this.tBnumber_TextChanged);
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(79, 141);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(0, 13);
            this.lbRes.TabIndex = 2;
            this.lbRes.UseWaitCursor = true;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(91, 164);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(35, 13);
            this.labelRes.TabIndex = 3;
            this.labelRes.Text = "label1";
            this.labelRes.Click += new System.EventHandler(this.labelRes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Правильное склонение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.tBnumber);
            this.Controls.Add(this.lbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tBnumber;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button button1;
    }
}

