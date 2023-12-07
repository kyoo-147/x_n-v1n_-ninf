using DesignPatterns.Decorator;
// Main
// Tạo một đối tượng Espresso và hiển thị hóa đơn của nó.
// Tạo một đối tượng MilkCoffee, đưa vào Espresso làm tham số, và hiển thị hóa đơn của nó.
// Hóa đơn được hiển thị bao gồm tên của cà phê và giá cả, sau khi áp dụng Decorator.

    ICoffee espresso = new Espresso("Cà Phê Espresso", 3);
    espresso.DisplayReceipt();

    ICoffee milkEspresso = new MilkCoffee(espresso);
    milkEspresso.DisplayReceipt();

    Console.ReadKey();
