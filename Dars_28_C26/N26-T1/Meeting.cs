namespace Dars_28_C26.N26_T1;

public class Meeting
{
    public string Name { get; set; }
    public TimeSpan Duration { get; set; }

    public Meeting(string name, TimeSpan duration)
    {
        Name = name;
        Duration = duration;
    }

    public static TimeSpan operator + (TimeSpan duration, Meeting meeting )
    {
        return duration + meeting.Duration;
    }
}

public class MeetingService
{
    private List<Meeting> _meetingList;
    

}