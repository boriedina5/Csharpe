//using Dbgyakorlas.Context; -nem kell
//Ebben a fájlban azért nem kell, mert
//a namespace Dbgyakorlas blokkon belül vagy.
//Ha az AppDatabase (a Context osztályod) közvetlenül a Dbgyakorlas névtérben van definiálva,
//akkor a fordító "látja" azt importálás nélkül is.
//Csak akkor kellene, ha a Context egy al-mappában (pl. Context mappa)
//és így egy másik névtérben (Dbgyakorlas.Context) lenne.

using Dbgyakorlas.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Text.Json; //kell, Ez a névtér tartalmazza a JsonSerializer osztályt. Ez felel a JSON fájlok feldolgozásáért.


namespace Dbgyakorlas
{
    public partial class Form1 : Form
    {
        AppDatabase Database;
        public Form1()
        {
            InitializeComponent();
            //Négyszer meghívja a LoadListBox metódust, hogy betöltse az adatokat a megfelelõ ListBox-okba
            LoadListBox(lbCustomers, Database.Customers);
            LoadListBox(lbOrders, Database.Orders);
            LoadListBox(lbProducts, Database.Products);
            LoadListBox(lbOrderDetails, Database.OrderDetails);
            Database = new AppDatabase();
        }

        private void LoadListBox<T>(ListBox lb, IEnumerable<T> list)
        {
            lb.Items.Clear();
            foreach (var item in list)
            {
                lb.Items.Add(item);
            }
        }

        public List<T> LoadFromJson<T>(string filePath)
        //univerzális (generikus) megoldás arra, hogy egy JSON fájl tartalmát
        //visszaalakítsd C# objektumok listájává.
        //<T>-rõl-----------------------------------------
        //A <T> (Generikus típus)Ez a függvény legokosabb része.
        //A T egy helykitöltõ (mint a matekban az x).
        //Azt jelenti: "Ez a függvény bármilyen típusú listával elboldogul".
        //  Ha LoadFromJson<Product>-ként hívod meg, termékeket ad vissza.
        //  Ha LoadFromJson<Order>-ként, akkor rendeléseket.
        {

            var jsonString = File.ReadAllText(filePath);
            //Ez a sor megnyitja a megadott útvonalon (filePath) található fájlt,
            //beolvassa az összes benne lévõ szöveget (karakterláncot),
            //és elmenti a jsonString változóba.
            return JsonSerializer.Deserialize<List<T>>(jsonString);
            //Ez a sor a JsonSerializer osztályt használja
            //Végigolvassa a nyers JSON szöveget.
            //Megkeresi a JSON kulcsokat(pl. "Name": "Alma").
            //Párosítja õket a T típusú osztályod tulajdonságaival.
            //Létrehozza a példányokat, és belepakolja õket egy List<T> listába.
        }

        private void btnReadCustomers_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//Fájl megnyitása dialógusablak létrehozása
            ofd.Title = "Válaszd ki a JSON-t";
            ofd.Filter = "JSON fájlok (*.json)|*.json|Minden fájl (*.*)|*.*";//Szûrõ beállítása

            if (ofd.ShowDialog() == DialogResult.OK)
            { //Amikor felugrik a fájlválasztó ablak, a felhasználó két dolgot tehet:
              //Kiválaszt egy fájlt és rányom a Megnyitás gombra (DialogResult.OK)
              //Rányom a Mégse gombra vagy bezárja az x-szel (DialogResult.Cancel). A feltétel azt biztosítja, hogy a
              //kód csak akkor fusson tovább, ha tényleg választottak fájlt.

                string filePath = ofd.FileName;//A kiválasztott fájl elérési útjának lekérése
                var customers = LoadFromJson<Customer>(filePath);//JSON fájl betöltése és deszerializálása

                Database.Customers.AddRange(customers);//Ügyfelek hozzáadása az adatbázishoz,AddRange():  egész gyûjteményt (listát, tömböt) ad hozzá egyszerre. Mivel a JSON-bõl egy List<Customer> érkezik vissza, az AddRange a leghatékonyabb módja, hogy az összeset egyszerre "beleöntsd" az adatbázisba. <-> Add() metódus egyszerre egyetlen elemet ad hozzá a listához/adatbázishoz.
                Database.SaveChanges();//Változások mentése az adatbázisban
                LoadListBox(lbCustomers, Database.Customers);//ListBox frissítése az új adatokkal
            }


        }

        private void btnReadProducts_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//Fájl megnyitása dialógusablak létrehozása
            ofd.Title = "Válaszd ki a JSON-t";
            ofd.Filter = "JSON fájlok (*.json)|*.json|Minden fájl (*.*)|*.*";//Szûrõ beállítása

            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                string filePath = ofd.FileName;//A kiválasztott fájl elérési útjának lekérése
                var products = LoadFromJson<Product>(filePath);//JSON fájl betöltése és deszerializálása

