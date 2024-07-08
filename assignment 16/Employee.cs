using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_16
{
	enum Gender
	{
		Male, Female
	}

    enum SecurityPrivilege
    {
        Guest, Developer, Secretary, DBA
    }

    internal class Employee
	{
		#region Attributes
		private int id;
		private string name;
		private int securityLevel;
		private double salary;
		private DateTime hireDate;
		private Gender gender;
		private HiringDate? date;
		private SecurityPrivilege privilege;
        #endregion

        #region Properties
        public SecurityPrivilege Privilege
        {
            get { return privilege; }
            set { privilege = value; }
        }

        public HiringDate Date
        {
            get { return date; }
            set { date = value; }
        }
        public Gender Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public DateTime HireDate
		{
			get { return hireDate; }
			set { hireDate = value; }
		}

		public double Salary
		{
			get { return salary; }
			set 
			{
                if (salary > 0)
                {
                    try
                    {
                        salary = value;
                    }
                    catch (Exception e)
                    {

                        string message = e.Message;
                    }
                }
            }
		}

		public int SecurityLevel
		{
			get { return securityLevel; }
			set
			{
                if (securityLevel >= 0)
                {
                    try
                    {
                        securityLevel = value;
                    }
                    catch (Exception e)
                    {

                        string message = e.Message;
                    }
                }
            }
		}

		public string Name
		{
			get { return name; }
			set 
			{
                if (name != null)
                {
					try
					{
						name = value;
					}
					catch (Exception e)
					{
						string message = e.Message;
					}
                }
            }
		}

		public int Id
		{
			get { return id; }
			set 
			{
                if (id >= 0)
                {
					try
					{
						id = value;
					}
					catch (Exception e)
					{
                        string message = e.Message;
					}
                }
            }
		}
        #endregion

        #region Constructor
        public Employee(int _id, string _name, int _securityLevel, double _salary, HiringDate _date, Gender _gender, SecurityPrivilege _Privilege)
        {
            id = _id;
			name = _name;
			securityLevel = _securityLevel;
			salary = _salary;
			date = _date;
			gender = _gender;
			privilege = _Privilege;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"ID: {id} \nName: {name} \nSecurityLevel: {securityLevel} \nSecurityPrivilege: {privilege} \nSalary: {salary.ToString("C")} \nHireDate: {date} \nGender: {gender}";
        }
        #endregion
    }
}
