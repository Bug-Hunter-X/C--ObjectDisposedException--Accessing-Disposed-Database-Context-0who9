public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object is handled properly here
        using (var context = new MyDbContext())
        {
            var data = context.MyTable.FirstOrDefault();
            // Perform all database operations within this block
            // ... more database operations using the context ...
        }

        // The context is disposed here, accessing it later would cause an exception
        // All operations on the context must be within the using statement
    }
}