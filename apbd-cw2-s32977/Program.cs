// See https://aka.ms/new-console-template for more information

using apbd_cw2_s32977;

DataBase dataBase = new DataBase();
Service service = new Service(dataBase);

Student janek = new Student(1 ,"Jan", "Kowalski", "s123456");
Student ala = new Student(2 ,"Ala", "Kowalska", "s654321");

Employee tomasz = new Employee(3, "Tomasz", "Nowak", "111222333");
Employee edward = new Employee(4, "Edward", "Nowakowski", "444555666");


dataBase.addUser(janek);
dataBase.addUser(ala);
dataBase.addUser(tomasz);
dataBase.addUser(edward);


Laptop laptop1 = new Laptop(1, true, "Dell", 100, 16, 1.2);
Laptop laptop2 = new Laptop(2, true, "Lenovo", 70, 8, 2.1);

Projector projector1 = new Projector(3, true, "BenQ", 80,  3200, "1920x1080");
Projector projector2 = new Projector(4, true, "Samsung", 50,  2100, "1280x800");

Camera camera1 = new Camera(5, true, "Canon", 90, 500, 2.1);
Camera camera2 = new Camera(6, true, "Sony", 120, 800, 5.2);

dataBase.addSprzet(laptop1);
dataBase.addSprzet(laptop2);
dataBase.addSprzet(projector1);
dataBase.addSprzet(projector2);
dataBase.addSprzet(camera1);
dataBase.addSprzet(camera2);

Rental rental1 = service.RentEquipment(janek, laptop1, DateTime.Now, new DateTime(2026, 5, 1));

Rental rental2 = service.RentEquipment(janek, laptop2, DateTime.Now, new DateTime(2026, 5, 3));

service.RentEquipment(janek, camera1, DateTime.Now, new DateTime(2026, 5, 4));

service.RentEquipment(ala, laptop1, DateTime.Now, new DateTime(2026, 5, 5));

service.AvailableEquipment();

service.ReturnEquipment(rental1, DateTime.Now);
Console.WriteLine("Kara: " + rental1.penalty);


service.ReturnEquipment(rental2, DateTime.Now.AddMonths(3));
Console.WriteLine("Kara: " + rental2.penalty);


service.GenerateRaport();



