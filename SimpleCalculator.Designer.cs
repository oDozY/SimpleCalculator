namespace SimpleCalculator
{
    partial class SimpleCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnNum0 = new Button();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnAdd = new Button();
            btnEqual = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 45F);
            lblTitle.Location = new Point(212, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(763, 120);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Simple Calculator";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 30F);
            txtInput.Location = new Point(212, 186);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(757, 87);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("맑은 고딕", 30F);
            txtOutput.Location = new Point(212, 310);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(757, 87);
            txtOutput.TabIndex = 2;
            // 
            // btnNum0
            // 
            btnNum0.Location = new Point(410, 875);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(150, 75);
            btnNum0.TabIndex = 3;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            // 
            // btnNum1
            // 
            btnNum1.Location = new Point(212, 759);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(150, 75);
            btnNum1.TabIndex = 4;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            // 
            // btnNum2
            // 
            btnNum2.Location = new Point(410, 759);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(150, 75);
            btnNum2.TabIndex = 5;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            // 
            // btnNum3
            // 
            btnNum3.Location = new Point(611, 759);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(150, 75);
            btnNum3.TabIndex = 6;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            // 
            // btnNum4
            // 
            btnNum4.Location = new Point(212, 645);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(150, 75);
            btnNum4.TabIndex = 7;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            // 
            // btnNum5
            // 
            btnNum5.Location = new Point(410, 645);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(150, 75);
            btnNum5.TabIndex = 8;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            // 
            // btnNum6
            // 
            btnNum6.Location = new Point(611, 645);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(150, 75);
            btnNum6.TabIndex = 9;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            // 
            // btnNum7
            // 
            btnNum7.Location = new Point(212, 527);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(150, 75);
            btnNum7.TabIndex = 10;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            // 
            // btnNum8
            // 
            btnNum8.Location = new Point(410, 527);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(150, 75);
            btnNum8.TabIndex = 11;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            // 
            // btnNum9
            // 
            btnNum9.Location = new Point(611, 527);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(150, 75);
            btnNum9.TabIndex = 12;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(819, 759);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 75);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(819, 875);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(150, 75);
            btnEqual.TabIndex = 14;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(819, 645);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(150, 75);
            btnSub.TabIndex = 15;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(819, 527);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(150, 75);
            btnMul.TabIndex = 16;
            btnMul.Text = "×";
            btnMul.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(819, 419);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(150, 75);
            btnDiv.TabIndex = 17;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 1009);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnNum0);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Name = "SimpleCalculator";
            Text = "Carculator v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnNum0;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnAdd;
        private Button btnEqual;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
    }
}
