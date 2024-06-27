namespace StudentAttendance.Models;


public class Attendance {

    public int AttendanceId { get; set; }
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }


}