using System;
// CarDecorator: Decorator
// Là một lớp trừu tượng triển khai giao diện ICar và chứa một tham chiếu đến ICar (hoặc ConcreteComponent).
// Cài đặt phương thức ManufactureCar() mà mọi ConcreteDecorator đều phải triển khai. 

namespace deco;

    public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }   
