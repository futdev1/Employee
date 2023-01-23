using Employee.Data.IRepositories;
using Employee.Domain.Entities;
using Employee.Domain.Enums;
using Employee.Service.Interfaces;
using Employee.Service.Services;

namespace Employee.App
{
#pragma warning disable
    public partial class EmployeeView : Form
    {
        #region private
        private IEmployeeService employeeService;
        private IList<EmployeeModel> employees;
        private long EmployeeId;
        private int limit = 1;
        #endregion

        public EmployeeView()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
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
                        Id = EmployeeId,
                        Name = Name_txt.Text,
                        CurrentCity = City_txt.Text,
                        Department = Department_txt.Text,
                        GenderType = Gender_ComboBox.Text == "Male" ? Gender.Male : Gender.Female
                    };
                    
                    var employee = await employeeService.GetAsync(p => p.Id == model.Id);

                    if (employee == null)
                    {
                        
                        employeeService.CreateAsync(model);
                        MessageBox.Show("Saved!");
                    }   

                    else
                    {
                        employeeService.UpdateAsync(model);
                        MessageBox.Show("Updated!");
                    }

                    #region
                    Name_txt.Clear();
                    City_txt.Clear();
                    Department_txt.Clear();

                    dataGridEmployee.DataSource = GetDataEmployee().Result;
                    #endregion
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
                await employeeService.DeleteAllAsync();
                MessageBox.Show("All Deleted !!!");
                dataGridEmployee.DataSource = GetDataEmployee().Result;
            }
            catch { MessageBox.Show("Error"); }
        }

        private async void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeModel employee = (EmployeeModel)dataGridEmployee.SelectedRows[0].DataBoundItem;
                if (employee is not null)
                {
                    bool isDeleted = await employeeService.DeleteAsync(p => p.Id == employee.Id);

                    if (isDeleted)
                    {
                        MessageBox.Show($"{employee.Name} Deleted!");
                        dataGridEmployee.DataSource = GetDataEmployee().Result;
                    }

                    else
                        MessageBox.Show("Error!");
                }
                else { }
            }
            catch {  }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name_txt.Clear();
            City_txt.Clear();
            Department_txt.Clear();
            Gender_ComboBox.Text = "";
        }

        private async void Next_btn_Click(object sender, EventArgs e)
        {
            limit += 1;
            employees = (await employeeService.GetAllAsync(null, limit)).ToList();
            if(employees is null)
            {
                MessageBox.Show("Tugadi");
            }

            dataGridEmployee.DataSource = employees;
        }

        private async void Back_btn_Click(object sender, EventArgs e)
        {
            if (limit > 1)
            {
                limit -= 1;
                employees = (await employeeService.GetAllAsync(null, limit)).ToList();
                dataGridEmployee.DataSource = employees;
            }
            else { MessageBox.Show("Siz birinchi pagedasiz"); }
        }
        #endregion


        //Returns employee data
        private async Task<IList<EmployeeModel>> GetDataEmployee()
        {
            employees = (await employeeService.GetAllAsync(null, limit)).ToList();

            return employees;
        }


        private void dataGridEmployee_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if(e.RowIndex >= 0)
            {
                EmployeeModel employee = dataGridEmployee.Rows[e.RowIndex].DataBoundItem as EmployeeModel;

                EmployeeId = employee.Id;
                Name_txt.Text = employee.Name;
                City_txt.Text = employee.CurrentCity;
                Department_txt.Text = employee.Department;
                Gender_ComboBox.Text = employee.GenderType.ToString();
            }

            else
            {
                MessageBox.Show("Error");
            }
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            dataGridEmployee.DataSource = GetDataEmployee().Result;
        }

    }
}
