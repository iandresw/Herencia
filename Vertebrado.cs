using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vertebrado : Animal
    {
        /// <summary>
        /// Tipo de animal
        /// </summary>
        public string Tipo { get; set; }
        /// <summary>
        /// Tipo de animal
        /// </summary>
        public bool TienePatas {  get; set; }
        /// <summary>
        /// Tipo de animal
        /// </summary>
        public bool EsDomestico { get; set; }
        /// <summary>
        /// Tipo de animal
        /// </summary>
        public bool EsHerbivoro { get; set; }
        /// <summary>
        /// Tipo de animal
        /// </summary>
        public bool EsCarnivoro { get; set; }


        /// <summary>
        /// Imprime cada uno de los atributos
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine("Nombre: "+ Nombre);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Tamanio: " + Tamanio);
            Console.WriteLine("Familia: " + Familia);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine($"Tiene Patas?: {(TienePatas? "Si":"No")}");
            Console.WriteLine($"Es Domestico?: {(EsDomestico ? "Si":"No")}");
            Console.WriteLine($"Es Herviboro: {(EsHerbivoro ? "Si":"No")}");
            Console.WriteLine($"Es Carnivoro: {(EsCarnivoro ? "Si":"No")}");
        }
    }
}
