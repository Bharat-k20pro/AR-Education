using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowcontroller : MonoBehaviour
{
    public Animator shadowE;

   
    void start()
    {
        shadowE.enabled = false;
    }

    private void OnCollisiononEnter(Collision collision)
    {
        if (collision.collider.name == "Cylinder")
        {
            shadowE.enabled = true;

        }
    }
}
