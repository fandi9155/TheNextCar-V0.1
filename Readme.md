# The Next Car
Aplikasi ini bisa berfungsi untuk perangakat dalam mobil 

# Scope & Fungsionalities

- User dapat membuka pintu mobil
- user dapat menyalakan mesin
- user dapat mematikan mesin
- user dapat menutup pintu mobil
- user dapat mengunci pintu 

# How Does it wroks?

Di awali dengan main windows
```  Csharp
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
```

# Cara kerjanya
kita bisa menekan tombol start untuk menghidup 
kan sebuah modnil dengan syarat pintu mobil 
sudah tertutup.
