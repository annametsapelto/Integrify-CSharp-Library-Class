namespace Models;

public class Magazine: Loanable
{
    public int Id { get; set; }
    public string IssueNumber { get; init; }
    public string Editor { get; init; }
    public Magazine(string issue, string editor, string title, int year, int code, Category category, bool reservations, Availability status)
        :base (title, year, code, category, reservations, status) 
        {
            this.IssueNumber = issue;
            this.Editor = editor;
        }
}