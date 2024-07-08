using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment_16
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] names;
        long[] numbers;
        int size;
        #endregion

        #region Properties
        public int Size     //readonly property
        {
            get
            {
                return size;
            }
            private set
            {
                size = value;
            }
        }

        public long GetNumberOfPhoneBook(string Name)
        {
            if (names != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        }

        public void SetNumberOfPhoneBook(string Name, long newNumber)
        {
            if (names != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                    {
                        numbers[i] = newNumber;
                        return; //get out of set after reached to names
                        //break;    //get out from loop only
                    }
                }
            }
        }

        //indexer
        public long this[string name]
        {
            get
            {
                if (names != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (names != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = value;
                            return; //get out of set after reached to names
                                    //break;    //get out from loop only
                        }
                    }
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return $"Position: {index}\nName: {names[index]}\nNumber: {numbers[index]}";
            }
        }
        #endregion

        #region constructor
        public PhoneBook(int _size)
        {
            this.size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion

        #region AddPerson Method
        public void AddPerson(int position, string name, long number)
        {
            if (names is not null && numbers != null)
            {
                if (position >= 0 && position < size)
                {
                    numbers[position] = number;
                    names[position] = name;
                }
            }
        } 
        #endregion
    }
}
