using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunfoor : MonoBehaviour
{
   private Animator anim;

    private void Start()
    {
        anim = GetComponentInParent<Animator>();
    }


   
    public void Open()
    {
        
            anim.SetBool("Open", true);
        
    }
    public void Close()
    {
        
            anim.SetBool("Open", false);
        
    }

}
