using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class PayrollDatabase
    {
        private static Hashtable employees = new Hashtable();
        private static Hashtable unionMembers = new Hashtable();

        public static void AddEmployee(Employee employee)
        {
            employees[employee.EmpId] = employee;
        }

        public static Employee GetEmployee(int id)
        {
            return employees[id] as Employee;
        }

        public static void DeleteEmployee(int id)
        {
            employees.Remove(id);
        }

        public static void AddUnionMember(int id, Employee e)
        {
            unionMembers[id] = e;
        }

        public static Employee GetUnionMember(int id)
        {
            return unionMembers[id] as Employee;
        }

        public static void RemoveUnionMember(int memberId)
        {
            unionMembers.Remove(memberId);
        }

        public static ArrayList GetAllEmployeeIds()
        {
            return new ArrayList(employees.Keys);
        }

        public static IList getAllEmployees()
        {
            return new ArrayList(employees.Values);
        }

        public static void Clear()
        {
            employees.Clear();
            unionMembers.Clear();
        }
    }
}
