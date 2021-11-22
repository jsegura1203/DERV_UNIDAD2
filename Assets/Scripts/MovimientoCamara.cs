using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    //Velocidades en X Y 
    [SerializeField]
    float x = 20;
    [SerializeField]
    float y = 10;

    float ejeRotacion_objeto;
    float ejeRotacion_Camara;

    Rigidbody cuerpoRigido;

    [SerializeField]
    GameObject camara;

    private void FixedUpdate()
    {
        ejeRotacion_objeto = Input.GetAxis("Mouse X");
        ejeRotacion_Camara += Input.GetAxis("Mouse Y") * x;

        transform.Rotate(0, ejeRotacion_objeto * y, 0);

        ejeRotacion_Camara = Mathf.Clamp(ejeRotacion_Camara, -25, 25);
        camara.transform.localEulerAngles = new Vector3(-ejeRotacion_Camara, 0f, 0f);
    }
}
