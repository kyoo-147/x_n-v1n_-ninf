namespace DesignPatterns.Decorator
// CoffeeDecorator: Decorator
// Là một lớp trừu tượng triển khai giao diện ICoffee.
// Chứa một tham chiếu đến đối tượng ICoffee gốc, được gọi là _coffee.
// Cài đặt các phương thức của ICoffee, gọi lại từ đối tượng _coffee.

{
    internal abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            this._coffee = coffee;
        }

        public virtual string Name => this._coffee.Name;
        public int Amount => this._coffee.Amount;


        public virtual decimal GetCost()
        {
            return _coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }
    }
}
