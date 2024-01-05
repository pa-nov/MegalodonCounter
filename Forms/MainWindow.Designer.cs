using MegalodonCounter.Properties;

namespace MegalodonCounter
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new MenuStrip();
            MenuCreate = new ToolStripMenuItem();
            MenuOpen = new ToolStripMenuItem();
            MenuNewMegalodon = new ToolStripMenuItem();
            MenuStatistics = new ToolStripMenuItem();
            AddWindow = new Panel();
            TeamNameInput = new ComboBox();
            SetMegBlue = new Button();
            SetMegViolet = new Button();
            SetMegBlack = new Button();
            SetMegYellow = new Button();
            SetMegWhite = new Button();
            MegalodonsArea = new FlowLayoutPanel();
            Menu.SuspendLayout();
            AddWindow.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(1, 20, 26);
            Menu.Font = new Font("Windlass Extended", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Menu.Items.AddRange(new ToolStripItem[] { MenuCreate, MenuOpen, MenuNewMegalodon, MenuStatistics });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(480, 28);
            Menu.TabIndex = 0;
            // 
            // MenuCreate
            // 
            MenuCreate.ForeColor = Color.FromArgb(211, 200, 172);
            MenuCreate.Name = "MenuCreate";
            MenuCreate.Size = new Size(82, 24);
            MenuCreate.Text = "Создать";
            MenuCreate.Click += MenuCreate_Click;
            // 
            // MenuOpen
            // 
            MenuOpen.ForeColor = Color.FromArgb(211, 200, 172);
            MenuOpen.Name = "MenuOpen";
            MenuOpen.Size = new Size(86, 24);
            MenuOpen.Text = "Открыть";
            MenuOpen.Click += MenuOpen_Click;
            // 
            // MenuNewMegalodon
            // 
            MenuNewMegalodon.Alignment = ToolStripItemAlignment.Right;
            MenuNewMegalodon.ForeColor = Color.FromArgb(211, 200, 172);
            MenuNewMegalodon.Name = "MenuNewMegalodon";
            MenuNewMegalodon.Size = new Size(91, 24);
            MenuNewMegalodon.Text = "Добавить";
            MenuNewMegalodon.Click += MenuNewMegalodon_Click;
            // 
            // MenuStatistics
            // 
            MenuStatistics.Alignment = ToolStripItemAlignment.Right;
            MenuStatistics.ForeColor = Color.FromArgb(211, 200, 172);
            MenuStatistics.Name = "MenuStatistics";
            MenuStatistics.Size = new Size(106, 24);
            MenuStatistics.Text = "Статистика";
            MenuStatistics.Click += MenuStatistics_Click;
            // 
            // AddWindow
            // 
            AddWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddWindow.BackColor = Color.FromArgb(21, 40, 46);
            AddWindow.Controls.Add(TeamNameInput);
            AddWindow.Controls.Add(SetMegBlue);
            AddWindow.Controls.Add(SetMegViolet);
            AddWindow.Controls.Add(SetMegBlack);
            AddWindow.Controls.Add(SetMegYellow);
            AddWindow.Controls.Add(SetMegWhite);
            AddWindow.Location = new Point(0, 28);
            AddWindow.Name = "AddWindow";
            AddWindow.Size = new Size(480, 500);
            AddWindow.TabIndex = 0;
            AddWindow.Visible = false;
            // 
            // TeamNameInput
            // 
            TeamNameInput.BackColor = Color.FromArgb(11, 30, 36);
            TeamNameInput.FlatStyle = FlatStyle.Flat;
            TeamNameInput.Font = new Font("Windlass Extended", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameInput.ForeColor = Color.FromArgb(211, 200, 172);
            TeamNameInput.Location = new Point(20, 20);
            TeamNameInput.Name = "TeamNameInput";
            TeamNameInput.Size = new Size(440, 40);
            TeamNameInput.TabIndex = 0;
            TeamNameInput.TabStop = false;
            // 
            // SetMegBlue
            // 
            SetMegBlue.BackColor = Color.FromArgb(11, 30, 36);
            SetMegBlue.FlatStyle = FlatStyle.Flat;
            SetMegBlue.Font = new Font("Windlass Extended", 20F, FontStyle.Bold, GraphicsUnit.Point);
            SetMegBlue.Image = Resources.Blue48;
            SetMegBlue.ImageAlign = ContentAlignment.MiddleLeft;
            SetMegBlue.Location = new Point(20, 80);
            SetMegBlue.Name = "SetMegBlue";
            SetMegBlue.Size = new Size(440, 64);
            SetMegBlue.TabIndex = 0;
            SetMegBlue.TabStop = false;
            SetMegBlue.Tag = "0";
            SetMegBlue.Text = "Алчная Пасть";
            SetMegBlue.TextAlign = ContentAlignment.MiddleLeft;
            SetMegBlue.TextImageRelation = TextImageRelation.ImageBeforeText;
            SetMegBlue.UseVisualStyleBackColor = false;
            SetMegBlue.Click += NewMegalodon_Click;
            // 
            // SetMegViolet
            // 
            SetMegViolet.BackColor = Color.FromArgb(11, 30, 36);
            SetMegViolet.FlatStyle = FlatStyle.Flat;
            SetMegViolet.Font = new Font("Windlass Extended", 20F, FontStyle.Bold, GraphicsUnit.Point);
            SetMegViolet.Image = Resources.Violet48;
            SetMegViolet.ImageAlign = ContentAlignment.MiddleLeft;
            SetMegViolet.Location = new Point(20, 164);
            SetMegViolet.Name = "SetMegViolet";
            SetMegViolet.Size = new Size(440, 64);
            SetMegViolet.TabIndex = 0;
            SetMegViolet.TabStop = false;
            SetMegViolet.Tag = "1";
            SetMegViolet.Text = "Венценосная Королева";
            SetMegViolet.TextAlign = ContentAlignment.MiddleLeft;
            SetMegViolet.TextImageRelation = TextImageRelation.ImageBeforeText;
            SetMegViolet.UseVisualStyleBackColor = false;
            SetMegViolet.Click += NewMegalodon_Click;
            // 
            // SetMegBlack
            // 
            SetMegBlack.BackColor = Color.FromArgb(11, 30, 36);
            SetMegBlack.FlatStyle = FlatStyle.Flat;
            SetMegBlack.Font = new Font("Windlass Extended", 20F, FontStyle.Bold, GraphicsUnit.Point);
            SetMegBlack.Image = Resources.Black48;
            SetMegBlack.ImageAlign = ContentAlignment.MiddleLeft;
            SetMegBlack.Location = new Point(20, 248);
            SetMegBlack.Name = "SetMegBlack";
            SetMegBlack.Size = new Size(440, 64);
            SetMegBlack.TabIndex = 0;
            SetMegBlack.TabStop = false;
            SetMegBlack.Tag = "2";
            SetMegBlack.Text = "Сумрачная Пасть";
            SetMegBlack.TextAlign = ContentAlignment.MiddleLeft;
            SetMegBlack.TextImageRelation = TextImageRelation.ImageBeforeText;
            SetMegBlack.UseVisualStyleBackColor = false;
            SetMegBlack.Click += NewMegalodon_Click;
            // 
            // SetMegYellow
            // 
            SetMegYellow.BackColor = Color.FromArgb(11, 30, 36);
            SetMegYellow.FlatStyle = FlatStyle.Flat;
            SetMegYellow.Font = new Font("Windlass Extended", 20F, FontStyle.Bold, GraphicsUnit.Point);
            SetMegYellow.Image = Resources.Yellow48;
            SetMegYellow.ImageAlign = ContentAlignment.MiddleLeft;
            SetMegYellow.Location = new Point(20, 332);
            SetMegYellow.Name = "SetMegYellow";
            SetMegYellow.Size = new Size(440, 64);
            SetMegYellow.TabIndex = 0;
            SetMegYellow.TabStop = false;
            SetMegYellow.Tag = "3";
            SetMegYellow.Text = "Древний Ужас";
            SetMegYellow.TextAlign = ContentAlignment.MiddleLeft;
            SetMegYellow.TextImageRelation = TextImageRelation.ImageBeforeText;
            SetMegYellow.UseVisualStyleBackColor = false;
            SetMegYellow.Click += NewMegalodon_Click;
            // 
            // SetMegWhite
            // 
            SetMegWhite.BackColor = Color.FromArgb(11, 30, 36);
            SetMegWhite.FlatStyle = FlatStyle.Flat;
            SetMegWhite.Font = new Font("Windlass Extended", 20F, FontStyle.Bold, GraphicsUnit.Point);
            SetMegWhite.Image = Resources.White48;
            SetMegWhite.ImageAlign = ContentAlignment.MiddleLeft;
            SetMegWhite.Location = new Point(20, 416);
            SetMegWhite.Name = "SetMegWhite";
            SetMegWhite.Size = new Size(440, 64);
            SetMegWhite.TabIndex = 0;
            SetMegWhite.TabStop = false;
            SetMegWhite.Tag = "4";
            SetMegWhite.Text = "Скрытый Дух";
            SetMegWhite.TextAlign = ContentAlignment.MiddleLeft;
            SetMegWhite.TextImageRelation = TextImageRelation.ImageBeforeText;
            SetMegWhite.UseVisualStyleBackColor = false;
            SetMegWhite.Click += NewMegalodon_Click;
            // 
            // MegalodonsArea
            // 
            MegalodonsArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MegalodonsArea.AutoScroll = true;
            MegalodonsArea.FlowDirection = FlowDirection.TopDown;
            MegalodonsArea.Location = new Point(0, 28);
            MegalodonsArea.Name = "MegalodonsArea";
            MegalodonsArea.Size = new Size(480, 760);
            MegalodonsArea.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 30, 36);
            ClientSize = new Size(480, 788);
            Controls.Add(Menu);
            Controls.Add(AddWindow);
            Controls.Add(MegalodonsArea);
            Font = new Font("Windlass Extended", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(211, 200, 172);
            Icon = Resources.icon;
            Margin = new Padding(5);
            MinimumSize = new Size(496, 187);
            Name = "MainWindow";
            Text = "Счётчик Мегалодонов";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            AddWindow.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem MenuCreate;
        private ToolStripMenuItem MenuOpen;
        private ToolStripMenuItem MenuNewMegalodon;
        private ToolStripMenuItem MenuStatistics;
        private Panel AddWindow;
        private ComboBox TeamNameInput;
        private Button SetMegBlue;
        private Button SetMegViolet;
        private Button SetMegBlack;
        private Button SetMegYellow;
        private Button SetMegWhite;
        private FlowLayoutPanel MegalodonsArea;
    }
}