using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private bool ActivitySwitch;
    public GameObject sunfoorObject;
    private Sunfoor sunfoor;


    private void Start()
    {
       sunfoor = sunfoorObject.GetComponent<Sunfoor>();
    }

    private void Update()
    {
        if (ActivitySwitch)
        {
            Active();
        }
        else
        {
            InActive();
        }
    }
    private void Active()
    {
       sunfoor.Open();
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void InActive()
    {
       sunfoor.Close();
        gameObject.GetComponent<Renderer>().material.color = Color.gray;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       
            ActivitySwitch = true;
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
            ActivitySwitch = false;
    }

    
}
