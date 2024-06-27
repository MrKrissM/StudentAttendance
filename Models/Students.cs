namespace StudentAttendance.Models;

public class Student {
    public int StudentId { get; set; }
    public string name { get; set; }   
    public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

}