using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectar_LA : MonoBehaviour
{
    GameObject Amigo; GameObject Amiga; 
    Look_At script; Look_At script2; 
    ManejoCanvas canva;
    void Start()
    {
        Amigo = GameObject.Find("Amigo");
        script = Amigo.GetComponent<Look_At>();
        Amiga = GameObject.Find("Amiga");
        script2 = Amiga.GetComponent<Look_At>();

        canva = this.GetComponent<ManejoCanvas>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Se ejecuta el look at the cada amigo
        script.look_at();
        script2.look_at();
        //Se detecta el trigger para aparecer el canva
        canva.detectarNuevoTrigger("Amigos: porfin te encontramos!");
        //Se borra el trigger
        other.enabled = false;
    }
}
