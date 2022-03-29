//8. Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error &quot;El día ingresado no es válido;.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej08 : MonoBehaviour
{
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        switch (nombre)
        {
            case "Jeronimo":
                Debug.Log("profe de mei3d");
                break;
            case "ivo":
                Debug.Log("profe de IOT");
                break;
        case "Ranzo":
                Debug.Log("Profe de front end");
                break;
            default:
                Debug.Log("No es un profe");
                break;
         }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
