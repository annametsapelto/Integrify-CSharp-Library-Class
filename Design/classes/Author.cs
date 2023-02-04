public class Author 
{
    public string FirstName;
    public string LastName;
    public Book[] Publications;
    public string? Biography;

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