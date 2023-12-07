using System;
// ICar: Component
// Định nghĩa một phương thức ManufactureCar(), mà mọi ConcreteComponent và ConcreteDecorator đều phải triển khai.

namespace deco;

    public interface ICar
    {
        ICar ManufactureCar();
    }   
