using System.ComponentModel.DataAnnotations;

namespace SeatSentry.Models;

public class CourseNotification
{
    public int Id { get; set; }
    
    public int CourseCode { get; set; }
    public string Department { get; set; }
    public string SectionCode { get; set; }
    public string SectionTerm { get; set; }
    
    public User User { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

public class CourseNotificationDTO
{
    public int CourseCode { get; set; }
    public string Department { get; set; }
    public string SectionCode { get; set; }
    public string SectionTerm { get; set; }
    
    public User User { get; set; }
}