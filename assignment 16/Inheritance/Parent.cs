using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_16.Inheritance
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructor
        public Parent(int _x , int _y)
        {
            this.X = _x;
            this.Y = _y;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"X: {X} , Y: {Y}";
        }
        public int Product()
        {
            return X * Y ;
        }
        #endregion
    }
}
