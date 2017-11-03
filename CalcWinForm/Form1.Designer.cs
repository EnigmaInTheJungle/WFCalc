namespace CalcWinForm
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
            this.firstValue = new System.Windows.Forms.TextBox();
            this.operValue = new System.Windows.Forms.TextBox();
            this.secondValue = new System.Windows.Forms.TextBox();
            this.resultValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstValue
            // 
            this.firstValue.Location = new System.Drawing.Point(27, 36);
            this.firstValue.Name = "firstValue";
            this.firstValue.Size = new System.Drawing.Size(52, 20);
            this.firstValue.TabIndex = 0;
            // 
            // operValue
            // 
            this.operValue.Location = new System.Drawing.Point(85, 36);
            this.operValue.Name = "operValue";
            this.operValue.Size = new System.Drawing.Size(21, 20);
            this.operValue.TabIndex = 1;
            // 
            // secondValue
            // 
            this.secondValue.Location = new System.Drawing.Point(112, 36);
            this.secondValue.Name = "secondValue";
            this.secondValue.Size = new System.Drawing.Size(52, 20);
            this.secondValue.TabIndex = 3;
            // 
            // resultValue
            // 
            this.resultValue.Location = new System.Drawing.Point(191, 36);
            this.resultValue.Name = "resultValue";
            this.resultValue.Size = new System.Drawing.Size(163, 20);
            this.resultValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // butCalculate
            // 
            this.butCalculate.Location = new System.Drawing.Point(89, 73);
            this.butCalculate.Name = "butCalculate";
            this.butCalculate.Size = new System.Drawing.Size(75, 23);
            this.butCalculate.TabIndex = 6;
            this.butCalculate.Text = "Calculate";
            this.butCalculate.UseVisualStyleBackColor = true;
            this.butCalculate.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 122);
            this.Controls.Add(this.butCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.secondValue);
            this.Controls.Add(this.operValue);
            this.Controls.Add(this.firstValue);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstValue;
        private System.Windows.Forms.TextBox operValue;
        private System.Windows.Forms.TextBox secondValue;
        private System.Windows.Forms.TextBox resultValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCalculate;
    }
}

