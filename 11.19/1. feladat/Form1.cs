namespace _1._feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Listview - jobban lehet listát megjeleniteni: csoportosítás, csempe, futási idõ alatt való editelést is engedi (ha engedélyezve van)
            InitializeComponent();
            ListViewItem item = new ListViewItem("item1", 0); //Listview itemet létrehozom
            item.SubItems.Add("1");
            item.SubItems.Add("2");
            item.SubItems.Add("3");
            lv.Items.Add(item);

            ListViewItem item2 = new ListViewItem("item1", 0);
            item2.SubItems.Add("1");
            item2.SubItems.Add("2");
            item2.SubItems.Add("3");
            lv.Items.Add(item);
        }
    }
}
