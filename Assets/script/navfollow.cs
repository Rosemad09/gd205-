using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navfollow : MonoBehaviour

{
    NavMeshAgent agent;
    Animator animator;
    public Transform target;
    
    void Start()
    {
    agent = GetComponent<NavMeshAgent>();
    animator = GetComponent<Animator>();
    }

    void Update()
    {
       Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(laser, out hit)){
            if (Input.GetMouseButton(0)){
                agent.SetDestination(hit.point); 


            } 
        }
    
     if(agent.velocity == vector3.zero ){
        animator.SetBool("moving",false);
       } else {
        animator.SetBool("moving",true);
        }
     
    
    
    }

}
