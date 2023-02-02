public class Loan 
{
    public Loanable LoanedItem {get; init;}
    public DateTime LoanDate {get; init;}
    public DateTime DueDate {get; init;}

    public Loan (Loanable loaned, DateTime loanDate, DateTime duedate)
    {
        this.LoanedItem = loaned;
        this.LoanDate = loanDate;
        this.DueDate = duedate;
    }
}