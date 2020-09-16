using Corona.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var ctx = new CoronaContext())
            {
                //var emp = new Employee(456,"nem","es","089789778","cfvhj","Yavne","Ben","78");
                //ctx.EmployeeList.Add(emp);
                //ctx.SaveChanges();
                //var adm = new Admin(3456,"456456","Yosi","Peleg","089765645","yoss@gmail.com");
                //ctx.MyAdmin.Add(adm);
                //ctx.SaveChanges();
                
                    var admin = ctx.MyAdmin.FirstOrDefault();
                Console.WriteLine(admin);
                    
                



            }

        }
    }
}
