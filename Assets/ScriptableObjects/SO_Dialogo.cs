using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogo_", menuName ="ScriptableObjects/CrearDialogo", order =3)]
public class SO_Dialogo : ScriptableObject
{
    [System.Serializable]
    public struct dialogo
    {
        [SerializeField]
        public SO_Personajes personaje;

        [SerializeField]
        [TextArea(2,5)]
        public string mensaje;
    }

    public dialogo[] dialogos;

    public int getContDialogo()
    {
        return dialogos.Length;
    }

    public string getDialogo(int index)
    {
        return dialogos[index].mensaje;
    }

    public Sprite getImagen(int index)
    {
        return dialogos[index].personaje.imagen;
    }
}
