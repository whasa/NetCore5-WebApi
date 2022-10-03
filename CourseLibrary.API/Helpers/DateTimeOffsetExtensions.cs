using System;

namespace CourseLibrary.API.Helpers
{
    public static class DateTimeOffsetExtensions
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffSet)
        {
            var currentDate = DateTime.UtcNow;
            int age = currentDate.Year - dateTimeOffSet.Year;
            if (currentDate < dateTimeOffSet.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
