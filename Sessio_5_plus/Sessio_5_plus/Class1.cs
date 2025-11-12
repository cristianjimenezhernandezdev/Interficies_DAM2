using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessio_5_plus
{
    internal class Class1
    {
        class Persona
        {
            public int Edat 
            { 
                get
                {
                    return edat;
                } 
                set 
                {
                    edat = value;
                } 
            }
            private int edat;
        }
        static void Main(string[]args)
        {
            Persona pepe=new Persona();
            pepe.Edat = 25;
        }
    }
}
