using System;
using System.Collections.Generic;
using System.Text;
using TheNextCar0._1.Model;

namespace TheNextCar0._1.Controller

{
    class AccubatteryController
    {
        private AccubatteryController accubattery;
        private OnPowerChanged callbackOnPowerChanged;
        private MainWindow mainWindow;

        public AccubatteryController(OnPowerChanged callbackOnPowerChanged)
        {
            this.callbackOnPowerChanged = callbackOnPowerChanged;
            this.accubattery = new Accubattery(12);
        }

        public AccubatteryController(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void trunOn()
        {
            this.accubattery.trunOn();
            this.callbackOnPowerChanged.OnPowerChangedStatus("ON","Power is On");
        }

        public void trunOff()
        {
            this.accubattery.trunOff();
            this.callbackOnPowerChanged.OnPowerChangedStatus("Off", "Power is Off");

        }

        public bool accubatryIsOn()
        {
            return this.accubatryIsOn();
        }

        public static implicit operator AccubatteryController(Accubattery v)
        {
            throw new NotImplementedException();
        }
    }
    interface OnPowerChanged
    {
        void OnPowerChangedStatus(string value, string message);
    }

}
