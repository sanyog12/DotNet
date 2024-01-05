namespace BOL;

public class Employee
{
    public int Id;
    public string Dates;
    public string WorkDesc;
    public int Duration;
    public string Status;

    public Employee()
    {

    }

    public Employee(int Id, string Dates, string WorkDesc, int Duration, string Status)
    {
        this.Id = Id;
        this.Dates = Dates;
        this.WorkDesc = WorkDesc;
        this.Duration = Duration;
        this.Status = Status;

    }
}
