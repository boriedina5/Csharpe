namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        private string currentEntry = "0";
        private double firstNumber;
        private string Operator;
        private bool isNewEntry = true;



        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNumberClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var number = button.Text;

            if (isNewEntry)
            {
                currentEntry = number;
                isNewEntry = false;
            }
            else
            {
                currentEntry += number;
            }
            UpdateResult();
        }
        private void UpdateResult()
        {
            ResultEntry.Text = currentEntry;
        }
        private void OnOperatorClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Operator = button.Text;
            firstNumber = double.Parse(currentEntry);
            isNewEntry = true;
        }
        private void OnEqualsClicked(object sender, EventArgs e)
        {
            var secondNumber = double.Parse(currentEntry);
            double result = 0;

            switch (Operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = secondNumber != 0 ? firstNumber / secondNumber : 0;
                    break;
            }
            currentEntry = result.ToString();
            isNewEntry = false;
            UpdateResult();
        }
            private void onClearClicked(object sender, EventArgs e)
            {
                currentEntry = "0";
                firstNumber = 0;
                Operator = string.Empty;
                isNewEntry = true;
                UpdateResult();

        }
    }   
}
