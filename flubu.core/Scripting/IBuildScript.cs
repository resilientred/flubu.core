namespace flubu.Scripting
{
    public interface IBuildScript
    {
        int Run(string[] args);

        string Name { get; }
    }
}