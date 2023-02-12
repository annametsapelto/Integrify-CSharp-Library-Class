namespace Models;

public class Category 
{
    public int Id { get; set; }
    public double CategoryNumber { get; init; }
    public string CategoryName { get; init; }

    public Category(int id, double number, string name)
    {
        this.Id = id;
        this.CategoryName = name;
        this.CategoryNumber = number;
    }
}