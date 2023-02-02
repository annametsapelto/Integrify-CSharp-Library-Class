public class Magazine: Loanable
{
    public string IssueNumber {get; init;}
    public string Editor {get; init;}
    public Magazine(string issue, string editor, string title, int year, int code, Category category, bool reservations)
        :base (title, year, code, category, reservations) 
        {
            this.IssueNumber = issue;
            this.Editor = editor;
        }
}