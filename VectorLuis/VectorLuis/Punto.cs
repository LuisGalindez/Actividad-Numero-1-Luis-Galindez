using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLuis
{
    public class Punto
    {
        private float _x;
        private float _y;

        public Punto()
        {
            _x = 0;
            _y = 0;
        }

        public Punto(float x, float y)
        {
            _x = x;
            _y = y;  

        }

        public float X
        {
            set { 
                
                _x = value;
            }
            
            get { 
                
                return _x; 
            
            }
        }

        public float Y
        {
            set
            {

                _y = value;
            }

            get
            {

                return _y;

            }

        }
        ~Punto()
        {
            Console.WriteLine("aqui se destrutuye");
        }
    }


}
