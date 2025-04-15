using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CualEspecialidad : MonoBehaviour
{
    public int anio;
    public string nombre;
    public string especialidad;

    // Start is called before the first frame update
    void Start()
    {
       

        if (anio < 3 || anio > 5)
        {
            Debug.Log("Año no valido");
            return;
        }
              
        else if (string.IsNullOrEmpty(nombre))
        {
            Debug.Log("Escribe algo en nombre");
            return;
        }

        else if (especialidad == "G" || especialidad == "T" || especialidad == "H" || especialidad == "M" || especialidad == "D")
        {
            Debug.Log("Muchas gracias " + nombre);
        }

        else
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
