using System.Collections.Generic;
using System.Linq;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Data
{
    public class Connection
    {
        WEBAPI_DBEntities dbContext = new WEBAPI_DBEntities();
        public Connection()
        {
            
        }

        public IEnumerable<Employee> GetAlllEmployees()
        {
            return dbContext.Employees.ToList();
        }

        public Employee GetEmployeeByID(int ID)
        {
            return dbContext.Employees.FirstOrDefault(e => e.ID == ID);
        }

        public void InsertEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            var result = dbContext.SaveChanges();
        }

        public int UpdateEmployee(int id, Employee emp)
        {
            Employee employee = dbContext.Employees.FirstOrDefault(e => e.ID == id);
            if(employee == null)
            {
                return 0;
            }
            else
            {
                employee.FirstName = emp.FirstName;
                employee.LastName = emp.LastName;
                employee.Salary = emp.Salary;
                employee.Gender = emp.Gender;

                dbContext.SaveChanges();
                return 1;
            }
        }

        public int DeleteEmployee(int id)
        {
            Employee emp = dbContext.Employees.FirstOrDefault(e => e.ID == id);
            if(emp == null)
            {
                return 0;
            }
            else
            {
                dbContext.Employees.Remove(emp);
                dbContext.SaveChanges();
                return 1;
            }
        }
    }
}