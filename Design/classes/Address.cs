public class Address
{
    public string StreetAddress {get; set;}
    public string ZipCode {get; set;}
    public string City {get; set;}
    public string Country {get; set;} = "Finland";

    public Address(string _street, string _zip, string _city, string _country) 
    {
        this.StreetAddress = _street;
        this.ZipCode = _zip;
        this.City = _city;
        this.Country = _country;
    }
}