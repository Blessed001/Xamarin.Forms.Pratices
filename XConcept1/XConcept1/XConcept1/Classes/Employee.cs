using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace XConcept1.Classes
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }
        public string MidleName { get; set; }

        public string LastName { get; set; }

        public DateTime ContractDate { get; set; }

        public string Level { get; set; }

        public bool Active { get; set; }

        public string FullName { get { return string.Format("{0} {1} {2}", LastName, FirstName, MidleName); } }

        public override int GetHashCode()
        {
            return EmployeeId;
        }

        public override string ToString()
        {
            return string.Format($"{FullName} ");
        }
    }
}
