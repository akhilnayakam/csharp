//using System;

//class Employee
//{
//    public string Name { set; get; }
//    public double Salary { set; get; }

//    public Employee(string name, double salary)
//    {
//        Name = name;
//        Salary = salary;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Name: {Name}, Salary: {Salary}");
//    }
//}

//class Manager : Employee
//{
//    public double Bonus { set; get; }

//    public Manager(string name, double salary, double bonus) : base(name, salary)
//    {
//        Bonus = bonus;
//    }

//    public void DisplayManagerInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Bonus: {Bonus}");
//    }
//}

//class SecProgram
//{
//    static void Main()
//    {
//        Manager mgr = new Manager("Alice", 80000, 10000);
//        Console.WriteLine("Manager info");
//        mgr.DisplayManagerInfo();
//    }
//}


//-----------------------------------------------------------------

//using System;

//abstract class Animal
//{
//    public abstract void MakeSound();
//}
//class Dog : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Bow bow");
//    }
//}

//class Cat : Animal 
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Meow meow");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal dog = new Dog();
//        Animal cat = new Cat();
//        Console.WriteLine("Dog Sounds:");
//        dog.MakeSound();
//        Console.WriteLine("Cat Sounds:");
//        cat.MakeSound();
//    }
//}

//-------------------------------------------------------

//using System;

//class Vehicle
//{
//    public virtual void StartEngine()
//    {
//        Console.WriteLine("*** Vehicle Engine Started ***");
//    }
//}

//class Car : Vehicle
//{
//    public override void StartEngine()
//    {
//        Console.WriteLine("*** Car Engine Started ***");
//    }
//}

//class MotorCycle : Vehicle
//{
//    public override void StartEngine()
//    {
//        Console.WriteLine("*** MotorCycle Engine Started ***");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Vehicle myCar = new Car();
//        Vehicle myMototrCycle = new MotorCycle();
//        Console.WriteLine("Car Engine:");
//        myCar.StartEngine();
//        Console.WriteLine("MotorCycle Engine:");
//        myMototrCycle.StartEngine();
//    }
//}

//-----------------------------------------------------------------

//using System;

//class Book
//{
//    public String Title { set; private get; }
//    public String Author { set; private get; }
//    public String ISBN { set; private get; }
//    public bool IsAvailable { get; private set; }

//    public Book(string title, string author, string isbn)
//    {
//        Title = title;
//        Author = author;
//        ISBN = isbn;
//        IsAvailable = true;
//    }
//    public void BorrowBook()
//    {
//        if (IsAvailable)
//        {
//            IsAvailable = true;
//            Console.WriteLine($"{Title} book has borrowed");
//        }
//        else
//        {
//            Console.WriteLine($"{Title} book is not available, already borrowed");

//        }
//    }
//    public void ReturnBook()
//    {
//        if (!IsAvailable)
//        {
//            IsAvailable = true;
//            Console.WriteLine($"{Title} book is already available");
//        }
//        else
//        {
//            Console.WriteLine($"{Title} book has been returned");
//        }
//    }
//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, IsAvailable: {IsAvailable}");
//    }
//}

//    class program
//    {
//        static void Main()
//        {
//            Book book1 = new Book("The Alchemist", "Paulo Coelho", "9780062315007");
//            Book book2 = new Book("The Da Vinci Code", "Dan Brown", "9780307474278");
//            Console.WriteLine("Library books:");

//            book1.DisplayInfo();
//            book2.DisplayInfo();

//            Console.WriteLine("Borrowing books:");
//            book1.BorrowBook();
//            book2.BorrowBook();

//            Console.WriteLine("Returning books:");
//            book1.ReturnBook();
//            book2.ReturnBook();

//            Console.WriteLine("Books status:");
//            book1.DisplayInfo();
//            book2.DisplayInfo();
//        }
//    }

//-----------------------------------------------------

//using System;

//class Products
//{
//    public string Name { set; private get; }
//    public decimal Price { set; private get; }
//    public int Stock { set; private get; }

//    public Products(string name, decimal price, int stock)
//    {
//        Name = name;
//        Price = price;
//        Stock = stock;
//    }

//    public void ReduceStock(int quantity)
//    {
//        if (quantity <= Stock)
//        {
//            Stock -= quantity;
//        }
//        else
//        {
//            Console.WriteLine("Not Enough Stock available");
//        }
//    }

//    public class ShoppingCart
//    {
//        private List<Products> cartItems;

//        public ShoppingCart()
//        {
//            cartItems = new List<Products>();
//        }

//        public void AddItem(Products product)
//        {
//            if (product.Stock > 0)
//            {
//                cartItems.Add(product);
//                product.ReduceStock(1);
//            }
//            else
//            {
//                Console.WriteLine("OUT OF STOCK!!!");
//            }
//        }
//        public void RemoveItem(Products product)
//        {
//            if (cartItems.Contains(product))
//            {
//                cartItems.Remove(product);
//                Console.WriteLine($"{product.Name} removed from cart");
//            }
//            else
//            {
//                Console.WriteLine("Item not found in cart");
//            }
//        }
//    public decimal Calculate()
//        {
//            decimal total = 0;
//            foreach(var item in cartItems)
//            {
//                total += item.Price;
//            }
//            return total;
//        }
//        public void DisplayCart()
//        {
//            Console.WriteLine("Cart Items:");
//            foreach (var item in cartItems)
//            {
//                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Stock: {item.Stock}");
//            }
//            Console.WriteLine($"Total: ${Calculate()}");
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Products product1 = new Products("Laptop", 800, 10);
//            Products product2 = new Products("Mobile", 500, 20);
//            Products product3 = new Products("Tablet", 300, 15);
//            ShoppingCart cart = new ShoppingCart();
//            cart.AddItem(product1);
//            cart.AddItem(product2);
//            cart.AddItem(product3);
//            cart.DisplayCart();

//            cart.RemoveItem(product1);
//            cart.DisplayCart();

//            cart.RemoveItem(product2);
//            cart.DisplayCart();
//        }
//    }
//}


//--------------------------------------------------------------------------------------------------

