namespace CRUD_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Student s= new Student();
            s.add(txt_student.Text, txt_module.Text);
            MessageBox.Show("Data Inserted");
            txt_student.ResetText();
            txt_module.ResetText();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.update(txt_student.Text, txt_module.Text);
            MessageBox.Show("Data Updated");
            txt_student.ResetText();
            txt_module.ResetText();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.remove(txt_student.Text);
            MessageBox.Show("Data Removed");
            txt_student.ResetText();
            txt_module.ResetText();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            List<Student> stds = new List<Student>();
            stds= s.view();
            dataGridView1.DataSource= stds;
                
            
        }
    }
}