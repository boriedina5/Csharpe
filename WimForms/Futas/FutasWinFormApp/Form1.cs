using FutasWinFormApp.Context;
using FutasWinFormApp.Models;

namespace FutasWinFormApp
{
    public partial class Form1 : Form
    {
        AppDatabase Database;
        public Form1()
        {
            InitializeComponent();
            Database = new AppDatabase();
            //beolv
            string[] rows = File.ReadAllLines("futas.txt");
            foreach (var row in rows.Skip(1))
            {
                string[] rowDatas = row.Split(";");
                string name = rowDatas[0];
                string city = rowDatas[1];
                int time = int.Parse(rowDatas[2]);

                //csak egyszer
                bool exist = Database.Contestants.Any(x => x.Name == name && x.City == city && x.Time == time );
                if (!exist)
                {
                    Database.Contestants.Add(new Models.Contestant
                    {
                        Name = name,
                        City = city,
                        Time = time
                    });
                }
                

            }
            Database.SaveChanges();
            LoadListBox(Database.Contestants.ToList());//Listávvá alakítom a paramétert
        }
        public void LoadListBox(List<Contestant> contestants)
        {
            lbContestant.Items.Clear();
            foreach (var contestant in contestants)
            {
                lbContestant.Items.Add(contestant);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbSearchByName.Text)) { 
                string searchName = TbSearchByName.Text;
                var searchResult = Database.Contestants.Where(x => x.Name == searchName).ToList();
                LoadListBox(searchResult);
            }
        }

        private void BtnCFBP_Click(object sender, EventArgs e)
        {
            var CFBResult = Database.Contestants.Where(x => x.City == "Budapest").ToList();
            LoadListBox(CFBResult);
        }

        private void BtnOrderByTime_Click(object sender, EventArgs e)
        {
            var orderByTimeResult = Database.Contestants.OrderBy(x => x.Time).ToList();
            LoadListBox(orderByTimeResult);
        }

        private void btnDefaultView_Click(object sender, EventArgs e)
        {
            LoadListBox(Database.Contestants.ToList());
        }
    }
}
