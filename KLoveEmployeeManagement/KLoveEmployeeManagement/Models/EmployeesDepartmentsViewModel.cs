using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KLoveEmployeeManagement.Models
{
    public class EmployeesDepartmentsViewModel
    {

            public int employeeID { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string login { get; set; }
            public int active { get; set; }
            public System.DateTime hireDate { get; set; }
            public int departmentId { get; set; }
            public string addressLine1 { get; set; }
            public string addressLine2 { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zipcode { get; set; }
            public string cellPhone { get; set; }
            public string officePhone { get; set; }
            public string email { get; set; }
            public string salary { get; set; }
            public int favoriteSong { get; set; }

            public string departmentName { get; set; }

            public virtual Music Music { get; set; }

            public virtual Department Department { get; set; }
        }
}