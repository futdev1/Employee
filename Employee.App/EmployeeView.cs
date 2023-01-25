using Employee.ADONET.Data.IRepositories;
using Employee.ADONET.Data.Repositories;
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
        private Employee.Service.Interfaces.IEmployeeService employeeServiceEF;
        private Employee.ADONET.Service.Interfaces.IEmployeeService employeeServiceADO;
        private IList<EmployeeModel> employees;
        private long EmployeeId;
        private int limit = 1;
        #endregion

        public EmployeeView()
        {
            InitializeComponent();
            employeeServiceEF = new Employee.Service.Services.EmployeeService();
            employeeServiceADO = new Employee.ADONET.Service.Services.EmployeeService();
        }


        #region buttons
        private async void Save_btn_Click(object sender, EventArgs e)
        {
            if (Name_txt.Text is not "" || Department_txt.Text is not "")
            {
                EmployeeModel model = new EmployeeModel()
                {
                    id = EmployeeId,
                    name = Name_txt.Text,
                    current_city = City_txt.Text,
                    department = Department_txt.Text,
                    gender_type = Gender_ComboBox.Text == "Male" ? Gender.Male : Gender.Female
                };

                var employee = await employeeServiceADO.GetAsync((int)model.id);

                if (employee == null)
                {
                    await employeeServiceADO.CreateAsync(model);
                    MessageBox.Show("Saved!");
                }

                else
                {
                    employeeServiceADO.UpdateAsync(model);
                    MessageBox.Show("Updated!");
                    EmployeeId = 0;
                }

                #region
                Name_txt.Clear();
                City_txt.Clear();
                Department_txt.Clear();

                dataGridEmployee.DataSource = await employeeServiceADO.GetAllAsync(30, 1);
                #endregion
            }

            else
            {
                MessageBox.Show("To'liq kiriting!");
            }
        }

        private async void Clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                await employeeServiceADO.DeleteAllAsync();
                MessageBox.Show("All Deleted !!!");
                dataGridEmployee.DataSource = await employeeServiceADO.GetAllAsync(30, 1);
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
                    employeeServiceADO.DeleteAsync((int)employee.id);

                    MessageBox.Show($"{employee.name} Deleted!");
                    dataGridEmployee.DataSource = await employeeServiceADO.GetAllAsync(30, 1);

                }
                else { }
            } catch { }

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
            employees = (await employeeServiceEF.GetAllAsync(null, limit)).ToList();
            if (employees is null)
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
                employees = (await employeeServiceEF.GetAllAsync(null, limit)).ToList();
                dataGridEmployee.DataSource = employees;
            }
            else { MessageBox.Show("Siz birinchi pagedasiz"); }
        }
        #endregion


        //Returns employee data

        private void dataGridEmployee_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                EmployeeModel employee = dataGridEmployee.Rows[e.RowIndex].DataBoundItem as EmployeeModel;

                EmployeeId = employee.id;
                Name_txt.Text = employee.name;
                City_txt.Text = employee.current_city;
                Department_txt.Text = employee.department;
                Gender_ComboBox.Text = employee.gender_type.ToString();
            }

            else
            {

            }
        }

        private async void EmployeeView_Load(object sender, EventArgs e)
        {
            dataGridEmployee.DataSource = (await employeeServiceEF.GetAllAsync(null, limit)).ToList();
        }

    }
}
