
public class FileResource: Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine("File opened");
    }
    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine("File closed");
    }
    public void Dispose()
    {
      Close();
      Console.WriteLine("File disposed");
    }
}