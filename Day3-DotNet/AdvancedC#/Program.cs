
using AdvancedC_;

public class MyClass
{
    public static void Main(string[] args)
    {
        //Students LINQ
        List<Student> students = new List<Student>();
        students.Add(new Student("Amit",10,450));
        students.Add(new Student("Aman", 12, 400));
        students.Add(new Student("Rahul", 10, 420));
        students.Add(new Student("Suman", 12, 300));
        students.Add(new Student("Priya", 11, 380));


        // filter with marks
        var filteredStudents = students.Where(student => student.Marks > 350).ToList();

        Console.WriteLine("Filter Student");
        foreach (var st in filteredStudents)
        {
            Console.WriteLine(st.Name+" "+st.Class+" "+st.Marks);
        }

        // sorting with marks
        var sortedStudents = students.OrderByDescending(student => student.Marks).ToList();

        Console.WriteLine("Sorted Student");
        foreach (var st in sortedStudents)
        {
            Console.WriteLine(st.Name + " " + st.Class + " " + st.Marks);
        }




        //Products LINQ
        List<Product> products = new List<Product>();
        products.Add(new Product("Pen", "Cello", 25));
        products.Add(new Product("Shirt", "PE", 2500));
        products.Add(new Product("Bike", "Yamaha", 300000));
        products.Add(new Product("Notebook", "ClassMate", 55));
        products.Add(new Product("Pent", "PE", 3000));

        // filter with price
        var filteredProducts = products.Where(product => product.Price < 5000).ToList();

        Console.WriteLine("Filter Product");
        foreach (var p in filteredProducts)
        {
            Console.WriteLine(p.Name + " " + p.Company + " " + p.Price);
        }

        

        // sorting with price
        var sortedProducts = products.OrderByDescending(product => product.Price).ToList();
        Console.WriteLine("Sorted Product");
        foreach (var p in filteredProducts)
        {
            Console.WriteLine(p.Name + " " + p.Company + " " + p.Price);
        }

    }


}