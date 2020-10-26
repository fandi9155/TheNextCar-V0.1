using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheNextCar0._1.Controller;
using TheNextCar0._1.Model;

namespace TheNextCar0._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, OnPowerChanged, OnDoorChanged, OnCarEngineStateChanged
    {
        private Car nextCar;
        private object message;

        public MainWindow()
        {
            InitializeComponent();
            AccubatteryController accubatteryController = new AccubatteryController(this);
            DoorController doorController = new DoorController(this);

            nextCar = new Car(doorController, accubatteryController, this);
        }

        private void OnStartButtonCliked(object sender, RoutedEventArgs e)
        {
            this.nextCar.startEngine();

        }

        private void OnDoorOpenButtonCliked(object sender, RoutedEventArgs e)
        {
            this.nextCar.togglepowerButton();
        
        }

        private void OnLockDoorButtonCliked(object sender, RoutedEventArgs e)
        {
            this.nextCar.toggleThelockDoorButton();
        }

        private void OnAccuButtonCliked(object sender, RoutedEventArgs e)
        {
            this.nextCar.togglepowerButton();
        }

        public void OnPowerChangedStatus(string value, string message)
        {
            AccuState.Content = message;
            AccuButtom.Content = value;
        }

        public void onLockDoorStateChanged(string value, string massage)
        {
            LockDoorState.Content = message;
            LockedDoorButton.Content = value;
        }

        public void onDoorOpenStateChanged(string value, string massage)
        {
            DoorOpenStaete.Content = message;
            DoorOpenButton.Content = value;
        }

        public void onCarEngineStateChanged(string value, string message)
        {
            Status.Content = message;
            startButtom.Content = value;


        }
    }
}
