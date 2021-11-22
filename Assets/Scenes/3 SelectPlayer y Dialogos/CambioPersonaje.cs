using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CambioPersonaje : MonoBehaviour
{
    [SerializeField]
    public SO_Personajes[] personajes;

    [SerializeField]
    public Image imagen;

    public GameObject ContenedorNotas;
    public GameObject ContenedorLogo;

    [SerializeField]
    public TextMeshProUGUI txt_nombre;
    public TextMeshProUGUI txt_altura;
    public TextMeshProUGUI txt_peso;

    public int index=0;
    void Start()
    {
        index = -1;
    }

    private void Awake()
    {
        ContenedorNotas = GameObject.Find("ContenedorNotas");
        ContenedorNotas.SetActive(false);
        Debug.Log(ContenedorNotas.name);
        ContenedorLogo.SetActive(false);
    }

    public void goAnterior()
    {
        if (index >= 1)
        {
            index--;
            imagen.sprite = personajes[index].imagen;
            txt_nombre.text = personajes[index].nombre;
            txt_altura.text = personajes[index].altura;
            txt_peso.text = personajes[index].peso;
            ContenedorNotas.SetActive(false);
        }
        else
        {
            ContenedorNotas.GetComponentInChildren<TextMeshProUGUI>().text = "Estas en el primer elemento de la lista";
            ContenedorNotas.SetActive(true);
        }

    }   
    
    public void goSiguiente()
    {
        if (index == -1)
            ContenedorLogo.SetActive(true);
        if (index < personajes.Length-1)
        {
            index++;
            imagen.sprite = personajes[index].imagen;
            txt_nombre.text = personajes[index].nombre;
            txt_altura.text = personajes[index].altura;
            txt_peso.text = personajes[index].peso;
            ContenedorNotas.SetActive(false);
        }
        else
        {
            ContenedorNotas.GetComponentInChildren<TextMeshProUGUI>().text = "Estas en el último elemento de la lista";
            ContenedorNotas.SetActive(true);
        }
    }
}
