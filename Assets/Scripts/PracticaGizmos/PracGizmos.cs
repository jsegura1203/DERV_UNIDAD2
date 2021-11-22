using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracGizmos : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 3);
        Gizmos.DrawCube(transform.position+new Vector3(0,1.1f,0), new Vector3(3,3,3));
        Gizmos.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * 50);
    }
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 3.0f);
    }
}
