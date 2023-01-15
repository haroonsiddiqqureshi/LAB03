namespace LAB3
{
    public partial class Form1 : Form
    {
        List<Student> StudentList = new List<Student>();
        List<double> GradeList = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string name = this.textBox1.Text;
                string student_id = this.textBox2.Text;
                string birth_year = this.textBox3.Text;
                string height = this.textBox4.Text;
                double grade = double.Parse(this.textBox5.Text);
                string branch = this.textBox6.Text;

                Student student = new Student(name, student_id, birth_year, height, grade, branch);
                StudentList.Add(student);

                BindingSource source = new BindingSource();
                source.DataSource = StudentList;
                this.dataGridView1.DataSource = source;

                foreach (var val in StudentList)
                {
                    this.GradeList.Add(val.Grade);
                }

                double Maxgrade = GradeList.Max();
                double Mingrade = GradeList.Min();
                int TotalStudent = StudentList.Count();

                this.lableTotalStudent.Text = TotalStudent.ToString();
                this.labelMax.Text = Maxgrade.ToString();
                this.lableMin.Text = Mingrade.ToString();
            }
            catch 
            {
                return;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}