﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Employee : INotifyPropertyChanged
    {
        private int _employeeID;
        private int _employeeAge;
        private string _Name;        
        private DateTime _BirthDate;
        private string _MaritalStatus;
        private double _SickLeaveHours;
        private string _Gender;        
        private double? _Salary;      

        public int EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        public int EmployeeAge
        {
            get
            {
                return _employeeAge;
            }
            set
            {
                _employeeAge = value;
                this.RaisePropertyChanged("EmployeeAge");
            }
        }

        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.RaisePropertyChanged("Name");
            }
        }
       
        public DateTime BirthDate
        {
            get { return this._BirthDate; }
            set
            {
                this._BirthDate = value;
                this.RaisePropertyChanged("BirthDate");
            }
        }

        public string MaritalStatus
        {
            get { return this._MaritalStatus; }
            set
            {
                this._MaritalStatus = value;
                this.RaisePropertyChanged("MaritalStatus");
            }
        }

        public string Gender
        {
            get { return this._Gender; }
            set
            {
                this._Gender = value;
                this.RaisePropertyChanged("Gender");
            }
        }
      
        public double? Salary
        {
            get { return this._Salary; }
            set
            {
                this._Salary = value;
                this.RaisePropertyChanged("Salary");
            }
        }

        public double SickLeaveHours
        {
            get { return this._SickLeaveHours; }
            set
            {
                this._SickLeaveHours = value;
                this.RaisePropertyChanged("SickLeaveHours");
            }
        }
        public Employee()
        { }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
