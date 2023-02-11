namespace Models;

public class Address
{
    public int Id { get; set; }
    public string StreetAddress { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; } = "Finland";

    public Address(string street, string zip, string city, string country) 
    {
        this.StreetAddress = street;
        this.ZipCode = zip;
        this.City = city;
        this.Country = country;
    }
}