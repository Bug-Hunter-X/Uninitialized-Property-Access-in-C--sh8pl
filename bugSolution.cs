public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Explicitly initialize to 0

    public void MyMethod()
    {
        // Now MyProperty is initialized before access.
        Console.WriteLine(MyProperty); 
    }
    public void MyMethod2()
    {
        MyProperty = 5; //Explicitly assign a value.
        Console.WriteLine(MyProperty);
    }
}