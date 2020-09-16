using Corona.DAL;
using Corona.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.BL
{
    public class ImpBL
    {
        IDal myDal;
        public ImpBL()
        {
            myDal = new ImpDal();
        }

        #region admin
        public bool addAdmin(Admin admin)
        {
            return myDal.addAdmin(admin);
        }
        public bool updateAdmin(Admin admin)
        {
            return myDal.updateAdmin(admin);
        }
        public Admin getAdmin()
        {
            return myDal.getAdmin();
        }
        #endregion 

        #region employee
        public bool addEmployee(Employee employee)
        {
            return myDal.addEmployee(employee);
        }
        public bool updateEmployee(Employee employee)
        {
            return myDal.updateEmployee(employee);
        }
        public bool removeEmployee(int idEmployee)
        {
            return myDal.removeEmployee(idEmployee);
        }
        public Employee getEmployee(int idEmployee)
        {
            return myDal.getEmployee(idEmployee);
        }
        public List<Employee> getAllEmployee()
        {
            return myDal.getAllEmployee();
        }
        public List<Employee> getEmployeeByPredicate(Func<Employee, bool> predicate)
        {
            return myDal.getEmployeeByPredicate(predicate);
        }
        #endregion

        #region division
        public bool addDivision(Division division)
        {
            return myDal.addDivision(division);
        }
        public bool updateDivision(Division division)
        {
            return myDal.updateDivision(division);
        }
        public bool removeDivision(int idDivision)
        {
            return myDal.removeDivision(idDivision);
        }
        public Division getDivision(int idDivision)
        {
            return myDal.getDivision(idDivision);
        }
        public List<Division> getAllDivision()
        {
            return myDal.getAllDivision();
        }
        public List<Division> getDivisionByPredicate(Func<Division, bool> predicate)
        {
            return myDal.getDivisionByPredicate(predicate);
        }
        #endregion

        #region demand
        bool addDemand(Demand demand)
        {
            return myDal.addDemand(demand);
        }
        bool updateDemand(Demand demand)
        {
            return myDal.updateDemand(demand);
        }
        bool removeDemand(int code)
        {
            return myDal.removeDemand(code);
        }
        Demand getDemand(int code)
        {
            return myDal.getDemand(code);
        }
        List<Demand> getAllDemand()
        {
            return myDal.getAllDemand();
        }
        List<Demand> getDemandByPredicate(Func<Demand, bool> predicate)
        {
            return myDal.getDemandByPredicate(predicate);
        }
        #endregion
       
        public bool checkAdmin(string code)
        {
            return (getAdmin().code == code);            
        }
        public List<Demand> divisionByCity(string city)
        {
            return(from d in getAllDemand()
            where d.address.city==city
            select d).ToList();
        }
    }
}
