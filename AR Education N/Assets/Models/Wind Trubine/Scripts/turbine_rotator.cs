using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbine_rotator : MonoBehaviour
{
   public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }

}
