using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_16.Inheritance
{
    internal class Child : Parent
    {
        #region Attributes
        public int Z { get; set; }
        #endregion

        #region constructor
        public Child(int _x, int _y, int _z) : base(_x,_y)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
        #endregion

        #region Method
        public new int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"X: {X} , Y: {Y} , Z: {Z}";
        }
        #endregion
    }
}
