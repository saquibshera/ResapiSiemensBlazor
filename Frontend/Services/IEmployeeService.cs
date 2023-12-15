namespace Frontend.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<HttpResponseMessage> CreateEmployee(Employee employee);
    }
}
