namespace test1;

abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }



// VehicleBuilder: Builder
// Là một lớp trừu tượng định nghĩa các phương thức để 
// xây dựng các thành phần của một phương tiện (frame, engine, wheels, doors).
// Có một thuộc tính Vehicle để lưu trữ phương tiện đang được xây dựng.
