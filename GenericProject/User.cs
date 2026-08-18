namespace GenericProject;

public class User<T>
{
    public T id { get; set; }
    public string Name { get; set; }
    public string email { get; set; }
}