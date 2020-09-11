using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{


	public float Ejercicio1(float x, float y)
    {
		float resultado = x / y;
		return resultado;
    }
	public string Ejercicio2(int x, int y)
	{
		if( x % y == 0)
        {
			return "Es multiplo";
		}
        else
        {
			return "No es multiplo";
        }
	}
	public dynamic Ejercicio3<int, string>(int x, int y)
	{
		if((x ==0) | (y == 0))
        {
			string resultado = "El producto de 0 por cualquier numero es 0";
			return resultado;
        }
        else
        {
			return x * y;
        }
	}

	public dynamic Ejercicio4(int x, int y)
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
}
