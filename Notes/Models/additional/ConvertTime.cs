namespace Notes.Models.additional
{
    public class ConvertTime
    {
        public static string TimeLeft(DateTime DeadLine)
        {
            var date = DeadLine - DateTime.Now;
            if (date.Days > 365)
            {
                var years = date.Days / 365;
                return $"Left {years} {(years == 1 ? "year" : "years")}";
            }
            else if (date.Days >= 31)
            {
                var months = date.Days / 30;
                return $"Left {months} {(months == 1 ? "month" : "months")}";
            }
            else if (date.Days >= 1)
            {
                return $"Left {date.Days} {(date.Days == 1 ? "day" : "days")}";
            }
            else if (date.Hours >= 1)
            {
                return $"Left {date.Hours} {(date.Hours == 1 ? "hour" : "hours")}";
            }
            else if (date.Minutes >= 1)
            {
                return $"Left {date.Minutes} {(date.Minutes == 1 ? "minute" : "minutes")}";
            }
            else if (date.Seconds >= 1)
            {
                return $"Left {date.Seconds} {(date.Days == 1 ? "second" : "seconds")}";
            }
            else
            {
                return "Task overdue";
            }

        }
        public static string StyleTime(DateTime DeadLine)
        {
            var date = DeadLine - DateTime.Now;
            if (date.Days > 30)
            {
                return "color: green; font-size:10px;";
            }
            else if (date.Days > 1)
            {
                return "color: yellow; front-size:10px";
            }
            else if (date.Days < 1)
            {
                return "color: red; front-size:10px";
            }
            else
            {
                return "grey";
            }
        }
    }
}
