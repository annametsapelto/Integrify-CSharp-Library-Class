namespace Models;

public class LibrarySystem
{
    public Account[] Accounts {set; get;}
    public Loanable[] Loanables {set; get;}
    public Author[] Authors {set; get;}
    public Employee[] Employees {set; get;}
    public Category[] Categories {set; get;}
    public Reservation[] Reservations {get; set;}
    public Loan[] Loans {get; set;}

    public LibrarySystem(Account[] accounts, Loanable[] loanables, Author[] authors, Employee[] employees, Category[] categories, Reservation[] reservations, Loan[] loans)
    {
        this.Accounts = accounts;
        this.Loanables = loanables;
        this.Authors = authors;
        this.Employees = employees;
        this.Categories = categories;
        this.Reservations = reservations;
        this.Loans = loans;
    }
}