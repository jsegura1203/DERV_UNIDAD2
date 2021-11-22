using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Caminar : MonoBehaviour
{
    Animator animacionCaminar;

    void Start()
    {
        animacionCaminar = this.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            animacionCaminar.SetBool("Caminado", true);
        }
        else
        {
            animacionCaminar.SetBool("Caminado", false);
        }
    }
}
