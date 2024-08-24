using Microsoft.Maui;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void SetHighTipButtom_Clicked(System.Object sender, System.EventArgs e)
        {
            TipSlider.Value = 20;
            PercentLabel.Text = TipSlider.Value.ToString("#.##") + "%";
        }

        private void SetDownTipButtom_Clicked(System.Object sender, System.EventArgs e)
        {
            TipSlider.Value = 15;
            PercentLabel.Text = TipSlider.Value.ToString("#.##") + "%";
        }

        private void RoundUpButtom_Clicked(System.Object sender, System.EventArgs e)
        {
            TipSlider.Value = ((int)TipSlider.Value) + 1;
        }

        private void RoundDownButtom_Clicked(System.Object sender, System.EventArgs e)
        {
            TipSlider.Value = ((int)TipSlider.Value) - 1;
        }

        private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
 
            PercentLabel.Text = TipSlider.Value.ToString("#.##")+"%";

            double valor = Convert.ToDouble(AmountEntry.Text);
            double valorGorjeta = valor * (TipSlider.Value / 100);
            double valorTotal = valorGorjeta + valor;

            TipLabel.Text = valorGorjeta.ToString();
            TotalLabel.Text = valorTotal.ToString();

        }


        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }

}
