namespace WinFormsApp53
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
            dgvStudents = new DataGridView();
            LastName = new DataGridViewTextBoxColumn();
            MathScore = new DataGridViewTextBoxColumn();
            Physics = new DataGridViewTextBoxColumn();
            History = new DataGridViewTextBoxColumn();
            Average = new DataGridViewTextBoxColumn();
            txtLastName = new TextBox();
            txtSearch = new TextBox();
            numMath = new NumericUpDown();
            numPhysics = new NumericUpDown();
            numHistory = new NumericUpDown();
            btnAdd = new Button();
            btnSort = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPhysics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { LastName, MathScore, Physics, History, Average });
            dgvStudents.Location = new Point(175, 147);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(543, 160);
            dgvStudents.TabIndex = 0;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "прізвище";
            LastName.Name = "LastName";
            // 
            // MathScore
            // 
            MathScore.DataPropertyName = "MathScore";
            MathScore.HeaderText = "математика";
            MathScore.Name = "MathScore";
            // 
            // Physics
            // 
            Physics.DataPropertyName = "Physics";
            Physics.HeaderText = "фізика";
            Physics.Name = "Physics";
            // 
            // History
            // 
            History.DataPropertyName = "History";
            History.HeaderText = "історія";
            History.Name = "History";
            // 
            // Average
            // 
            Average.DataPropertyName = "Average";
            Average.HeaderText = "середній бал";
            Average.Name = "Average";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(43, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(115, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(43, 147);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(115, 23);
            txtSearch.TabIndex = 2;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // numMath
            // 
            numMath.Location = new Point(313, 118);
            numMath.Name = "numMath";
            numMath.Size = new Size(102, 23);
            numMath.TabIndex = 3;
            // 
            // numPhysics
            // 
            numPhysics.Location = new Point(421, 118);
            numPhysics.Name = "numPhysics";
            numPhysics.Size = new Size(96, 23);
            numPhysics.TabIndex = 4;
            // 
            // numHistory
            // 
            numHistory.Location = new Point(523, 118);
            numHistory.Name = "numHistory";
            numHistory.Size = new Size(92, 23);
            numHistory.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(43, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "додати учня";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(43, 284);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(115, 23);
            btnSort.TabIndex = 7;
            btnSort.Text = "топ за рейтингом";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(43, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "зберегти дані";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 62);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "прізвище";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 129);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 10;
            label2.Text = "пошук";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(198, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "видалити учня";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnSort);
            Controls.Add(btnAdd);
            Controls.Add(numHistory);
            Controls.Add(numPhysics);
            Controls.Add(numMath);
            Controls.Add(txtSearch);
            Controls.Add(txtLastName);
            Controls.Add(dgvStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMath).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPhysics).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private TextBox txtLastName;
        private TextBox txtSearch;
        private NumericUpDown numMath;
        private NumericUpDown numPhysics;
        private NumericUpDown numHistory;
        private Button btnAdd;
        private Button btnSort;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn MathScore;
        private DataGridViewTextBoxColumn Physics;
        private DataGridViewTextBoxColumn History;
        private DataGridViewTextBoxColumn Average;
        private Button btnDelete;
    }
}
