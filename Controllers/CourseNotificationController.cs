using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SeatSentry.Data;
using SeatSentry.Models;

namespace SeatSentry.Controllers;

public static class CourseNotificationController
{
    public static void MapCourseNotifications(this RouteGroupBuilder group)
    {
        group.MapGet("/", List);
        group.MapGet("/{id:int}", Get);
        group.MapPost("/", Create);
        group.MapPut("/{id:int}", Update);
        group.MapDelete("/{id:int}", Delete);
    }

    private static async Task<Ok<List<CourseNotification>>> List(int id, ApplicationDbContext db)
    {
        return TypedResults.Ok(await db.CourseNotifications.ToListAsync());
    }
    
    private static async Task<Ok<CourseNotification>> Get(int id, ApplicationDbContext db)
    {
        return TypedResults.Ok(await db.CourseNotifications.FindAsync(id));
    }
    
    private static async Task<Ok<CourseNotification>> Create(CourseNotificationDTO courseNotification, ApplicationDbContext db)
    {
        var result = await db.CourseNotifications.AddAsync(new CourseNotification
        {
            Department = courseNotification.Department,
            CourseCode = courseNotification.CourseCode,
            SectionCode = courseNotification.SectionCode,
            SectionTerm = courseNotification.SectionTerm,
            User = courseNotification.User,
        });

        await db.SaveChangesAsync();

        return TypedResults.Ok(result.Entity);
    }
    
    private static async Task<Results<Ok, NotFound>> Update(int id, CourseNotificationDTO courseNotification, ApplicationDbContext db)
    {
        var courseNotificationToUpdate = await db.CourseNotifications.FindAsync(id);

        if (courseNotificationToUpdate == null)
        {
            return TypedResults.NotFound();
        }

        courseNotificationToUpdate.Department = courseNotification.Department;
        courseNotificationToUpdate.CourseCode = courseNotification.CourseCode;
        courseNotificationToUpdate.SectionCode = courseNotification.SectionCode;
        courseNotificationToUpdate.SectionTerm = courseNotification.SectionTerm;
        courseNotificationToUpdate.User = courseNotification.User;

        await db.SaveChangesAsync();

        return TypedResults.Ok();
    }
    
    private static async Task<Results<NoContent, NotFound>> Delete(int id, ApplicationDbContext db)
    {
        var courseNotificationToDelete = await db.CourseNotifications.FindAsync(id);

        if (courseNotificationToDelete == null)
        {
            return TypedResults.NotFound();
        }

        db.CourseNotifications.Remove(courseNotificationToDelete);

        await db.SaveChangesAsync();

        return TypedResults.NoContent();
    }
}