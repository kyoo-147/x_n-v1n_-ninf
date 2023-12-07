using System;
// ConcreteDecorator
// Là các lớp cụ thể triển khai CarDecorator.
// Mỗi lớp này mở rộng chức năng của CarDecorator bằng cách thêm một Engine vào Car.
// Cài đặt phương thức AddEngine() để thêm động cơ và hiển thị thông báo.

namespace deco;

    public class DieselCarDecorator:CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Dong_Co = "Động Cơ Diesel";
                Console.WriteLine("DieselCarDecorator đã thêm Động cơ Diesel vào Ô tô : " + car);
            }
        }
    }
    
    class PetrolCarDecorator:CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Dong_Co = "Động Cơ Xăng";
                Console.WriteLine("PetrolCarDecorator đã thêm Động cơ xăng vào Xe : " + car);
            }
        }
    }

