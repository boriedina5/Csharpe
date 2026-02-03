using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.WebSockets;
using System.Windows.Forms;
using Trello.Context;
using Trello.Model;

namespace Trello
{
    public partial class Form1 : Form
    {
        AppDatabase Database;
        BoardColumn started;
        BoardColumn inProgress;
        BoardColumn done;
        public Form1()
        {
            InitializeComponent();
            Database = new AppDatabase();
            LoadBoards();
        }
        private void LoadBoards()
        {
            cbBoard.DataSource = Database.Boards.ToList();//LEVI
            //feltölti a legördülõ listát (ComboBox) az adatbázisban tárolt táblákkal.
            //cbBoard.DataSource = ...: Itt mondod meg a WinForms vezérlõnek (a ComboBox-nak),
            //hogy a fenti lista legyen az adatforrása.
            //Ezentúl a lista minden egyes eleme egy-egy sort fog képviselni a legördülõ menüben.
            //Database.Boards: Ez valószínûleg egy DbSet<Board>,
            //ami az adatbázisod "Boards" tábláját képviseli.
            //Amikor ezt meghívod, az Entity Framework(vagy a használt ORM) elõkészíti a lekérdezést.
            cbBoard.DisplayMember = "Name"; //ha nincs toString írva
        }

        private void btnAddBoard_Click(object sender, EventArgs e) //egy új projekt-táblát hozol létre a memóriában, feltöltöd alapértelmezett oszlopokkal, majd véglegesíted az adatbázisban
        {
            var board = new Board
            {
                Name = tbNewBoardTitle.Text
                 
             };
            //objektum inicializálás. Létrehozol a számítógép memóriájában
            //egy új Board példányt (egy objektumot). A kapcsos zárójelek közötti résszel
            //pedig azonnal be is állítod a Name tulajdonságát arra a szövegre,
            //amit a felhasználó beírt a tbNewBoardTitle nevû szövegdobozba.
            //Fontos: Ekkor az adatbázisban még nem jön létre semmi, ez csak egy "terv" a memóriában.


            board.BoardColumns.Add(new BoardColumn { Name = "Started" }); 
            //kapcsolatot épít ki a tábla és egy oszlop között:
           //Létrehoz egy új BoardColumn objektumot "Started" névvel.
            //Ezt az új oszlopot hozzáadja a board objektum saját listájához(BoardColumns).
            board.BoardColumns.Add(new BoardColumn { Name = "In Progress" });
            board.BoardColumns.Add(new BoardColumn { Name = "Done" });



            Database.Boards.Add(board);
            Database.SaveChanges();
            LoadBoards();

        }

        private void btnMoveCard_Click(object sender, EventArgs e)
        {
            var card = lbStarted.SelectedItem as BoardCard;
            if (card != null)
            {
                card.ColumnId = inProgress.Id;
                //Ez a logikai áthelyezés.Nem törlöd és hozod létre újra a kártyát,
                //csak megváltoztatod az "idegen kulcsát"(Foreign Key).Ezután a kártya már nem a "Started",
                //hanem az "In Progress" oszlophoz fog tartozni.
                Database.SaveChanges();
                LoadCards();
            }
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            var card = new BoardCard
            {
                Title = tbTitle.Text,
                Description = tbDescription.Text,
                ColumnId = started.Id
                //oszlopa, ami egy számot vár.
                //started.Id átadja azt az egyedi azonosítót,
                //ami alapján az adatbázis tudni fogja: "Ez a kártya a 'Started' oszlophoz tartozik."


            };
            Database.BoardCards.Add(card); //Regisztrálod az új kártyát az adatbázis-környezetben(Entity Framework).Ekkor még csak "sorban áll" a mentésre.
            Database.SaveChanges();
            LoadCards();
        }

        private void cbBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            var board = cbBoard.SelectedItem as Board; 
            //cbBoard.SelectedItem tulajdonság típusa alapértelmezetten object.
            //A C# nyelvben az object egy általános típus, ami bármi lehet,
            //de a fordító nem tudja róla "bemondásra", hogy ebben most éppen egy Board típusú adat van.
            Database.Entry(board).Collection(b => b.BoardColumns).Load(); 
            //Database.Entry(board) lekéri a board-ot adatbázisból,
            //Collection(b => b.BoardColumns).Load() - megkeresi az oszlopait és betölti
            started = board.BoardColumns.First(c => c.Name == "Started");//LEVI
            //Elsõ oszlop lekérése a BoardColumns gyûjteménybõl, ahol az oszlop neve "Started".
            //started változóba belekerül az az egy konkrét oszlop objektum, aminek "Started" a neve.
            //Ezt késõbb azért használod, hogy tudd, melyik oszlopba kell pakolni az új kártyákat.
            inProgress = board.BoardColumns.First(c => c.Name == "In Progress");
            done = board.BoardColumns.First(c => c.Name == "Done");
            LoadCards();
        }
        private void LoadCards()//Ez a metódus felelõs azért, hogy a kezelõfelületen található listákat (ListBox-okat) megtöltse a megfelelõ kártyákkal az oszlopok alapján
        {
            lbStarted.DataSource = Database.BoardCards.
                Where(c => c.ColumnId == started.Id).ToList();
            //Ez a sor szûri az összes kártyát, és csak azokat rendeli hozzá a "Started" (Elkezdett)
            //feliratú listához, amelyek ehhez a konkrét oszlophoz tartoznak.
            lbProgress.DataSource = Database.BoardCards.
                Where(c => c.ColumnId == inProgress.Id).ToList();
            lbDone.DataSource = Database.BoardCards.
                Where(c => c.ColumnId == done.Id).ToList();

            lbStarted.DisplayMember = "Title"; //ha nincs toString írva
            lbProgress.DisplayMember = "Title";
            lbDone.DisplayMember = "Title";


        }
    }
}
