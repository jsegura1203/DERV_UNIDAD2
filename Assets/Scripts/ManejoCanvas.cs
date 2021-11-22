using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class ManejoCanvas : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txt_dialogo;
    GameObject obj;
    void Start()
    {
        obj = GameObject.Find("Canvas");
        StartCoroutine(corutina());
    }

    IEnumerator corutina()
    {
        yield return new WaitForSeconds(4);
        obj.SetActive(false);
    }

    public void detectarNuevoTrigger(String texto)
    {
        obj.SetActive(true);
        txt_dialogo.text = texto;
        StartCoroutine(corutina());
    }
}
