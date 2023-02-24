namespace Models;

public class Author 
{
    public int Id { get; set; }
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public IList<Book> Publications { set; get; }
    public string? Biography { set; get; }

    public Author() {}

    public Author(int id, string first, string last, IList<Book> pub)
    {
        this.Id = id;
        this.FirstName = first;
        this.LastName = last;
        this.Publications = pub;
    }
        public Author(string first, string last, IList<Book> pub, string bio)
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