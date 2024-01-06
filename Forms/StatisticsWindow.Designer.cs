using MegalodonCounter.Properties;

namespace MegalodonCounter
{
    partial class StatisticsWindow
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            StartTime = new Label();
            TotalTime = new Label();
            AVGTime = new Label();
            TotalCount = new Label();
            TotalCountBlue = new Label();
            TotalCountViolet = new Label();
            TotalCountBlack = new Label();
            TotalCountYellow = new Label();
            TotalCountWhite = new Label();
            SuspendLayout();
            // 
            // StartTime
            // 
            StartTime.AutoSize = true;
            StartTime.Location = new Point(20, 20);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(249, 23);
            StartTime.TabIndex = 0;
            StartTime.Text = "Начало: ??.??.?? - ??:??:??";
            // 
            // TotalTime
            // 
            TotalTime.AutoSize = true;
            TotalTime.Location = new Point(20, 53);
            TotalTime.Name = "TotalTime";
            TotalTime.Size = new Size(326, 23);
            TotalTime.TabIndex = 0;
            TotalTime.Text = "Потрачено времени: ? часов ? минут";
            // 
            // AVGTime
            // 
            AVGTime.AutoSize = true;
            AVGTime.Location = new Point(20, 85);
            AVGTime.Name = "AVGTime";
            AVGTime.Size = new Size(382, 23);
            AVGTime.TabIndex = 0;
            AVGTime.Text = "Среднее время перерыва: ? минут ? секунд";
            // 
            // TotalCount
            // 
            TotalCount.AutoSize = true;
            TotalCount.Location = new Point(20, 128);
            TotalCount.Name = "TotalCount";
            TotalCount.Size = new Size(200, 23);
            TotalCount.TabIndex = 0;
            TotalCount.Text = "Всего Мегалодонов: ?";
            // 
            // TotalCountBlue
            // 
            TotalCountBlue.AutoSize = true;
            TotalCountBlue.Location = new Point(20, 161);
            TotalCountBlue.Name = "TotalCountBlue";
            TotalCountBlue.Size = new Size(216, 23);
            TotalCountBlue.TabIndex = 0;
            TotalCountBlue.Text = "Всего Алчных Пастей: ?";
            // 
            // TotalCountViolet
            // 
            TotalCountViolet.AutoSize = true;
            TotalCountViolet.Location = new Point(20, 194);
            TotalCountViolet.Name = "TotalCountViolet";
            TotalCountViolet.Size = new Size(276, 23);
            TotalCountViolet.TabIndex = 0;
            TotalCountViolet.Text = "Всего Венценосных Королев: ?";
            // 
            // TotalCountBlack
            // 
            TotalCountBlack.AutoSize = true;
            TotalCountBlack.Location = new Point(20, 227);
            TotalCountBlack.Name = "TotalCountBlack";
            TotalCountBlack.Size = new Size(245, 23);
            TotalCountBlack.TabIndex = 0;
            TotalCountBlack.Text = "Всего Сумрачных Пастей: ?";
            // 
            // TotalCountYellow
            // 
            TotalCountYellow.AutoSize = true;
            TotalCountYellow.Location = new Point(20, 260);
            TotalCountYellow.Name = "TotalCountYellow";
            TotalCountYellow.Size = new Size(225, 23);
            TotalCountYellow.TabIndex = 0;
            TotalCountYellow.Text = "Всего Древних Ужасов: ?";
            // 
            // TotalCountWhite
            // 
            TotalCountWhite.AutoSize = true;
            TotalCountWhite.Location = new Point(20, 293);
            TotalCountWhite.Name = "TotalCountWhite";
            TotalCountWhite.Size = new Size(215, 23);
            TotalCountWhite.TabIndex = 0;
            TotalCountWhite.Text = "Всего Скрытых Духов: ?";
            // 
            // StatisticsWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 30, 36);
            ClientSize = new Size(480, 336);
            Controls.Add(TotalCountWhite);
            Controls.Add(TotalCountYellow);
            Controls.Add(TotalCountBlack);
            Controls.Add(TotalCountViolet);
            Controls.Add(TotalCountBlue);
            Controls.Add(TotalCount);
            Controls.Add(AVGTime);
            Controls.Add(TotalTime);
            Controls.Add(StartTime);
            Font = new Font("Windlass Extended", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(211, 200, 172);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = Resources.icon;
            Margin = new Padding(6);
            Name = "StatisticsWindow";
            Text = "Статистика";
            ResumeLayout(false);
            PerformLayout();
        }
        
        #endregion
        
        private Label StartTime;
        private Label TotalTime;
        private Label AVGTime;
        private Label TotalCount;
        private Label TotalCountBlue;
        private Label TotalCountViolet;
        private Label TotalCountBlack;
        private Label TotalCountYellow;
        private Label TotalCountWhite;
    }
}