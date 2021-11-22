using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Personaje_", menuName ="ScriptableObjects/CrearConfigPersonajes", order =1)]
public class SO_Personajes : ScriptableObject
{
    public string nombre;
    public string altura;
    public string peso;
    public Sprite imagen;
}
