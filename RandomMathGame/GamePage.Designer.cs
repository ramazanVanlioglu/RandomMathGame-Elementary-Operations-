namespace RandomMathGame
{
    partial class GamePage
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
            this.button_sum = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.label_num1 = new System.Windows.Forms.Label();
            this.label_num2 = new System.Windows.Forms.Label();
            this.label_sign = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_equals = new System.Windows.Forms.Label();
            this.label_correct = new System.Windows.Forms.Label();
            this.label_mistakes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sum
            // 
            this.button_sum.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sum.Location = new System.Drawing.Point(123, 311);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(96, 52);
            this.button_sum.TabIndex = 0;
            this.button_sum.Text = "+";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_subtract.Location = new System.Drawing.Point(240, 311);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(96, 52);
            this.button_subtract.TabIndex = 0;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_multiply.Location = new System.Drawing.Point(353, 311);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(96, 52);
            this.button_multiply.TabIndex = 0;
            this.button_multiply.Text = "x";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_divide.Location = new System.Drawing.Point(467, 311);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(96, 52);
            this.button_divide.TabIndex = 0;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // label_num1
            // 
            this.label_num1.AutoSize = true;
            this.label_num1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_num1.Location = new System.Drawing.Point(94, 131);
            this.label_num1.Name = "label_num1";
            this.label_num1.Size = new System.Drawing.Size(64, 28);
            this.label_num1.TabIndex = 1;
            this.label_num1.Text = "num1";
            // 
            // label_num2
            // 
            this.label_num2.AutoSize = true;
            this.label_num2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_num2.Location = new System.Drawing.Point(304, 131);
            this.label_num2.Name = "label_num2";
            this.label_num2.Size = new System.Drawing.Size(64, 28);
            this.label_num2.TabIndex = 1;
            this.label_num2.Text = "num2";
            // 
            // label_sign
            // 
            this.label_sign.AutoSize = true;
            this.label_sign.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sign.Location = new System.Drawing.Point(184, 131);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(64, 28);
            this.label_sign.TabIndex = 1;
            this.label_sign.Text = "sign";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_result.Location = new System.Drawing.Point(513, 131);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(90, 28);
            this.label_result.TabIndex = 1;
            this.label_result.Text = "result";
            // 
            // label_equals
            // 
            this.label_equals.AutoSize = true;
            this.label_equals.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_equals.Location = new System.Drawing.Point(417, 131);
            this.label_equals.Name = "label_equals";
            this.label_equals.Size = new System.Drawing.Size(25, 28);
            this.label_equals.TabIndex = 1;
            this.label_equals.Text = "=";
            // 
            // label_correct
            // 
            this.label_correct.AutoSize = true;
            this.label_correct.Location = new System.Drawing.Point(29, 23);
            this.label_correct.Name = "label_correct";
            this.label_correct.Size = new System.Drawing.Size(84, 15);
            this.label_correct.TabIndex = 2;
            this.label_correct.Text = "Corrects: 0";
            // 
            // label_mistakes
            // 
            this.label_mistakes.AutoSize = true;
            this.label_mistakes.Location = new System.Drawing.Point(554, 23);
            this.label_mistakes.Name = "label_mistakes";
            this.label_mistakes.Size = new System.Drawing.Size(84, 15);
            this.label_mistakes.TabIndex = 2;
            this.label_mistakes.Text = "Mistakes: 0";
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.label_mistakes);
            this.Controls.Add(this.label_correct);
            this.Controls.Add(this.label_equals);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_sign);
            this.Controls.Add(this.label_num2);
            this.Controls.Add(this.label_num1);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_sum);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePage";
            this.Load += new System.EventHandler(this.GamePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Label label_num1;
        private System.Windows.Forms.Label label_num2;
        private System.Windows.Forms.Label label_sign;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_equals;
        private System.Windows.Forms.Label label_correct;
        private System.Windows.Forms.Label label_mistakes;
    }
}