using MegalodonCounter.Properties;

namespace MegalodonCounter
{
    public static class Tools
    {
        public static string GetNiceDate(long unixTime)
        {
            string currentDate = "";

            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(unixTime).ToLocalTime();

            currentDate += GetNiceNumber(dateTime.Day) + ".";
            currentDate += GetNiceNumber(dateTime.Month) + ".";
            currentDate += dateTime.Year.ToString().Remove(0, 2);

            return currentDate;
        }
        public static string GetNiceTime(long unixTime)
        {
            string currentTime = "";

            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(unixTime).ToLocalTime();

            currentTime += GetNiceNumber(dateTime.Hour) + ":";
            currentTime += GetNiceNumber(dateTime.Minute) + ":";
            currentTime += GetNiceNumber(dateTime.Second);

            return currentTime;
        }

        public static string GetNiceText(int value, string oneText, string smallText, string largeText)
        {
            if (Math.Floor((float)value / 10) % 10 == 1)
            {
                if (value % 10 == 1)
                {
                    return value + " " + oneText;
                }
                if (value % 10 == 2 || value % 10 == 3 || value % 10 == 4)
                {
                    return value + " " + smallText;
                }
            }
            return value + " " + largeText;
        }
        public static string GetNiceNumber(int number)
        {
            if (number < 10)
            {
                return "0" + number.ToString();
            }
            return number.ToString();
        }
    }

    public static class MegaData
    {
        public static Icon AppIcon = Resources.icon;
        public static Image[] Icon64 =
            { Resources.Blue64, Resources.Violet64, Resources.Black64, Resources.Yellow64, Resources.White64 };
        public static Image[] Icon48 =
            { Resources.Blue48, Resources.Violet48, Resources.Black48, Resources.Yellow48, Resources.White48 };
        public static string[] Name =
            { "Алчная Пасть", "Венценосная Королева", "Сумрачная Пасть", "Древний Ужас", "Скрытый Дух" };
    }

    public class JsonSave
    {
        public long StartTime { get; set; } = 0;
        public string[] Teams { get; set; } = Array.Empty<string>();
        public JsonMegalodon[] Megalodons { get; set; } = Array.Empty<JsonMegalodon>();
    }
    public class JsonMegalodon
    {
        public int MegalodonType { get; set; } = 0;
        public string TeamName { get; set; } = "";
        public long TeamTime { get; set; } = 0;
    }
}