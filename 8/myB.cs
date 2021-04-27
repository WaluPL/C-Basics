using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAnamespace;
using MyUtilityNamespace;

//Kompozycja
namespace MyBnamespace
{
    class myB
    {
        public myB(myA x1, myA x0)
        {
            this.x1 = x1.Copy();
            this.x0 = x0.Copy();
        }
        public myA x1;
        public myA x0;
        private int cRc;
        private int Crc() { return 8* x1.CRC + x0.CRC; }
        private void SetCrc()
        {
            cRc = Crc();
        }
        public int CRC //accessors
        {

            get { SetCrc(); return cRc; }

        }
        public override string ToString()
        {
            return "([" + x1 + "]" + ",[" + x0 + "])----->" + CRC;
        }
    }
}
