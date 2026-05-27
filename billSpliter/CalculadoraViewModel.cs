using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyMauiApp.ViewModels
{
    public partial class CalculadoraViewModel : ObservableObject
    {
        // Propiedades de Entrada con enlace bidireccional //

        [ObservableProperty]
        private decimal _totalCuenta;

        [ObservableProperty]
        private int _numeroPersonas = 1;

        [ObservableProperty]
        private double _porcentajePropina;

        // Propiedades de Salida para los resultados //

        [ObservableProperty]
        private decimal _propinaPorPersona;

        [ObservableProperty]
        private decimal _subtotalPorPersona;

        [ObservableProperty]
        private decimal _totalPorPersona;

        // Observadores de Cambio (Disparadores Automáticos) //

        partial void OnTotalCuentaChanged(decimal value) => CalcularTodo();
        partial void OnNumeroPersonasChanged(int value) => CalcularTodo();
        partial void OnPorcentajePropinaChanged(double value){
            var redondeado = Math.Round(value, 1);
            if (Math.Abs(redondeado - value) > 0.0001)
                PorcentajePropina = redondeado; // esto vuelve a disparar el método, ya redondeado
            else
                CalcularTodo(); // solo calcula cuando ya está limpio
        }
        // --- Lógica de la calculadora ---

        private void CalcularTodo()
        {
            if (NumeroPersonas <= 0) NumeroPersonas = 1;

            decimal propinaTotal = TotalCuenta * ((decimal)PorcentajePropina / 100m);

            SubtotalPorPersona = TotalCuenta / NumeroPersonas;
            PropinaPorPersona = propinaTotal / NumeroPersonas;
            TotalPorPersona = SubtotalPorPersona + PropinaPorPersona;
        }

        // --- Comandos enlazados a la Interfaz de Usuario ---

        [RelayCommand]
        private void SetPropina(int porcentaje)
        {
            PorcentajePropina = porcentaje;
        }

        [RelayCommand]
        private void IncrementarPersonas()
        {
            NumeroPersonas++;
        }

        [RelayCommand]
        private void DisminuirPersonas()
        {
            if (NumeroPersonas > 1)
            {
                NumeroPersonas--;
            }
        }
    }
}
