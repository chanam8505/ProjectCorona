using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CoronaSystem.ViewModel
{
    class AddEmployeeVM: DependencyObject, INotifyPropertyChanged
    {
        AddEmployeeVM addEmployeeVM;

        public AddEmployeeVM()
        {
            addEmployeeVM = new AddEmployeeVM();
            

        }
        #region attribute
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }


        private string _city;
        public string CityAddress
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged("CityAddress");
            }
        }
        private string _streetAddress;
        public string StreetAddress
        {
            get { return _streetAddress; }
            set
            {
                _streetAddress = value;
                OnPropertyChanged("StreetAddress");
            }
        }

        private string _buildingAdress;
        public string BuildingAdress
        {
            get { return _buildingAdress; }
            set
            {
                _buildingAdress = value;
                OnPropertyChanged("BuildingAdress");
            }
        }

        private string _mailAddress;
        public string MailAddress
        {
            get { return _mailAddress; }
            set
            {
                _mailAddress = value;
                OnPropertyChanged("MailAddress");
            }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
        





        #endregion


        // INotifyPropertyChanged implementaion
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }

    }
}
