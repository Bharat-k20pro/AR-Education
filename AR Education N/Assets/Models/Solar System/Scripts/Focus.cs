using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focus : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject o5;
    public GameObject o6;
    public GameObject o7;
    public GameObject o8, o9, o10, o11, o12, o13, o14, o15, o16, o17;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FocusPlanet()
    {
        obj.SetActive(true);

        o1.SetActive(false);
        o2.SetActive(false);
        o3.SetActive(false);
        o4.SetActive(false);
        o5.SetActive(false);
        o6.SetActive(false);
        o7.SetActive(false);
        o8.SetActive(false);
        o9.SetActive(false);

        o10.SetActive(false);
        o11.SetActive(false);
        o12.SetActive(false);
        o13.SetActive(false);
        o14.SetActive(false);
        o15.SetActive(false);
        o16.SetActive(false);
        o17.SetActive(false);

    }

    public void getSS()
    {
        o1.SetActive(true);
        o2.SetActive(true);
        o3.SetActive(true);
        o4.SetActive(true);
        o5.SetActive(true);
        o6.SetActive(true);
        o7.SetActive(true);
        o8.SetActive(true);
        o9.SetActive(true);

        obj.SetActive(false);
        o10.SetActive(false);
        o11.SetActive(false);
        o12.SetActive(false);
        o13.SetActive(false);
        o14.SetActive(false);
        o15.SetActive(false);
        o16.SetActive(false);
        o17.SetActive(false);

    }
}
