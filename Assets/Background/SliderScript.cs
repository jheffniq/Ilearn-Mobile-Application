using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour
{       
    public GameObject Info;

    public void ToggleInfo()
    {
       if(Info != null){
        Animator animator = Info.GetComponent<Animator>();
        if(animator != null){
            bool isOpen = animator.GetBool("Slide");
            animator.SetBool("Slide", !isOpen );
        }
       }
    }
}
