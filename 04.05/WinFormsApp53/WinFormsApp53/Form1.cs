using System.Text.Json;

namespace WinFormsApp53
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private string filePath = "students_data.json";

        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile();
            RefreshGrid();

            
            dgvStudents.CellFormatting += DgvStudents_CellFormatting;
        }

        public class Student
        {
          
            public string LastName { get; set; } = string.Empty;
            public int MathScore { get; set; }
            public int Physics { get; set; }
            public int History { get; set; }

           
            public double Average => System.Math.Round((MathScore + Physics + History) / 3.0, 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) return;

            var newStudent = new Student
            {
                LastName = txtLastName.Text,
                MathScore = (int)numMath.Value,
                Physics = (int)numPhysics.Value,
                History = (int)numHistory.Value
            };

            students.Add(newStudent);
            RefreshGrid();
            txtLastName.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var filtered = students.Where(s => s.LastName.ToLower().Contains(searchText)).ToList();
            RefreshGrid(filtered);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            students = students.OrderByDescending(s => s.Average).ToList();
            RefreshGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(students);
                File.WriteAllText(filePath, jsonString);
                MessageBox.Show("Дані збережено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження: {ex.Message}");
            }
        }

        private void RefreshGrid(List<Student>? dataSource = null)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = dataSource ?? students;
        }

        
        private void DgvStudents_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e != null && dgvStudents.Columns[e.ColumnIndex].DataPropertyName == "Average")
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double avg))
                {
                    if (avg < 7)
                        dgvStudents.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    else
                        dgvStudents.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void LoadDataFromFile()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    
                    students = JsonSerializer.Deserialize<List<Student>>(jsonString) ?? new List<Student>();
                }
                catch
                {
                    students = new List<Student>();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (dgvStudents.CurrentRow != null)
            {
               
                var studentToRemove = (Student)dgvStudents.CurrentRow.DataBoundItem;

                if (studentToRemove != null)
                {
                  
                    students.Remove(studentToRemove);

                   
                    RefreshGrid();

                    MessageBox.Show("Запис видалено!");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рядок для видалення.");
            }
        }
    }
}