using Corona.BE;
using CoronaSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CoronaSystem.Commands;
using CoronaSystem.View;
using System.ComponentModel;
using System.Windows.Controls;

namespace CoronaSystem.ViewModel
{
    class MainWindowVM : DependencyObject, INotifyPropertyChanged
    {
        MainWindowModel mainWindowModel;
        public ICommand viPassword { get; set; }



        public MainWindowVM()
        {
            mainWindowModel = new MainWindowModel();
            viPassword = new MyCommandViPassword();

        }
        private string _passwordtextBox;
        public string PasswordtextBox { get { return _passwordtextBox; }
            set
            { _passwordtextBox = value;
                        OnPropertyChanged("PasswordtextBox"); } }

        private string _massagePassword;
        public string MassagePassword
        {
            get { return _massagePassword; }
            set
            {
                _massagePassword = value;
                OnPropertyChanged("MassagePassword");
            }
        }


        public void logIn()
        {
            Admin admin = mainWindowModel.getMyAdmin();
            if(PasswordtextBox.ToString()==admin.code)
            {
                Window MyMenu = new menuWindow();
                MyMenu.Show();
            }
            else
            {
                PasswordtextBox = "";
                MassagePassword = "please try again!";

            }
            

        }

        // INotifyPropertyChanged implementaion
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }


    }
}
