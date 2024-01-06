using System.Text.Json;

namespace MegalodonCounter
{
    public partial class StatisticsWindow : Form
    {
        public StatisticsWindow(string file)
        {
            InitializeComponent();

            JsonSave jsonSave = JsonSerializer.Deserialize<JsonSave>(File.ReadAllText(file))!;

            long endTime = jsonSave.StartTime;
            int[] avgTime = Array.Empty<int>();
            int[] totalCount = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < jsonSave.Megalodons.Length; i++)
            {
                JsonMegalodon megalodon = jsonSave.Megalodons[i];

                Array.Resize(ref avgTime, avgTime.Length + 1);
                avgTime[^1] = (int)(megalodon.TeamTime - endTime);

                totalCount[5]++;
                totalCount[megalodon.MegalodonType]++;

                endTime = megalodon.TeamTime;
            }

            long totalHours = (endTime - jsonSave.StartTime) / 60 / 60;
            long totalMinutes = (endTime - jsonSave.StartTime) / 60 - totalHours * 60;

            int avgMinutes = avgTime.Sum() / avgTime.Length / 60;
            int avgSeconds = avgTime.Sum() / avgTime.Length - avgMinutes * 60;

            StartTime.Text = "Начало: " +
                Tools.GetNiceDate(jsonSave.StartTime) + " - " +
                Tools.GetNiceTime(jsonSave.StartTime);
            TotalTime.Text = "Потрачено времени: " +
                Tools.GetNiceText((int)totalHours, "час", "часа", "часов") + " " +
                Tools.GetNiceText((int)totalMinutes, "минута", "минуты", "минут");
            AVGTime.Text = "Среднее время перерыва: " +
                Tools.GetNiceText(avgMinutes, "минута", "минуты", "минут") + " " +
                Tools.GetNiceText(avgSeconds, "секунда", "секунды", "секунд");

            TotalCount.Text = "Всего Мегалодонов: " + totalCount[5];
            TotalCountBlue.Text = "Всего Алчных Пастей: " + totalCount[0];
            TotalCountViolet.Text = "Всего Венценосных Королев: " + totalCount[1];
            TotalCountBlack.Text = "Всего Сумрачных Пастей: " + totalCount[2];
            TotalCountYellow.Text = "Всего Древних Ужасов: " + totalCount[3];
            TotalCountWhite.Text = "Всего Скрытых Духов: " + totalCount[4];
        }
    }
}