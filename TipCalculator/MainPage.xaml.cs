namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn15Percent_Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 15;
        }

        private void Btn20Percent_Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 20;
        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
            //calcular a gorjeta, arredondando para baixo
            double result = CalculateTip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            // exibir a gorjeta 
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();
        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {
            //calcular a gorjeta, arredondando para cima
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            // exibir a gorjeta 

            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();
        }

        private double CalculateTip()
        {
            //Programar uma função de calcule a %
            //Necessário receber o valor total do pedido  
            //Receber o valor da % para calcular a gorjeta
            //Realizar o calculo da gorjeta, considerando o tipo do arredondamento
            //Exibir o valor na Label TotalTip

            double amount =  Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;
            //Calculo do valor da gorjeta
            double result = amount * (percent / 100);
            return result;
           
           }

        private void SliderTipPercent_ValueChanged(object sender, ValueChangedEventArgs e)
        {
          LabelPercentageValue.Text = Math.Round(SliderTipPercent.Value).ToString();
        }
    }

}
