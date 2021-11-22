using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_At : MonoBehaviour
{
    [SerializeField]
    GameObject objeto_a_Mirar;
    bool bandera = false;
    // Update is called once per frame
    void Update()
    {
        if (bandera)
        {
            look_at();
        }
    }

    public void look_at()
    {
        //transform.LookAt(objeto_a_Mirar.transform);
        //Obtener la posicion del objeto a mirar.
        Vector3 posicion = objeto_a_Mirar.transform.position;
        //posicion.y = 0;
        this.transform.LookAt(posicion);
        bandera = true;
    }
}
