namespace Calculator
{
    partial class Form1
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
            labelPrompt = new Label();
            enterNumberTextBox = new TextBox();
            buttonControl = new Button();
            labelAnswer = new Label();
            buttonFirstNum = new Button();
            buttonSecondNum = new Button();
            buttonStart = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonProd = new Button();
            buttonDiv = new Button();
            operationButtonsGroup = new GroupBox();
            enterNumberButtonsGroup = new GroupBox();
            solveButtonGroup = new GroupBox();
            copyrightLabel = new LinkLabel();
            operationButtonsGroup.SuspendLayout();
            enterNumberButtonsGroup.SuspendLayout();
            solveButtonGroup.SuspendLayout();
            SuspendLayout();
            // 
            // labelPrompt
            // 
            labelPrompt.AutoSize = true;
            labelPrompt.Location = new Point(12, 9);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new Size(72, 15);
            labelPrompt.TabIndex = 0;
            labelPrompt.Text = "labelPrompt";
            // 
            // enterNumberTextBox
            // 
            enterNumberTextBox.Location = new Point(6, 13);
            enterNumberTextBox.Name = "enterNumberTextBox";
            enterNumberTextBox.Size = new Size(100, 23);
            enterNumberTextBox.TabIndex = 1;
            enterNumberTextBox.TextChanged += textBox1_TextChanged;
            // 
            // buttonControl
            // 
            buttonControl.Location = new Point(88, 58);
            buttonControl.Name = "buttonControl";
            buttonControl.Size = new Size(100, 36);
            buttonControl.TabIndex = 2;
            buttonControl.Text = "Solve";
            buttonControl.UseVisualStyleBackColor = true;
            buttonControl.Click += buttonControl_Click;
            // 
            // labelAnswer
            // 
            labelAnswer.AutoSize = true;
            labelAnswer.Location = new Point(6, 19);
            labelAnswer.Name = "labelAnswer";
            labelAnswer.Size = new Size(71, 15);
            labelAnswer.TabIndex = 3;
            labelAnswer.Text = "labelAnswer";
            labelAnswer.Visible = false;
            // 
            // buttonFirstNum
            // 
            buttonFirstNum.Location = new Point(6, 42);
            buttonFirstNum.Name = "buttonFirstNum";
            buttonFirstNum.Size = new Size(100, 36);
            buttonFirstNum.TabIndex = 4;
            buttonFirstNum.Text = "Enter first num\r\n";
            buttonFirstNum.UseVisualStyleBackColor = true;
            buttonFirstNum.Click += buttonFirstNum_Click;
            // 
            // buttonSecondNum
            // 
            buttonSecondNum.Location = new Point(6, 84);
            buttonSecondNum.Name = "buttonSecondNum";
            buttonSecondNum.Size = new Size(100, 48);
            buttonSecondNum.TabIndex = 5;
            buttonSecondNum.Text = "Enter second num";
            buttonSecondNum.UseVisualStyleBackColor = true;
            buttonSecondNum.Click += buttonSecondNum_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(156, 30);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(162, 36);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Start calculator";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(6, 13);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(50, 26);
            buttonPlus.TabIndex = 7;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(6, 45);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 26);
            buttonMinus.TabIndex = 8;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonProd
            // 
            buttonProd.Location = new Point(6, 76);
            buttonProd.Name = "buttonProd";
            buttonProd.Size = new Size(50, 26);
            buttonProd.TabIndex = 9;
            buttonProd.Text = "*";
            buttonProd.UseVisualStyleBackColor = true;
            buttonProd.Click += buttonProd_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(6, 108);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(50, 26);
            buttonDiv.TabIndex = 10;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // operationButtonsGroup
            // 
            operationButtonsGroup.Controls.Add(buttonProd);
            operationButtonsGroup.Controls.Add(buttonDiv);
            operationButtonsGroup.Controls.Add(buttonPlus);
            operationButtonsGroup.Controls.Add(buttonMinus);
            operationButtonsGroup.Location = new Point(410, 30);
            operationButtonsGroup.Name = "operationButtonsGroup";
            operationButtonsGroup.Size = new Size(62, 157);
            operationButtonsGroup.TabIndex = 11;
            operationButtonsGroup.TabStop = false;
            operationButtonsGroup.Visible = false;
            // 
            // enterNumberButtonsGroup
            // 
            enterNumberButtonsGroup.Controls.Add(buttonSecondNum);
            enterNumberButtonsGroup.Controls.Add(enterNumberTextBox);
            enterNumberButtonsGroup.Controls.Add(buttonFirstNum);
            enterNumberButtonsGroup.Location = new Point(12, 30);
            enterNumberButtonsGroup.Name = "enterNumberButtonsGroup";
            enterNumberButtonsGroup.Size = new Size(112, 157);
            enterNumberButtonsGroup.TabIndex = 12;
            enterNumberButtonsGroup.TabStop = false;
            enterNumberButtonsGroup.Visible = false;
            // 
            // solveButtonGroup
            // 
            solveButtonGroup.Controls.Add(buttonControl);
            solveButtonGroup.Controls.Add(labelAnswer);
            solveButtonGroup.Location = new Point(130, 87);
            solveButtonGroup.Name = "solveButtonGroup";
            solveButtonGroup.Size = new Size(274, 100);
            solveButtonGroup.TabIndex = 13;
            solveButtonGroup.TabStop = false;
            solveButtonGroup.Visible = false;
            // 
            // copyrightLabel
            // 
            copyrightLabel.AutoSize = true;
            copyrightLabel.LinkArea = new LinkArea(0, 29);
            copyrightLabel.Location = new Point(156, 190);
            copyrightLabel.Name = "copyrightLabel";
            copyrightLabel.Size = new Size(166, 15);
            copyrightLabel.TabIndex = 14;
            copyrightLabel.TabStop = true;
            copyrightLabel.Text = "Copyright Bearded Brain, 2023";
            copyrightLabel.LinkClicked += copyrightLabel_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 211);
            Controls.Add(copyrightLabel);
            Controls.Add(solveButtonGroup);
            Controls.Add(enterNumberButtonsGroup);
            Controls.Add(operationButtonsGroup);
            Controls.Add(buttonStart);
            Controls.Add(labelPrompt);
            Name = "Form1";
            Text = "Windows Calculator (Demo)";
            operationButtonsGroup.ResumeLayout(false);
            enterNumberButtonsGroup.ResumeLayout(false);
            enterNumberButtonsGroup.PerformLayout();
            solveButtonGroup.ResumeLayout(false);
            solveButtonGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrompt;
        private TextBox enterNumberTextBox;
        private Button buttonControl;
        private Label labelAnswer;
        private Button buttonFirstNum;
        private Button buttonSecondNum;
        private Button buttonStart;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonProd;
        private Button buttonDiv;
        private GroupBox operationButtonsGroup;
        private GroupBox enterNumberButtonsGroup;
        private GroupBox solveButtonGroup;
        private LinkLabel copyrightLabel;
    }
}