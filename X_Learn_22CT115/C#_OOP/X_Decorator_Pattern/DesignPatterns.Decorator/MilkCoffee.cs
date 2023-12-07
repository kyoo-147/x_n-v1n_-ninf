namespace DesignPatterns.Decorator
// MilkCoffee: ConcreteDecorator
// Là một lớp decorator cụ thể triển khai CoffeeDecorator.
// Mở rộng chức năng của CoffeeDecorator bằng cách thêm mô tả "with milk" vào GetDescription().
// Thay đổi giá cả của cà phê bằng cách cộng thêm 10% của số lượng cốc vào GetCost().

{
    internal sealed class MilkCoffee : CoffeeDecorator
    {
        public MilkCoffee(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " với Sữa";
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 0.1M * base.Amount;
        }
    }
}
