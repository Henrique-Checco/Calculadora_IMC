namespace Calculadora_IMC.Paginas;

public partial class IMC : ContentPage
{
	public IMC()
	{
		InitializeComponent();
	}

    private void CalculateIMC_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(alturaEntry.Text, out double altura) &&
            double.TryParse(pesoEntry.Text, out double peso))
        {
            double calcular = Calculate(altura, peso);
            resultadoLabel.Text = $"Seu IMC é: {calcular:F2}";
        }
        else
        {
            resultadoLabel.Text = "Por favor, insira valores válidos para altura e peso.";
        }
    }

    private double Calculate(double altura, double peso)
    {
        return peso / (altura * altura);
    }
}