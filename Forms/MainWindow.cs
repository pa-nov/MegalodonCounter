using System.Text.Json;

namespace MegalodonCounter
{
    public partial class MainWindow : Form
    {
        private string CurrentFile = "ErrorFile.json";

        private long StartTime = 0;
        private string[] Teams = Array.Empty<string>();
        private Megalodon[] Megalodons = Array.Empty<Megalodon>();

        #region Основные свойства окна
        public MainWindow() { InitializeComponent(); }
        private void MenuCreate_Click(object sender, EventArgs e) { CreateFile(); }
        private void MenuOpen_Click(object sender, EventArgs e) { OpenFile(); }
        private void MenuStatistics_Click(object sender, EventArgs e)
        {
            if (CurrentFile == "ErrorFile.json" || Megalodons.Length < 1)
            {
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }
            new StatisticsWindow(CurrentFile).ShowDialog();
        }
        #endregion

        #region Добавление Мегалодона
        private void MenuNewMegalodon_Click(object sender, EventArgs e)
        {
            AddWindow.Visible = !AddWindow.Visible;
        }
        private void NewMegalodon_Click(object sender, EventArgs e)
        {
            if (CurrentFile == "ErrorFile.json")
            {
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }
            AddWindow.Visible = false;
            AddMegalodon(int.Parse(((Button)sender).Tag.ToString()!), TeamNameInput.Text, DateTimeOffset.Now.ToUnixTimeSeconds());
            TeamNameInput.Text = "";
            SaveFile();
        }
        private void AddMegalodon(int megalodonType, string teamName, long teamTime)
        {
            int i = Megalodons.Length;
            Array.Resize(ref Megalodons, i + 1);

            Megalodons[i] = new(megalodonType, teamName, teamTime);
            if (i % 2 == 0)
            {
                Megalodons[i].BackColor = Color.FromArgb(28, 38, 45);
            }
            else
            {
                Megalodons[i].BackColor = Color.FromArgb(38, 48, 55);
            }
            MegalodonsArea.Controls.Add(Megalodons[i]);
        }
        #endregion

        #region Сохранение файла
        private void CreateFile()
        {
            SaveFileDialog saveFileDialog = new() { Filter = "Файл конфигурации (*.json)|*.json" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                CurrentFile = file;

                CreateFileDialog createFileDialog = new();
                if (createFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StartTime = DateTimeOffset.Now.ToUnixTimeSeconds();

                    TeamNameInput.Items.Clear();
                    Teams = createFileDialog.Teams;
                    foreach (string team in Teams)
                    {
                        TeamNameInput.Items.Add(team);
                    }

                    Megalodons = Array.Empty<Megalodon>();
                    MegalodonsArea.Controls.Clear();

                    SaveFile();
                }
            }
        }
        private void SaveFile()
        {
            string file = CurrentFile;

            JsonMegalodon[] jsonMegalodons = Array.Empty<JsonMegalodon>();
            for (int i = 0; i < Megalodons.Length; i++)
            {
                Array.Resize(ref jsonMegalodons, i + 1);
                jsonMegalodons[i] = Megalodons[i].GetData();
            }

            JsonSave jsonSave = new()
            {
                StartTime = StartTime,
                Teams = Teams,
                Megalodons = jsonMegalodons
            };

            File.WriteAllText(file, JsonSerializer.Serialize(jsonSave));
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new() { Filter = "Файл конфигурации (*.json)|*.json" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                CurrentFile = file;

                JsonSave jsonSave = JsonSerializer.Deserialize<JsonSave>(File.ReadAllText(file))!;

                StartTime = jsonSave.StartTime;

                TeamNameInput.Items.Clear();
                Teams = jsonSave.Teams;
                foreach (string team in Teams)
                {
                    TeamNameInput.Items.Add(team);
                }

                Megalodons = Array.Empty<Megalodon>();
                MegalodonsArea.Controls.Clear();
                AddWindow.Visible = false;

                foreach (JsonMegalodon megalodon in jsonSave.Megalodons)
                {
                    AddMegalodon(megalodon.MegalodonType, megalodon.TeamName, megalodon.TeamTime);
                }
            }
        }
        #endregion
    }
}