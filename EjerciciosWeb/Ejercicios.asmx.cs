using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EjerciciosWeb
{
    /// <summary>
    /// Descripción breve de Ejercicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Ejercicios : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public float Ejercicio1(float x, float y)
        {
            float resultado = x / y;
            return resultado;
        }

        [WebMethod]
        public string Ejercicio2(int x, int y)
        {
            if (x % y == 0)
            {
                return "Es multiplo";
            }
            else
            {
                return "No es multiplo";
            }
        }

        [WebMethod]
        public dynamic Ejercicio3(int x, int y)
        {
            if ((x == 0) | (y == 0))
            {
                string resultado = "El producto de 0 por cualquier numero es 0";
                return resultado;
            }
            else
            {
                return x * y;
            }
        }

        [WebMethod]
        public dynamic Ejercicio4(int x, int y)
        {
            if ((y == 0))
            {
                string resultado = "Error: No se puede dividir entre cero.";
                return resultado;
            }
            else
            {
                return x / y;
            }
        }

        [WebMethod]
        public string Ejercicio5(char letra)
        {
            letra = Char.ToLower(letra);
           if((letra.ToString()== "a") || (letra.ToString() == "e") || (letra.ToString() == "i") || (letra.ToString() == "o") || (letra.ToString() == "u"))
            {
                return "Es vocal";
            }
            else
            {
                return "No es vocal";
            }
        }

        [WebMethod]
        public string Ejercicio6(int x, int y)
        {
            int cantidad = 0;

            cantidad = x >= 0 ? cantidad + 1 : cantidad;

            cantidad = y >= 0 ? cantidad + 1 : cantidad;

            string resultado;

            resultado = cantidad == 2 ? "Los dos números son positivos" : cantidad == 1 ? "Uno de los números es positivo" : "Niguno de los números es positivo";

            return resultado;
        }

        [WebMethod]
        public int Ejercicio7(int num)
        {

            num = num >= 0 ? num : num * -1;


            return num;
        }

        [WebMethod]
        public void Ejercicio8()
        {
            int x = 1;
            while(x <= 10 )
            {
                Console.WriteLine(x);
                x = x + 1;
            }
        }

        [WebMethod]
        public void Ejercicio9()
        {
            int x = 26;
            while (x >= 10)
            {
                Console.WriteLine(x);
                x = x - 2;
            }
        }

        [WebMethod]
        public void Ejercicio10()
        {
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x = x + 1;

            } while (x <= 10);
        }

        [WebMethod]
        public void Ejercicio11()
        {
            int x = 26;
            do
            {
                Console.WriteLine(x);
                x = x - 2;

            } while (x >= 10);
        }

        [WebMethod]
        public void Ejercicio12()
        {
            int x = 15;
            
            while (x >= 5)
            {
                Console.WriteLine(x);
                x = x - 1;
            }
        }

        [WebMethod]
        public void Ejercicio13()
        {
            int x = 0;

            for(int i = 0; i<8; i++)
            {
                x = x + 2;
                Console.WriteLine(x);
            }
        }

        [WebMethod]
        public void Ejercicio14()
        {

            for (int i = 1; i <= 50; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        [WebMethod]
        public string Ejercicio15(int[] vector)
        {
            int menor = vector[0];
            bool repite = false;
            bool seRepite = false;
            int cantidadNum = vector.Length;
            for (int i = 0; i < cantidadNum; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            for (int i = 0; i < cantidadNum; i++)
            {
                if (vector[i] == menor)
                {
                    if(repite)
                    {
                        seRepite = true;
                        break;
                    }
                    else
                    {
                        repite = true;
                    }
                }

               
            }
            if(seRepite)
            {
                return "El menor numero es " + menor + " y se repite";
            }
            else
            {
                return "El menor numero es " + menor + " y no se repite";
            }
            
        }

        [WebMethod]
        public int[] Ejercicio16(int[] vector)
        {

            Array.Sort(vector);

            return vector;

        }

        [WebMethod]
        public string[] Ejercicio17(string[] vector)
        {

            Array.Sort(vector);

            return vector;

        }

        [WebMethod]
        public void Ejercicio18(string[] paises, int[] habitantes)
        {
            List<string> vectorTemporal = new List<string>();
            List<int> vectorTemporal2 = new List<int>();

            foreach (string elemento in paises)
            {
                vectorTemporal.Add(elemento);
            }

            foreach (int elemento in habitantes)
            {
                vectorTemporal2.Add(elemento);
            }

            List<int> orden = new List<int>();
            List<int> orden2 = new List<int>();
            List<int> ordenHabitantes = new List<int>();
            List<string> ordenPaises = new List<string>();

            vectorTemporal.Sort();
            vectorTemporal2.Sort();

            foreach (string elemento in vectorTemporal)
            {
                for(int i = 0; i < 5; i++)
                {
                    if(elemento == paises[i])
                    {
                        orden.Add(i);
                    }
                }
            }

            foreach (int elemento in vectorTemporal2)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (elemento == habitantes[i])
                    {
                        orden2.Add(i);
                    }
                }
            }

            foreach (int elemento in orden)
            {
                ordenHabitantes.Add(habitantes[elemento]);
            }

            foreach (int elemento in orden2)
            {
                ordenPaises.Add(paises[elemento]);
            }

            Console.WriteLine("Paises organizados alfabeticamente:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vectorTemporal[i] + " tiene " + ordenHabitantes[i] + " habitantes");
            }
            Console.WriteLine("Paises organizados por numero de habitantes:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ordenPaises[i] + " tiene " + vectorTemporal2[i] + " habitantes");
            }


        }

        [WebMethod]
        public int[][] Ejercicio19(int[] primeraFila, int[] segundaFila)
        {
            int[][] matriz = new int[2][];

            matriz[0] = primeraFila;
            matriz[1] = segundaFila;

            foreach(int[] elemento in matriz)
            {
                Console.WriteLine("Columna:");
                foreach(int subelemento in elemento)
                {
                    Console.WriteLine(subelemento);
                }
            }

            return matriz;



        }

        [WebMethod]
        public void Ejercicio20(string p1, string p2, string p3, string p4, double p1t1, double p1t2, double p1t3, double p2t1, double p2t2, double p2t3, double p3t1, double p3t2, double p3t3)
        {

            Console.WriteLine("Temperaturas mensuales");
            Console.WriteLine("Las temperatura mensuales de " + p1 + " son " + p1t1 + " " + p1t2 + " " + p1t3);
            Console.WriteLine("Las temperatura mensuales de " + p2 + " son " + p2t1 + " " + p2t2 + " " + p2t3);
            Console.WriteLine("Las temperatura mensuales de " + p3 + " son " + p3t1 + " " + p3t2 + " " + p3t3);


            double tempm1 = ((p1t1 + p1t2 + p1t3) / 3);
            double tempm2 = ((p2t1 + p2t2 + p2t3) / 3);
            double tempm3 = ((p3t1 + p3t2 + p3t3) / 3);


            Console.WriteLine("Temperaturas trimestrales");
            Console.WriteLine("La temperatura media de " + p1 + " es " + tempm1);
            Console.WriteLine("La temperatura media de " + p2 + " es " + tempm2);
            Console.WriteLine("La temperatura media de " + p3 + " es " + tempm3);

            string mayor = tempm1 > tempm2 ? (tempm1 > tempm3 ? "La mayor es la temperatura del país " + p1 : "La mayor es la temperatura del país " + p3) : tempm2 > tempm3 ? "La mayor es la temperatura del país " + p2 : "La mayor es la temperatura del país " + p3;

            Console.WriteLine(mayor);
        }

        [WebMethod]
        public int[][] Ejercicio21(int[] primeraFila, int[] segundaFila, int[] terceraFila, int[] cuartaFila, int[] quintaFila)
        {
            int[][] matriz = new int[5][];

            matriz[0] = primeraFila;
            matriz[1] = segundaFila;
            matriz[2] = terceraFila;
            matriz[3] = cuartaFila;
            matriz[4] = quintaFila;

            foreach (int[] elemento in matriz)
            {
                Console.WriteLine("Columna:");
                foreach (int subelemento in elemento)
                {
                    Console.WriteLine(subelemento);
                }
            }

            return matriz;



        }
        [WebMethod]
        public void Ejercicio22(string[] empleado, int[][] falto)
        {
            for (int i = 0; i < empleado.Length; i++)
            {
                Console.WriteLine("El empleado " + empleado[i] +" faltó " + falto[i].Length + " días");
            }

            int menorFaltas = falto[0].Length;
            string menorEmpleado = empleado[0];
            for (int i = 1; i < falto.Length; i++)
            {
                if (falto[i].Length < menorFaltas)
                {
                    menorFaltas = falto[i].Length;
                    menorEmpleado = empleado[i];
                }
            }
            Console.WriteLine("El empleado " + menorEmpleado + " es el que menos faltó, solo tuvo " + menorFaltas + " faltas.");
        }

















    }
}
