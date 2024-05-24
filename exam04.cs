using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exam04 : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //space bar
        if(Input.GetKeyDown(KeyCode.Space)){
            animator.SetBool("IsAtk", true);
        }

         if(Input.GetKeyDown(KeyCode.H)){
            animator.SetBool("ishurt", true);
            animator.SetBool("isexplosion", true);
        }   
        }
    }
