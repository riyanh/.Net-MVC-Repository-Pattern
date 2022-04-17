using RepositoryPaternWeb.Data;
using RepositoryPaternWeb.Infrastructure;
using RepositoryPaternWeb.Models;

namespace RepositoryPaternWeb.Service
{
    public class EmployeeRepo : IEmployee
    {
        private EmployeeContext _context;

        public EmployeeRepo(EmployeeContext context)
        {
            _context = context;
        }
        public void Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int Id)
        {
            return  _context.Employees.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Insert(Employee employee)
        {
           _context.Employees.Add(employee);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }
    }
}
