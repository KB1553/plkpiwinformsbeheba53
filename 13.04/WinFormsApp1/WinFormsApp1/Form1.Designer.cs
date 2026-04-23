namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnRun = new Button();
            btnOpen = new Button();
            btnSave = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(184, 43);
            button1.Name = "button1";
            button1.Size = new Size(65, 54);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += GameButtonClick;
            // 
            // button2
            // 
            button2.Location = new Point(255, 43);
            button2.Name = "button2";
            button2.Size = new Size(65, 54);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += GameButtonClick;
            // 
            // button3
            // 
            button3.Location = new Point(326, 43);
            button3.Name = "button3";
            button3.Size = new Size(65, 54);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += GameButtonClick;
            // 
            // button4
            // 
            button4.Location = new Point(184, 103);
            button4.Name = "button4";
            button4.Size = new Size(65, 54);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += GameButtonClick;
            // 
            // button5
            // 
            button5.Location = new Point(255, 103);
            button5.Name = "button5";
            button5.Size = new Size(65, 54);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += GameButtonClick;
            // 
            // button6
            // 
            button6.Location = new Point(326, 103);
            button6.Name = "button6";
            button6.Size = new Size(65, 54);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += GameButtonClick;
            // 
            // button7
            // 
            button7.Location = new Point(184, 163);
            button7.Name = "button7";
            button7.Size = new Size(65, 54);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += GameButtonClick;
            // 
            // button8
            // 
            button8.Location = new Point(255, 163);
            button8.Name = "button8";
            button8.Size = new Size(65, 54);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += GameButtonClick;
            // 
            // button9
            // 
            button9.Location = new Point(326, 163);
            button9.Name = "button9";
            button9.Size = new Size(65, 54);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += GameButtonClick;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(48, 123);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(99, 56);
            btnRun.TabIndex = 9;
            btnRun.Text = "я тікаю";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_MouseEnter;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(544, 96);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 10;
            btnOpen.Text = "відкрити";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(652, 96);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(586, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(btnRun);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnRun;
        private Button btnOpen;
        private Button btnSave;
        private TextBox textBox1;
    }
}
