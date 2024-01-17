using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD5T2v2.MVVM.Models
{
    // Clase que representa el modelo BMI y implementa la interfaz INotifyPropertyChanged
    public class BMI : INotifyPropertyChanged
    {
        // Campo privado para altura
        public float altura;

        // Propiedad pública para la altura con notificación de cambios
        public float Altura
        {
            get { return altura; }
            set
            {
                if (altura != value)
                {
                    altura = value;
                    // Notificar cambios en las propiedades relacionadas con la altura
                    OnPropertyChanged(nameof(Altura));
                    OnPropertyChanged(nameof(Resultado));
                    OnPropertyChanged(nameof(ResultadoBMI));
                }
            }
        }

        // Campo privado para peso
        public float peso;

        // Propiedad pública para el peso con notificación de cambios
        public float Peso
        {
            get { return peso; }
            set
            {
                if (peso != value)
                {
                    peso = value;
                    // Notificar cambios en las propiedades relacionadas con el peso
                    OnPropertyChanged(nameof(Peso));
                    OnPropertyChanged(nameof(Resultado));
                    OnPropertyChanged(nameof(ResultadoBMI));
                }
            }
        }

        // Propiedad pública que calcula el resultado BMI
        public float Resultado
        {
            get
            {
                if (Altura != 0)
                {
                    // Fórmula para calcular el BMI
                    return Peso / (Altura * Altura) * 10000;
                }
                else
                {
                    return 0;
                }
            }
        }

        // Propiedad pública que devuelve una cadena según el valor del resultado BMI
        public string ResultadoBMI
        {
            get
            {
                if (Resultado <= 16)
                {
                    return "BMI: Delgado Severo";
                }
                else if (Resultado <= 17)
                {
                    return "BMI: Delgado Moderado";
                }
                else if (Resultado <= 18.5)
                {
                    return "BMI: Delgado Medio";
                }
                else if (Resultado <= 25)
                {
                    return "BMI: Normal";
                }
                else if (Resultado <= 30)
                {
                    return "BMI: Sobrepeso";
                }
                else if (Resultado <= 35)
                {
                    return "BMI: Obesidad Clase I";
                }
                else if (Resultado <= 40)
                {
                    return "BMI: Obesidad Clase II";
                }
                else
                {
                    return "BMI: Obesidad Clase III";
                }
            }
        }

        // Evento de notificación de cambio de propiedad
        public event PropertyChangedEventHandler? PropertyChanged;

        // Método para invocar el evento PropertyChanged y notificar cambios en las propiedades
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
