namespace Frontend.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _client;

        public EmployeeService(HttpClient client)
        {
            this._client = client;
        }

        public async Task<HttpResponseMessage> CreateEmployee(Employee employee)
        {
            return await _client.PostAsJsonAsync<Employee>("api/Employee/AddEmployee",employee);
        }

       

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _client.GetFromJsonAsync<Employee[]>("api/Employee/GetEmployees");
        }
    }
}
