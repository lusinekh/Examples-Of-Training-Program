using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int MD(int a, int b);
    // public delegate void CarEventHandler(string s);

  
    class Car
    {
        private bool isCrash;
        private EventHandler carCrash;
        private EventHandler carDanger;
        public void RegisterCarCrash(EventHandler cch)
        {
            carCrash += cch;
        }
        public void UnRegisterCarCrash(EventHandler cch)
        {
            carCrash -= cch;
        }
        //======================================================
        public void RegisterDanger(EventHandler cch)
        {
            carDanger += cch;
        }
        public void UnRegisterDanger(EventHandler cch)
        {
            carDanger -= cch;
        }

        public bool IsCrash
        {
            get { return isCrash; }
            set { isCrash = value; }
        }


        public string Name { get; set; }
        public int Speed { get; set; }
        private readonly int maxSpeed;

        public void accelerate(int a)
        {
            if (IsCrash)
            {
                return;
            }
            else
            {
                Speed += a;
            }
            if (Speed >= MaxSpeed)
            {
                IsCrash = true;
                if (carCrash != null)
                {
                    carCrash(this,EventArgs.Empty);
                }
                
                // hnaravorutyun tal tiroje ardzaganqel
            }
            else if (Speed + 10 > MaxSpeed)
            {
                if (carDanger !=null)
                {
                    carDanger(this, EventArgs.Empty);                    
                }
                // hnaravorutyun tal tiroje ardzaganqel
            }
            else
            {
                Console.WriteLine(this);
            }
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }
        }
   
        public Car(string nm = "Ford", int sp = 50, int mxSp = 250)
        {
            Name = nm;
            sp = Speed;
            maxSpeed = mxSp;
        }
     
        public override string ToString()
        {
            return Name + "\t" + Speed + "\t" + maxSpeed;
        }
    }
}
