using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    [SerializeField]
    public SO_Dialogo dialogos;

    public TextMeshProUGUI mensaje;
    public Image imagen;

    int i=0;
    int imax;
    // Start is called before the first frame update
    void Start()
    {
        i = -1;
        imax = dialogos.getContDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(i>=1)
            {
                i--;
                mensaje.text = dialogos.getDialogo(i);
                imagen.sprite = dialogos.getImagen(i);
            }
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            if(i< imax-1)
            {
                i++;
                mensaje.text = dialogos.getDialogo(i);
                imagen.sprite = dialogos.getImagen(i);
            }
        }
    }

}
