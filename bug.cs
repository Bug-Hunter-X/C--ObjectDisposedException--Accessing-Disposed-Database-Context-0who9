public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            var data = context.MyTable.FirstOrDefault();
        }

        // The following line will throw an exception because the context is already disposed.
        //This is an example, many other scenarios could exist
        var moreData = context.MyTable.FirstOrDefault(); 
    }
}