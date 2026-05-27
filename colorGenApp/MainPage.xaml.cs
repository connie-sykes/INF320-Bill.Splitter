namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	private Random _random = new Random();

	public MainPage()
	{
		InitializeComponent();
	}

	// Iniciar instancia de libreria ColorNameSharp para cargar la lista de nombres de colores
	ColorNamesSharp.ColorNames colorNames = new ColorNamesSharp.ColorNamesBuilder()
		.LoadDefault()
		.Build();
	// Se llama cada vez que se mueve un slider
	private void OnSliderCambiado(object sender, ValueChangedEventArgs e)
	{
		int r = (int)SliderR.Value;
		int g = (int)SliderG.Value;
		int b = (int)SliderB.Value;

		AplicarColor(r, g, b);
	}

	// Genera valores RGB al azar y actualiza los sliders
	private void OnColorAleatorioClicked(object sender, EventArgs e)
	{
		SliderR.Value = _random.Next(0, 256);
		SliderG.Value = _random.Next(0, 256);
		SliderB.Value = _random.Next(0, 256);

		// OnSliderCambiado se ejecuta automáticamente al cambiar los sliders
	}

	// Copia el hex al portapapeles
	private async void OnCopiarHexClicked(object sender, EventArgs e)
	{
		await Clipboard.SetTextAsync(LabelHex.Text);
		await DisplayAlertAsync("Copiado", LabelHex.Text + " copiado al portapapeles", "OK");
	}

	// Aplica el color al fondo y actualiza el label hex
	private void AplicarColor(int r, int g, int b)
	{
		string hex = $"#{r:X2}{g:X2}{b:X2}";

		LabelHex.Text = hex;
		FondoColor.Color = Color.FromRgb(r, g, b);
		// Asigna nombre al color actualizando el label Nombre Color
		string colorNameFromHex= colorNames.FindClosestColorName(hex);
		NombreColor.Text = colorNameFromHex;

		// Si el color es muy oscuro, el texto cambia a blanco para ser legible
		int darkness = 30;
		if ((r<darkness) && (g<darkness) && (b<darkness))
		{
			LabelHex.TextColor = Color.FromRgb(255, 255, 255);
			NombreColor.TextColor = Color.FromRgb(255, 255, 255);
			Rojo.TextColor = Color.FromRgb(255, 255, 255);
			Verde.TextColor = Color.FromRgb(255, 255, 255);
			Azul.TextColor = Color.FromRgb(255, 255, 255);
		}
		else
		{
			LabelHex.TextColor = Color.FromRgb(0, 0, 0);
			NombreColor.TextColor = Color.FromRgb(0, 0, 0);
			Rojo.TextColor = Color.FromRgb(0, 0, 0);
			Verde.TextColor = Color.FromRgb(0, 0, 0);
			Azul.TextColor = Color.FromRgb(0, 0, 0);
		}
	}
}