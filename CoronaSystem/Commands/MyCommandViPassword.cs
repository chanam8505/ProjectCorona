using CoronaSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronaSystem.Commands
{
    class MyCommandViPassword : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)//האם אפשר תמיד ללחוץ על הכפתור
        {
            return true;  
        }

        public void Execute(object parameter)
        {
            try
            {
                if(parameter!=null)
                {
                    var s = parameter as string;

                }
                ((MainWindowVM)parameter).logIn();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
