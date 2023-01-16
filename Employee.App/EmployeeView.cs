using Employee.Data.IRepositories;
using Employee.Data.Repositories;
using Employee.Domain.Entities;
using Employee.Domain.Enums;

namespace Employee.App
{
    public partial class EmployeeView : Form
    {
#pragma warning disable

        #region private
        private IEmployeeRepository employeeRepository;
        private IList<EmployeeModel> employees;
        private long EmployeeId;
        #endregion

        public EmployeeView()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
        }

        #region buttons
        private async void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_txt.Text is not "" || Department_txt.Text is not "")
                {
                    EmployeeModel model = new EmployeeModel()
                    {
                        Name = Name_txt.Text,
                        CurrentCity = City_txt.Text,
                        Department = Department_txt.Text,
                        GenderType = Gender_ComboBox.Text == "Male" ? Gender.Male : Gender.Female
                    };

                    bool exist = await employeeRepository.DeleteAsync(p => p.Id == EmployeeId);

                    if(exist == true)
                    {
                        employeeRepository.CreateAsync(model);
                        MessageBox.Show("Updated!");
                    }

                    else
                    {
                        employeeRepository.CreateAsync(model);
                        MessageBox.Show("Saved!");
                    }


                    Name_txt.Clear();
                    City_txt.Clear();
                    Department_txt.Clear();
                    dataGridView1.DataSource = GetDataEmployee().Result;
                }

                else
                {
                    MessageBox.Show("To'liq kiriting!");
                }
            }

            catch { MessageBox.Show("Malumotlarni to'g'ri kiriting!"); }
        }

        private async void Clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                await employeeRepository.DeleteAllAsync();
                MessageBox.Show("All Deleted !!!");
                dataGridView1.DataSource = GetDataEmployee().Result;
            }
            catch { MessageBox.Show("Error"); }
        }

        private async void Delete_btn_Click(object sender, EventArgs e)
        {
            EmployeeModel employee = (EmployeeModel)dataGridView1.SelectedRows[0].DataBoundItem;
            if (employee is not null)
            {
                bool isDeleted = await employeeRepository.DeleteAsync(p => p.Id == employee.Id);

                if (isDeleted)
                {
                    MessageBox.Show($"{employee.Name} Deleted!");
                    dataGridView1.DataSource = GetDataEmployee().Result;
                }

                else
                    MessageBox.Show("Error!");
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name_txt.Clear();
            City_txt.Clear();
            Department_txt.Clear();
            Gender_ComboBox.Text = "";
        }
        #endregion


        private void EmployeeView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDataEmployee().Result;
        }

        //Returns employee data
        private async Task<IList<EmployeeModel>> GetDataEmployee()
        {
            employees = (await employeeRepository.GetAllAsync()).ToList();

            return employees;
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeModel employee = dataGridView1.Rows[e.RowIndex].DataBoundItem as EmployeeModel;

            EmployeeId = employee.Id;
            Name_txt.Text = employee.Name;
            City_txt.Text = employee.CurrentCity;
            Department_txt.Text = employee.Department;
            Gender_ComboBox.Text = employee.GenderType.ToString();
        }
    }
}
