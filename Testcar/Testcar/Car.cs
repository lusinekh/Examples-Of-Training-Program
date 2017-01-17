using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testcar
{
    class Car
   
    {
         public string Name { get; set; }
        public int Speed { set; get; }
        private readonly int maxSpeed;
       
        public bool IsCrush { get; set; }
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }

        }
        
       
        private EventHandler CarCrash;
        private EventHandler Dangerous;

        public void RegisterCarCrush(EventHandler ceh)
        {
            CarCrash += ceh;
        }

        public void UnRegisterCarCrush(EventHandler ceh)
        {
            CarCrash -= ceh;
        }

        public void RegisterDangerous(EventHandler  ceh)
        {
            Dangerous += ceh;
        }

        public void UnRegisterDangerious(EventHandler ceh)
        {
            Dangerous -= ceh;
        }

        public void Accelerate(int d)
        {
            if (IsCrush)
            {
                return;
            }
            Speed += d;
            if (Speed >= maxSpeed)
            {
                IsCrush = true;
                if (CarCrash != null)
                {

                    
                    CarCrash(this,EventArgs.Empty);
                     
                }  

            }



            else if (Speed + 10 > maxSpeed)
            {
                if (Dangerous != null)
                {
                    Dangerous(this, EventArgs.Empty);
                }
                // hnaravorutyun tal tirojy ardzaganqelu
            }
            else
            {
                Console.WriteLine(this);
            }
            
        }

        public Car(string nm = "Ford", int sp = 60, int mxSp = 250)
        {
            Name = nm;
            Speed = sp;
            maxSpeed = mxSp;
        }
        public override string ToString()
        {
            return Name + " " + Speed + " " + MaxSpeed;
        }

       

    }
}

