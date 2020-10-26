using System;
using System.Collections.Generic;
using System.Text;
using TheNextCar0._1.Model;

namespace TheNextCar0._1.Model
{
    class DoorController
    {
        private Door door;
        private OnDoorChanged callbackOndDoorChanged;

        public DoorController(OnDoorChanged callbackOndDoorChanged)
        {
            this.callbackOndDoorChanged = callbackOndDoorChanged;
            this.door = new Door();
        }

        public  void close()
        {
            this.door.close();
            callbackOndDoorChanged.onDoorOpenStateChanged("CLOSED", "door is closed");
        }

        public  void open()
        {
            this.door.open();
            this.callbackOndDoorChanged.onDoorOpenStateChanged("OPEN", "door is open");
        }

        public void activateLock()
        {
            this.door.activateLock();
            this.callbackOndDoorChanged.onDoorOpenStateChanged("LOCKED", "door is locked");
        }

        public void unlock()
        {
            this.door.unlock();
            this.callbackOndDoorChanged.onDoorOpenStateChanged("UNLOCKED", "door is unlocked");
        }


        public bool isclosed()
        {
            return this.door.isClosed();
        }

        public bool isLocked()
        {
            return this.door.isLocked();
        }


    }
    interface OnDoorChanged
    {
        void onLockDoorStateChanged(String value, string massage);
        void onDoorOpenStateChanged(string value, string massage);

    }
     
 
}