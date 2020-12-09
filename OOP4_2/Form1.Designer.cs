namespace OOP4_2
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
            this.textBox_Num1 = new System.Windows.Forms.TextBox();
            this.textBox_Num2 = new System.Windows.Forms.TextBox();
            this.numericUpDown_Num1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Num2 = new System.Windows.Forms.NumericUpDown();
            this.label_Num1 = new System.Windows.Forms.Label();
            this.label_Num2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Num2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Num1
            // 
            this.textBox_Num1.Location = new System.Drawing.Point(78, 62);
            this.textBox_Num1.Name = "textBox_Num1";
            this.textBox_Num1.Size = new System.Drawing.Size(120, 22);
            this.textBox_Num1.TabIndex = 0;
            this.textBox_Num1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Num1_KeyDown);
            // 
            // textBox_Num2
            // 
            this.textBox_Num2.Location = new System.Drawing.Point(364, 62);
            this.textBox_Num2.Name = "textBox_Num2";
            this.textBox_Num2.Size = new System.Drawing.Size(120, 22);
            this.textBox_Num2.TabIndex = 1;
            this.textBox_Num2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Num2_KeyDown);
            // 
            // numericUpDown_Num1
            // 
            this.numericUpDown_Num1.Location = new System.Drawing.Point(78, 105);
            this.numericUpDown_Num1.Name = "numericUpDown_Num1";
            this.numericUpDown_Num1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Num1.TabIndex = 2;
            this.numericUpDown_Num1.ValueChanged += new System.EventHandler(this.numericUpDown_Num1_ValueChanged);
            // 
            // numericUpDown_Num2
            // 
            this.numericUpDown_Num2.Location = new System.Drawing.Point(364, 105);
            this.numericUpDown_Num2.Name = "numericUpDown_Num2";
            this.numericUpDown_Num2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Num2.TabIndex = 3;
            this.numericUpDown_Num2.ValueChanged += new System.EventHandler(this.numericUpDown_Num2_ValueChanged);
            // 
            // label_Num1
            // 
            this.label_Num1.AutoSize = true;
            this.label_Num1.Location = new System.Drawing.Point(78, 144);
            this.label_Num1.Name = "label_Num1";
            this.label_Num1.Size = new System.Drawing.Size(0, 17);
            this.label_Num1.TabIndex = 4;
            // 
            // label_Num2
            // 
            this.label_Num2.AutoSize = true;
            this.label_Num2.Location = new System.Drawing.Point(364, 144);
            this.label_Num2.Name = "label_Num2";
            this.label_Num2.Size = new System.Drawing.Size(0, 17);
            this.label_Num2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Num2);
            this.Controls.Add(this.label_Num1);
            this.Controls.Add(this.numericUpDown_Num2);
            this.Controls.Add(this.numericUpDown_Num1);
            this.Controls.Add(this.textBox_Num2);
            this.Controls.Add(this.textBox_Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Num1;
        private System.Windows.Forms.TextBox textBox_Num2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Num1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Num2;
        private System.Windows.Forms.Label label_Num1;
        private System.Windows.Forms.Label label_Num2;
    }
}

