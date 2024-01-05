namespace MegalodonCounter
{
    public partial class Megalodon : UserControl
    {
        private readonly int _MegalodonType = 0;
        private readonly string _TeamName = "";
        private readonly long _TeamTime = 0;

        public Megalodon(int megalodonType, string teamName, long teamTime)
        {
            InitializeComponent();

            _MegalodonType = megalodonType;
            _TeamName = teamName;
            _TeamTime = teamTime;

            Icon.Image = MegaData.Icon64[_MegalodonType];
            Title.Text = MegaData.Name[_MegalodonType];
            SubTitle.Text = _TeamName;
            Date.Text = Tools.GetNiceDate(_TeamTime);
            Time.Text = Tools.GetNiceTime(_TeamTime);
        }

        public JsonMegalodon GetData()
        {
            return new()
            {
                MegalodonType = _MegalodonType,
                TeamName = _TeamName,
                TeamTime = _TeamTime
            };
        }
    }
}