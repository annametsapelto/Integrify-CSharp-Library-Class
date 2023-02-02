public class Category 
{
    public double CategoryNumber {get; init;}
    public string CategoryName {get; init;}

    public Category(double number, string name)
    {
        this.CategoryName = name;
        this.CategoryNumber = number;
    }
}