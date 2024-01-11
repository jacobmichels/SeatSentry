namespace SeatSentry.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    
    public IList<CourseNotification> CourseNotifications { get; set; }
}