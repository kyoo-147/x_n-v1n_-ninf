namespace DesignPatterns.Decorator
// // ICoffe: Component
// Giao diện này định nghĩa các thuộc tính và phương thức cơ bản cho một đối tượng cà phê.
// Các thuộc tính bao gồm Name (tên của loại cà phê) và Amount (số lượng cốc).
// Các phương thức bao gồm GetDescription() (lấy mô tả của cà phê) và GetCost() (lấy giá cả của cà phê).

{
    public interface ICoffee
    {
        abstract string Name { get; }
        abstract int Amount { get; }

        string GetDescription();
        decimal GetCost();
        virtual void DisplayReceipt()
            => Console.WriteLine($"{GetDescription()}: {GetCost():$#.00}");
    }
}
