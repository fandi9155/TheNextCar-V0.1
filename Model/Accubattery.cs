using System;
using System.Collections.Generic;
using System.Text;

namespace TheNextCar0._1.Model
{
    class Accubattery
    {
        private int voltage;
        private bool stateOn = false;

        public Accubattery(int voltage)
        {
            this.voltage = voltage;
        }

        public void trunOn()
        {
            this.stateOn = true;
        }

        public void trunOff()
        {
            this.stateOn = false;
        }

        public bool isOn()
        {
            return this.stateOn;
        }
    }
}
