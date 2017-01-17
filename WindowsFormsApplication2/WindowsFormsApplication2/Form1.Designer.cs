namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.fibButton = new System.Windows.Forms.RadioButton();
            this.sumButton = new System.Windows.Forms.RadioButton();
            this.number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(147, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a math function:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fibButton
            // 
            this.fibButton.AutoSize = true;
            this.fibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fibButton.Location = new System.Drawing.Point(155, 177);
            this.fibButton.Name = "fibButton";
            this.fibButton.Size = new System.Drawing.Size(394, 48);
            this.fibButton.TabIndex = 3;
            this.fibButton.TabStop = true;
            this.fibButton.Text = "Fibonacci Sequence";
            this.fibButton.UseVisualStyleBackColor = true;
            // 
            // sumButton
            // 
            this.sumButton.AutoSize = true;
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sumButton.Location = new System.Drawing.Point(155, 250);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(246, 48);
            this.sumButton.TabIndex = 4;
            this.sumButton.TabStop = true;
            this.sumButton.Text = "Summation";
            this.sumButton.UseVisualStyleBackColor = true;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(333, 355);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(130, 31);
            this.number.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(147, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number:";
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calcButton.Location = new System.Drawing.Point(249, 426);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(192, 50);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 785);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.fibButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fibButton;
        private System.Windows.Forms.RadioButton sumButton;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcButton;
    }
}

