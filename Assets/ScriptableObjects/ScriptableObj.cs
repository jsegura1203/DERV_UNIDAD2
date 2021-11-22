using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Config_cubo", menuName ="ScriptableObjects/CrearConfigCubo", order =2)]
public class ScriptableObj : ScriptableObject
{
    public Color color;
    public Material material;
}
