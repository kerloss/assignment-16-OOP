using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using common;

namespace assignment_16
{
    internal class TypeB : TypeA
    {
        public TypeB()
        {
            TypeA obj = new TypeA();

            ////before inheritance
            //obj.X   //invalid
            //obj.Y   //invalid
            //obj.Z   //invalid

            //after inheritance
            //X       //invalid   not inherited
            //Y = 0;  //valid     is private
            //Z = 0;  //valid     is private
        }
    }
}
