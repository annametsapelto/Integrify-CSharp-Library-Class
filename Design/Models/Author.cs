namespace Models;

public class Author 
{
    public int Id;
    public string FirstName {set; get;}
    public string LastName {set; get;}
    public Book[] Publications {set; get;}
    public string? Biography {set; get;}

    public Author(string first, string last, Book[] pub)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Publications = pub;
    }
        public Author(string first, string last, Book[] pub, string bio)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Publications = pub;
        this.Biography = bio;
    }
    public string GetAuthorFullName()
    {
        string FullName = this.LastName + ", " + this.FirstName;
        return FullName;
    }
}