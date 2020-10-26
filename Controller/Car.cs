using System;
using System.Collections.Generic;
using System.Text;
using TheNextCar0._1.Model;

namespace TheNextCar0._1.Controller
{
    class Car
    {
        private DoorController doorController;
        private AccubatteryController accubatteryController;
        private OnCarEngineStateChanged callback;

        public Car(DoorController doorController, AccubatteryController accubatteryController, OnCarEngineStateChanged callback)
        {
            this.doorController = doorController;
            this.accubatteryController = accubatteryController;
            this.callback = callback;
        }
        private bool doorIsClosed()
        {
            return this.doorController.isclosed();
        }
        private bool doorIsLocked()
        {
            return this.doorController.isLocked();
        }

        private bool powerIsReady()
        {
            return this.accubatteryController.accubatryIsOn();
        }

        public void startEngine()
        {
            if (!doorIsClosed())
            {
                this.callback.onCarEngineStateChanged("STOPED", "close the door");
                return;
            }

            if (!doorIsLocked())
            {
                this.callback.onCarEngineStateChanged("STOPED", "lock the door");
                return;
            }
            if (!powerIsReady())
            {
                this.callback.onCarEngineStateChanged("STOPE", "no power available");
                return;
            }

            this.callback.onCarEngineStateChanged("STARTED", "Engine started");


        }




        public void toggleTheOpenDoorButton()
        {
            if (!doorIsClosed())
            {
                this.doorController.close();
            }

            else
            {
                this.doorController.open();
            }

        }
        public void toggleThelockDoorButton()
        {

            if (doorIsLocked())
            {
                this.doorController.activateLock();

            }

            else
            {
                this.doorController.unlock();
            }

        }
        public void togglepowerButton()
        {
            if (!powerIsReady())
            {
                this.accubatteryController.trunOn();
            }

            else
            {
                this.accubatteryController.trunOff();
            }
        
    }

    }
    interface OnCarEngineStateChanged
    {
        void onCarEngineStateChanged(string value, string message);
    }
}
