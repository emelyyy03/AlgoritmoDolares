namespace AlgoritmoDolares
{
    public partial class MainPage : ContentPage
    {
        private const decimal ExchangeRate = 18.0m;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (decimal.TryParse(entryPesos.Text, out decimal pesos))
            {
                decimal dolares = pesos / ExchangeRate;
                labelDolares.Text = $"Resultado: ${dolares:F2} USD";
            }
        }
    }

}
