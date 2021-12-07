/*
 * Creado por SharpDevelop.
 * Usuario: José
 * Fecha: 25/09/2007
 * Hora: 05:25 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asilo_Ancianos_San_Ramon_
{
    [Serializable]
    /// Clase que lee de la consola y transforma en el dato que se necesita
    /// </summary>
    class Leer {
        /// <summary>
        /// Lee una cadena unicode
        /// </summary>
        /// <returns>una cadena leida por consola</returns>
        public static string Cadena() {
            string dato = "";
            try {
                dato = Console.ReadLine();
            }
            catch( Exception e ) {
                Console.WriteLine("Error en la entrada de datos :" + e.Message);
            }
            return dato;
        }
        /// <summary>
        /// Lee un dato short (Int16) con signo, si falla retorna el minimo valor
        /// </summary>
        /// <returns>un short leida por consola</returns>
        public static short Short() {
            short dato = short.MinValue;
            try {
                dato = short.Parse(Cadena());
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato Short, asignado por defecto MinValue");
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto MinValue");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto MinValue");
            }
            return dato;
        }
        /// <summary>
        /// Lee un dato int (Int32) con signo, si falla retorna el minimo valor
        /// </summary>
        /// <returns>un int leida por consola</returns>
        public static int Integer() {
            int dato = int.MinValue;
            try {
                dato = int.Parse(Cadena());
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato int, asignado por defecto MinValue");
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto MinValue");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto MinValue");
            }
            return dato;
        }
        /// <summary>
        /// Lee un dato long (Int64) con signo, si falla retorna el minimo valor
        /// </summary>
        /// <returns>un long leida por consola</returns>
        public static long Long() {
            long dato = long.MinValue;
            try {
                dato = long.Parse(Cadena());
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato Long, asignado por defecto MinValue");
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto MinValue");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto MinValue");
            }
            return dato;
        }
        /// <summary>
        /// Lee un dato float (precision de 7 digitos) ±1,5e-45 a ±3,4e38.
        /// Si falla retorna NaN, se comprueba con isNaN()
        /// </summary>
        /// <returns>un float leido por consola</returns>
        public static float Float() {
            float dato = float.NaN;
            try {
                dato = float.Parse(Cadena());
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto NaN");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto NaN");
            }
            return dato;
        }
        /// <summary>
        /// Lee un dato double (precision de 15 digitos) ±5,0e-324 a ±1,7e308
        /// Si falla retorna NaN, se comprueba con isNaN()
        /// </summary>
        /// <returns>un double leido por consola</returns>
        public static double Double() {
            double dato = double.NaN;
            try {
                dato = double.Parse(Cadena());
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto NaN");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto NaN");
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato double, asignado por defecto NaN");
            }
            return dato;
        }
        /// <summary>
        /// Lee un dato Decimal (precision de 28-29 dígitos), clase que representa cantidades decimales
        /// Si falla retorna NaN, se comprueba con isNaN()
        /// </summary>
        /// <returns>un decimal leido por consola</returns>
        public static decimal Decimal() {
            decimal dato = decimal.MinValue;
            try {
                dato = decimal.Parse(Cadena());
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto MinValue");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto MinValue");
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato Decimal, asignado por defecto MinValue");
            }
            return dato;
        }
        public static bool Bool() {
            bool dato=false;
            try {
                if(Console.ReadKey().KeyChar=='s'){dato=true;}
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un caracter valido");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto false");
            }
            return dato;
        }
     }
}