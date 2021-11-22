using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    [SerializeField]
    GameObject objeto_a_Mirar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        look_at();
    }


    public void look_at()
    {
        Vector3 posicion = objeto_a_Mirar.transform.position;
        posicion.y = 0;
        this.transform.LookAt(posicion);
    }
}
