namespace CaraCoroa
{
    public partial class MainPage : ContentPage
    {
        int ladoSorteado = 0;

        public MainPage()
        {
            InitializeComponent();
            CoinSidesPicker.SelectedIndex = 0;
        }
        private void PlayCoinButton_Clicked(object sender, EventArgs e)
        {
            //Pegar o número selecionado pelo usuário
            int max = Convert.ToInt32(CoinSidesPicker.SelectedItem);
            //Sortear um numero que seja entre 1 e o numero selecionado
            ladoSorteado = new Random().Next(1, max + 1);
            //Exibir ele na label da interface
            CoinResultLabel. = ladoSorteado.ToString();
        }
    }

}