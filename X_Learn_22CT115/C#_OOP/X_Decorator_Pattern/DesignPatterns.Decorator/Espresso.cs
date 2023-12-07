namespace DesignPatterns.Decorator
// Expresso: ConcreteDecorator
// Là một loại cà phê cụ thể triển khai giao diện ICoffee.
// Cài đặt các thuộc tính Name và Amount.
// Cài đặt phương thức GetCost() để tính giá cả dựa trên số lượng cốc (Amount).

{
    internal class Espresso : ICoffee
    {
        public string Name { get; }
        public int Amount { get; }

        public Espresso(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }

        public decimal GetCost()
        {
            return Amount * 10;
        }

        public string GetDescription()
        {
            return Name;
        }
    }
}