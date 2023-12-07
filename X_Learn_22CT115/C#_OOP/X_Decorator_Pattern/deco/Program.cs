using System;
// Program: Main Client
// Trong phương thức Main(), tạo một đối tượng BMWCar ban đầu.
// Tạo một DieselCarDecorator và PetrolCarDecorator, đưa vào BMWCar ban đầu làm tham số.
// Gọi phương thức ManufactureCar() để sản xuất Car với động cơ mới.
// Hiển thị thông tin về Car sau mỗi bước.

namespace deco;

    class Client
    {
        static void Main(string[] args)
        {
            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");

            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();

            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            
            Console.ReadKey();
        }
    }   
