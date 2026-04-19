namespace Naptar
{
    public partial class Form1 : Form
    {
        Event newEvent;
        List<Event> eventsList;
        public Form1()
        {
            InitializeComponent();
            eventsList = new List<Event>();
            lbs(eventsList);

        }

        public void lbs(List<Event> param) { 
            lbEvents.Items.Clear();
            foreach (Event e in param) { 
                lbEvents.Items.Add(e);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTitle.Text)) { 
                string title = tbTitle.Text;
                DateTime date = dateTimePicker.Value;
                string description = tbDescription.Text;

                newEvent = new Event(title, date, description);
                eventsList.Add(newEvent);
                lbs(eventsList);

                DialogResult = DialogResult.OK;

            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lbEvents.SelectedItem != null)
            {
                int index = lbEvents.SelectedIndex;

                eventsList[index].Title = tbTitle.Text;
                eventsList[index].Date = dateTimePicker.Value;
                eventsList[index].Description = tbDescription.Text;

                lbs(eventsList);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbEvents.SelectedItem != null)
            {
                int index = lbEvents.SelectedIndex;
                eventsList.RemoveAt(index);
                lbs(eventsList);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dateTimePickerSearch.Value != null) { 
                List<Event> searchedEvents = new List<Event>();
                DateTime searchedDate = dateTimePickerSearch.Value;

                foreach (Event searchEventsLV in eventsList) {
                    if (searchEventsLV.Date.Date == searchedDate.Date) {
                        searchedEvents.Add(searchEventsLV);
                    }
                }
                lbs(searchedEvents);
            }
        }
    }
}
