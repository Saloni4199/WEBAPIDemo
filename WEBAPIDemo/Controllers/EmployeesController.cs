using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIDemo.Data;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        Connection con = new Connection();
        public HttpResponseMessage Get()
        {
            IEnumerable<Employee> employeeList = con.GetAlllEmployees();
            return Request.CreateResponse(HttpStatusCode.OK, employeeList);
        }

        public HttpResponseMessage Get(int id)
        {
            Employee emp = con.GetEmployeeByID(id);
            if(emp != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, emp);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Employee with ID=" + id + " is not found");
            }
        }

        public HttpResponseMessage Post([FromBody] Employee emp)
        {
            try
            {
                con.InsertEmployee(emp);
                return Request.CreateResponse(HttpStatusCode.Created, "Employee Added!!");
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Employee was not added " + ex.InnerException);
            }
        }

        public HttpResponseMessage Put(int id, [FromBody] Employee emp)
        {
            try
            {
                int result = con.UpdateEmployee(id, emp);
                if(result == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Employee with ID=" + id + " not found");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Employee UPdated");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Employee not update as of exception " + ex.Message);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                int result = con.DeleteEmployee(id);
                if (result == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Employee with ID=" + id + " not found");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Employee Deleted");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Employee not deleted as of exception " + ex.Message);
            }
        }

    }
}
