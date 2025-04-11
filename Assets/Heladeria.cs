using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    // 1. Declaracion de variables

    public string codigoGustoHelado;
    string codigoChocolate = "CHO";
    string codigoFrutilla = "FRU";
    string codigoDulceDeLeche = "DDL";
    public float gramosHelado;
    float precioGramo = 1.25f;
    float precioTotal;

    void Start()
    {
        // 2. Ingreso de datos
        if (gramosHelado > 3000 || gramosHelado < 250)
        {
            Debug.Log("Cantidad Invalida");
            return;
        }

        // 3. Procesamiento de datos

        if (codigoGustoHelado == codigoChocolate || codigoGustoHelado == codigoDulceDeLeche)
        {
            precioTotal = precioGramo * gramosHelado;
        }
        else if (codigoGustoHelado == codigoFrutilla)
        {
            precioTotal = precioGramo * gramosHelado - (precioGramo * gramosHelado) / 10;
        }
        else
        {
            Debug.Log("codigo invalido");
            return;
        }

        // 4. Mostrar resultado
        Debug.Log(precioTotal);
    }

    void Update()
    {
        
    }
}