                Database.Products.AddRange(products);//Ügyfelek hozzáadása az adatbázishoz
                Database.SaveChanges();//Változások mentése az adatbázisban
                LoadListBox(lbProducts, Database.Products);//ListBox frissítése az új adatokkal
            }
        }

        private void btnReadOrders_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//Fájl megnyitása dialógusablak létrehozása
            ofd.Title = "Válaszd ki a JSON-t";
            ofd.Filter = "JSON fájlok (*.json)|*.json|Minden fájl (*.*)|*.*";//Szûrõ beállítása

            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                string filePath = ofd.FileName;//A kiválasztott fájl elérési útjának lekérése
                var orders = LoadFromJson<Order>(filePath);//JSON fájl betöltése és deszerializálása

                Database.Orders.AddRange(orders);//Ügyfelek hozzáadása az adatbázishoz
                Database.SaveChanges();//Változások mentése az adatbázisban
                LoadListBox(lbOrders, Database.Orders);//ListBox frissítése az új adatokkal
            }
        }

        private void btnReadOrderDetails_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//Fájl megnyitása dialógusablak létrehozása
            ofd.Title = "Válaszd ki a JSON-t";
            ofd.Filter = "JSON fájlok (*.json)|*.json|Minden fájl (*.*)|*.*";//Szûrõ beállítása

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;//A kiválasztott fájl elérési útjának lekérése
                var orderDetails = LoadFromJson<OrderDetail>(filePath);//JSON fájl betöltése és deszerializálása

                Database.OrderDetails.AddRange(orderDetails);//Ügyfelek hozzáadása az adatbázishoz 
                Database.SaveChanges();//Változások mentése az adatbázisban
                LoadListBox(lbOrderDetails, Database.OrderDetails);//ListBox frissítése az új adatokkal
            }
        }

        public void SaveToJson<T>(IEnumerable<T> data, string filePath)//Mindegyik exportra ráhúzható, mert a <T> miatt templatelve van, IEnumerable<T>(?) miatt bármilyen gyûjteményt elfogad
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true //Szép formázású (tördelt) JSON
                
            };
            var jsonString = JsonSerializer.Serialize(data, options);//Adatok szerializálása JSON formátumba - amely során egy programozási nyelv élõ adatobjektumát (például egy Python szótárat vagy C# objektumot) egy szabványos szöveges formátummá alakítjuk
            File.WriteAllText(filePath, jsonString);//JSON szöveg írása a megadott fájlba


        }   

        private void btnExportCustomers_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)//Nem számít hova pakolom a desigerben a saveFileDialog1
            {
                string filePath = saveFileDialog1.FileName;
                var customers = Database.Customers.Select(c => new { // lambda kifejezés, azon belül Projection
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    Phone = c.Phone
                    //new { ... } pedig egy Anonymous Type (névtelen típus).
                    //Azért használjuk, mert nem akarjuk az egész Customer objektumot (minden adatbázis-sallanggal) exportálni,
                    //csak ezt a 4 konkrét mezõt.
                }).ToList();//Adatok lekérése az adatbázisból

                SaveToJson(customers, filePath);//Adatok mentése JSON fájlba
            }
        }

        private void btnExportProducts_Click(object sender, EventArgs e)//Többi másolás
        {

        }

        private void btnExportOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnExportOrderDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var data = Database.Customers.//Csak kapcsoló táblák között mûködik
                    Select(c => new
                    {
                        //miért nem kell Id = c.Id?
                        //Ez a C# egyik kényelmi funkciója: Property Name Inference. Ha az új (névtelen) objektum tulajdonságának ugyanazt a nevet akarod adni, mint ami az eredetiben volt, nem kell kiírnod az Id = részt.

                        c.Id,
                        c.Name,
                        c.Email,
                        c.Phone,
                        Orders = c.Orders.Select(o => new
                        {
                            o.Id,
                            o.OrderDate,
                            o.Status,
                            Details = o.OrderDetails.Select(d => new
                            {
                                d.ProductId,
                                d.Quantity,
                            }).ToList()
                        }).ToList()
                    }).ToList();
                //188-208
                //Ez egy komplex export. Lekéri a vevõt, hozzá az õ rendeléseit, a rendeléseken belül pedig a részleteket.
                //Ezt hívják hierarchikus adatstruktúrának.
                //A JSON-ben ez egymásba ágyazott listákként fog megjelenni.
                SaveToJson(data, saveFileDialog1.FileName);//Ez a sor hívja meg a korábban megírt SaveToJson<T> generikus függvényedet.
                //data változóban - van az az óriási, egymásba ágyazott lista, amit az elõbb összeállítottál.
                //saveFileDialog1.FileName pedig az az útvonal, amit a felhasználó megadott a mentésnél (pl. C:\mentes\osszes_adat.json).
                //Gyakorlatilag ez a sor teszi rá a pontot az i-re: kiküldi a memóriából a winchesterre az adatokat.

            }
        }
    }
}
