using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAnamespace;
namespace MyBnamespace

{
    class myB:myA
    {
        private int x2;
        private new int x1; 
        private new int x0;

        public myB(int x1, int x0):base(x1, x0) //get fields from constructor base class myA
        {
            this.x2 = base.x1 + base.x0;
            this.x1 = base.x1 - base.x0;
            this.x0 = base.x0 - base.x1;
        }
        public new string MyString()
        {
            return this.X4+ ", " + this.X3+ ", " + this.X2+ ", " + base.MyString();
        }
        public int X4 //get x2 from current class
        {
            get { this.x2 = base.X1 + base.X0;
                return x2;
            }
            set
            {
                this.x2 = value;
                base.x1 = this.x2 - base.x0;
            }
        }
        public int X3 //get x1 from current class
        {
            get
            {
                this.x1 = base.X1 - base.X0;
                return x1;
            }
            set
            {
                this.x1 = value;
                base.x1 = this.x1 + base.X0;
            }
        }
        public int X2 //get x0 from current class
        {
            get
            {
                this.x0 = base.X0 - base.X1;
                return x0;
            }
            set
            {
                this.x0 = value;
                base.x0 = this.x0 + base.X1;
            }
        }

    }
}
