using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Buttond : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject Vb;
    public GameObject obj;
    public GameObject track;
    private AudioSource aud;

    private void Start()
    {
        Vb = GameObject.Find("fourthVB");
        Vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        // Vb.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        // Vb.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased); 
        aud = track.GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        obj.SetActive(true);
        aud.Pause();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        obj.SetActive(false);
        aud.Play();
    }
}

