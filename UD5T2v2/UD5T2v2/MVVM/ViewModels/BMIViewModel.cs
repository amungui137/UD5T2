using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD5T2v2.MVVM.Models;

namespace UD5T2v2.MVVM.ViewModels
{
    // Clase que representa el ViewModel para la lógica de presentación de la aplicación
    public class BMIViewModel
    {
        // Campo privado que representa el modelo BMI
        private BMI bmi;

        // Propiedad pública que expone el modelo BMI
        public BMI BMI
        {
            get; set; // Propiedad con getter y setter para acceder al modelo BMI
        }

        // Constructor de la clase BMIViewModel
        public BMIViewModel()
        {
            // Inicializa el objeto BMI con un peso inicial de 50 y una altura inicial de 25
            BMI = new BMI { Peso = 50, Altura = 25 };
        }

    }
}
