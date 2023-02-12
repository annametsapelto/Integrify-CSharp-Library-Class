namespace Models;

public class Loan 
{
    public int Id { get; set; }
    public Loanable LoanedItem { get; init; }
    public DateTime LoanDate { get; init; }
    public DateTime DueDate { get; set; }

    public Loan (int id, Loanable loaned, DateTime loanDate, DateTime duedate)
    {
        this.Id = id;
        this.LoanedItem = loaned;
        this.LoanDate = loanDate;
        this.DueDate = duedate;
    }

    public void RenewLoan() 
    {
        DateTime RenewedDueDate = this.DueDate.AddMonths(1);
        this.DueDate = RenewedDueDate;
    }
}