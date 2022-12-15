using csharptutorial;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //  DataTypes_1.DataTypesDemo();
        //  Operators_2.ArithmeticOperator();

        // UserInputs_3.UserInputDemo();
        /**
         Company comp1 = new Company();
         comp1.name = "ABC";
         comp1.code = "1";
         comp1.address = "JP Nagar";
         comp1.location = "Bengaluru";
         comp1.noofemp = 1000;
         Console.WriteLine("Name " + comp1.name);
         comp1.Information();

         Company comp2 = new Company();
         comp2.name = "PQR";
         comp2.code = "2";
         comp2.address = "White Field";
         comp2.location = "Bengaluru";
         comp2.noofemp = 3000;
         Console.WriteLine("Name " + comp2.name);
         comp2.Information();

         Company comp3 = new Company("3","XYZ","Nehru Road","Hubli",200);
         comp3.Information();
        **/
        Calculator cacl = new Calculator();
        int result =cacl.add(100, 150);

        Console.WriteLine("result of addition is " + result);

        result = cacl.multiply(10, 15);

        Console.WriteLine("result of multiplication is " + result);



        Console.ReadKey();
    }
}