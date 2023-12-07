namespace test2

{
    class Program
    {
        
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Sản phẩm cơ bản tiêu chuẩn:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Sản phẩm tiêu chuẩn đầy đủ tính năng:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Sản phẩm tùy chỉnh:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}





// Main
// Là hàm chính của chương trình (entry point).
// Tạo một đối tượng Director.
// Tạo một đối tượng ConcreteBuilder.
// Gán builder cho director.
// Sử dụng director để xây dựng các loại đối tượng Product khác nhau và hiển thị thông tin về chúng. 

// Main: Client code tạo một builder object, chuyển cho Director,và bắt đầu chạy, kết quả sẽ được truy xuất từ builder object
// Tạo một đối tượng Director.
// Tạo một đối tượng ConcreteBuilder.
// Gán builder cho director.
// Sử dụng director để xây dựng sản phẩm cơ bản tiêu chuẩn.
// Sử dụng director để xây dựng sản phẩm tiêu chuẩn đầy đủ tính năng.
// Xây dựng một sản phẩm tùy chỉnh bằng cách sử dụng các phương thức của builder.

// Program Class:
// Program là hàm chính của chương trình (entry point).
// Tạo một đối tượng Director để quản lý quá trình xây dựng đối tượng Product.
// Tạo một đối tượng ConcreteBuilder để thực hiện các bước xây dựng cụ thể.
// Gán đối tượng ConcreteBuilder cho Director.
// Sử dụng Director để hướng dẫn xây dựng các loại đối tượng Product khác nhau và hiển thị thông tin về chúng.