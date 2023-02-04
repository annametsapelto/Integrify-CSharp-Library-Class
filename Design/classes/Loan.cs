public class Loan 
{
    public Loanable LoanedItem {get; init;}
    public DateTime LoanDate {get; init;}
    public DateTime DueDate {get; set;}

    public Loan (Loanable loaned, DateTime loanDate, DateTime duedate)
    {
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