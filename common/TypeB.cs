using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    internal class TypeB : TypeA
    {
        public TypeB()
        {
            TypeA obj = new TypeA();

            ////before inheritance
            //obj.X   //invalid
            //obj.Y   //invalid
            //obj.Z = 0; //valid

            //after inhertance
            X = 0;  //valid  is private
            Y = 0;  //valid  is private
            Z = 0;  //valid  is internal
        }
    }
}
