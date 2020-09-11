using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{


	[OperationContract]
	float Ejercicio1(float x, float y);

	[OperationContract]
	String Ejercicio2(int x, int y);

	[OperationContract]
	CompositeType Ejercicio3(CompositeType comp);

	[OperationContract]
	dynamic Ejercicio4(int x, int y);
}


// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	int resultado = 0;
	string stringValue = "";

	[DataMember]
	public int Resultado
	{
		get { return resultado; }
		set { resultado = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}

