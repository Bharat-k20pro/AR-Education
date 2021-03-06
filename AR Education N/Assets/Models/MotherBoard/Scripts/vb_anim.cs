using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour , IVirtualButtonEventHandler
{     public GameObject vbBtnObj;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
       vbBtnObj= GameObject.Find("Cpu-Button");
       vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
       cubeAni.GetComponent<Animator>();
    }
       public void OnButtonPressed(VirtualButtonBehaviour vb)
       {
           cubeAni.Play("CpuAnim");
           Debug.Log("BTN Presseed");
       }
        public void OnButtonReleased(VirtualButtonBehaviour vb)
       {
           cubeAni.Play("none");
           Debug.Log("BTN Released");
       }
    // Update is called once per frame
    void Update()
    {
        
    }
}
