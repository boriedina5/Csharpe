using AchievementTracker.Models;
using AchievementTracker.Context;

namespace AchievementTracker
{
    public partial class AchievementTrackerApp : Form
    {
        AppDatabase Database;
        int totalPoints = 0;
        public AchievementTrackerApp()
        {
            Database = new AppDatabase();
            InitializeComponent();
            LoadListBox();
        }

        private void LoadListBox()
        {
            clbRegisteredGoal.Items.Clear();
            var goals = Database.Goals.ToList();//Goals - osztály
            foreach (var goal in goals)
            {
                clbRegisteredGoal.Items.Add(goal);
            }
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(tbGoal.Text)))
            {
                var newGoal = new Goal
                {
                    Title = tbGoal.Text,
                    Description = tbDescription.Text,
                    Points = (int)NUDPoint.Value

                };
                Database.Add(newGoal);
                Database.SaveChanges();
                LoadListBox();
            }

        }

        private void clbRegisteredGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO elsõ célt nézze + jelenjen meg a másik listába
            var selectedGoal = clbRegisteredGoal.SelectedItem as Goal;
            selectedGoal.IsDone = true;

            totalPoints += selectedGoal.Points;

            /*foreach (var item in Database.Achievements)
            {
                if (totalPoints < item.RequiredPoints)
                {
                    lblNeedingPoint.Text = $"Needing Points for next achievement:  ({item.Name}): {item.RequiredPoints - totalPoints}";
                }
            }*/

            // A legközelebbi cél keresése:
            // Sorba rendezzük pont szerint, és az elsõ olyat keressük, ami több, mint a pontunk
            var nextAchievement = Database.Achievements
                                    .OrderBy(a => a.RequiredPoints)
                                    .FirstOrDefault(a => a.RequiredPoints > totalPoints);

            if (nextAchievement != null)
            {
                lblNeedingPoint.Text = $"Points for next: ({nextAchievement.Name}): {nextAchievement.RequiredPoints - totalPoints}";
            }
            else
            {
                lblNeedingPoint.Text = "All achievements unlocked!";
            }

            lblYourPoints.Text = $"Your Points: {totalPoints}";

            lbAchievements.Items.Clear();
            foreach (var item in Database.Achievements)
            {
                if (totalPoints >= item.RequiredPoints)
                {
                    MessageBox.Show($"Congratulations! You have achieved: {item.Name}");
                    lbAchievements.Items.Add(item);
                }
            }

        }

        private void pbAchieveLevel_Click(object sender, EventArgs e)
        {
            foreach (Goal goal in clbRegisteredGoal.CheckedItems)
            {
                totalPoints += goal.Points;
            }

            // 2. Megkeressük a legközelebbi achievementet, amit még nem értünk el
            var nextAchievement = Database.Achievements
                                    .OrderBy(a => a.RequiredPoints)
                                    .FirstOrDefault(a => a.RequiredPoints > totalPoints);

            // 3. Megkeressük az utolsó már megszerzett achievementet (az alapvonalhoz)
            var currentLevel = Database.Achievements
                                    .OrderByDescending(a => a.RequiredPoints)
                                    .FirstOrDefault(a => a.RequiredPoints <= totalPoints);

            int minPoints = (currentLevel != null) ? currentLevel.RequiredPoints : 0;

            if (nextAchievement != null)
            {
                // ProgressBar beállítása
                pbAchieveLevel.Minimum = minPoints;
                pbAchieveLevel.Maximum = nextAchievement.RequiredPoints;
            }

            /*private void lbAchievements_SelectedIndexChanged(object sender, EventArgs e)
            {
                lbAchievements.Items.Clear();
                foreach (var item in Database.Achievements)
                {
                    if (totalPoints >= item.RequiredPoints)
                    {
                        MessageBox.Show($"Congratulations! You have achieved: {item.Name}");
                        lbAchievements.Text = $"Achieved: {item.Name}";
                    }
                }
            }*/
        }

    }
}
