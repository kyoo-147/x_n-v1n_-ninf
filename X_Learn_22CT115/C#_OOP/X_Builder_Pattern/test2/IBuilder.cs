namespace test2;

public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }







// IBuilder Interface:


// IBuilder: Builder Interface: chỉ định các phương thức để tạo các phần khác nhau Product object 
// Định nghĩa các phương thức cần thiết để xây dựng các phần khác nhau của đối tượng Product.

// IBuilder là một interface, nó định nghĩa các phương thức cần thiết để xây dựng các phần khác nhau của một đối tượng Product.
// Interface này đóng vai trò như một hợp đồng (contract) giữa các lớp cụ thể của Builder và Product.

// Phương thức BuildPartA():
// Phương thức này đại diện cho quá trình xây dựng "Phần A" của đối tượng Product.
// Các lớp cụ thể của Builder sẽ cung cấp triển khai cụ thể cho việc xây dựng phần này.

// Phương thức BuildPartB():
// Tương tự như BuildPartA(), nhưng dành cho việc xây dựng "Phần B" của đối tượng Product.
// Phương thức BuildPartC():
// Tương tự như BuildPartA() và BuildPartB(), nhưng dành cho việc xây dựng "Phần C" của đối tượng Product.

// Interface này chính là một phần quan trọng của mô hình thiết kế "Builder Pattern". 

// Các lớp cụ thể của Builder sẽ triển khai các phương thức này để xây dựng các phần khác nhau của đối tượng Product. 

// Sau đó, Director (nếu có) sẽ sử dụng các phương thức này để hướng dẫn quá trình xây dựng đối tượng hoàn chỉnh.



