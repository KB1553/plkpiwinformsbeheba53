namespace WinFormsApp2
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
            btnCalc = new Button();
            lblResult = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRed = new Button();
            btnGreen = new Button();
            btnBlue = new Button();
            btnYellow = new Button();
            btnIncrement = new Button();
            btnResetCounter = new Button();
            lblColorName = new Label();
            lblCount = new Label();
            SuspendLayout();
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(95, 89);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(98, 23);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "порахувати";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(115, 226);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "результат";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(38, 175);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(151, 175);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 146);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "ширина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 146);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "довжина";
            // 
            // btnRed
            // 
            btnRed.Location = new Point(357, 199);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(75, 23);
            btnRed.TabIndex = 6;
            btnRed.Text = "червоний";
            btnRed.UseVisualStyleBackColor = true;
            btnRed.Click += ColorButton_Click;
            // 
            // btnGreen
            // 
            btnGreen.Location = new Point(438, 199);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(75, 23);
            btnGreen.TabIndex = 7;
            btnGreen.Text = "зелений";
            btnGreen.UseVisualStyleBackColor = true;
            btnGreen.Click += ColorButton_Click;
            // 
            // btnBlue
            // 
            btnBlue.Location = new Point(519, 199);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(75, 23);
            btnBlue.TabIndex = 8;
            btnBlue.Text = "синій";
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += ColorButton_Click;
            // 
            // btnYellow
            // 
            btnYellow.Location = new Point(600, 199);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(75, 23);
            btnYellow.TabIndex = 9;
            btnYellow.Text = "зелений";
            btnYellow.UseVisualStyleBackColor = true;
            btnYellow.Click += ColorButton_Click;
            // 
            // btnIncrement
            // 
            btnIncrement.Location = new Point(768, 146);
            btnIncrement.Name = "btnIncrement";
            btnIncrement.Size = new Size(75, 23);
            btnIncrement.TabIndex = 10;
            btnIncrement.Text = "+1";
            btnIncrement.UseVisualStyleBackColor = true;
            btnIncrement.Click += btnIncrement_Click;
            // 
            // btnResetCounter
            // 
            btnResetCounter.Location = new Point(768, 240);
            btnResetCounter.Name = "btnResetCounter";
            btnResetCounter.Size = new Size(75, 23);
            btnResetCounter.TabIndex = 11;
            btnResetCounter.Text = "на нуль";
            btnResetCounter.UseVisualStyleBackColor = true;
            btnResetCounter.Click += btnResetCounter_Click;
            // 
            // lblColorName
            // 
            lblColorName.AutoSize = true;
            lblColorName.Location = new Point(496, 137);
            lblColorName.Name = "lblColorName";
            lblColorName.Size = new Size(37, 15);
            lblColorName.TabIndex = 12;
            lblColorName.Text = "колір";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(785, 199);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 15);
            lblCount.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 513);
            Controls.Add(lblCount);
            Controls.Add(lblColorName);
            Controls.Add(btnResetCounter);
            Controls.Add(btnIncrement);
            Controls.Add(btnYellow);
            Controls.Add(btnBlue);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblResult);
            Controls.Add(btnCalc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalc;
        private Label lblResult;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Label label1;
        private Label label2;
        private Button btnRed;
        private Button btnGreen;
        private Button btnBlue;
        private Button btnYellow;
        private Button btnIncrement;
        private Button btnResetCounter;
        private Label lblColorName;
        private Label lblCount;
    }
}
