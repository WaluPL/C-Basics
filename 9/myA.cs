using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtilityNamespace;
namespace MyAnamespace
{
    class myA
    {
        protected int x0;
        protected int x1;
        

        public myA(int x1=0, int x0=0)
        {
            this.x1 = x1;
            this.x0 = x0;
        }
        public string MyString()
        {
            return X1 + ", " + X0;
        }
        public int X0
        {
            get { return x0; }
        }
        public int X1
        {
            get { return x1; }
        }
    }

    }