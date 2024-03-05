namespace SeatSentry.Models;

public class Section
{
    public Guid Id { get; set; }
    public string Term { get; set; }
    public string Number { get; set; }
    public Course Course { get; set; }
}