namespace test1

{
    public class MainApp
    {
        public static void Main()
        {
            VehicleBuilder builder;
            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new AudiCarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}









// Main
// Tạo một đối tượng Shop.
// Tạo các đối tượng VehicleBuilder cụ thể (scooter, car, motor cycle).
// Gọi phương thức Construct của Shop để xây dựng từng loại phương tiện.
// Gọi phương thức Show để hiển thị thông tin về phương tiện đã xây dựng.