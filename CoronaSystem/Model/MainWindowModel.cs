using Corona.BE;
using Corona.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaSystem.Model
{
    public class MainWindowModel
    {
        ImpBL impBL;
        public MainWindowModel()
        {
            impBL = new ImpBL();
        }
        public Admin getMyAdmin()
        {
            return impBL.getAdmin();
        }
    }
}
