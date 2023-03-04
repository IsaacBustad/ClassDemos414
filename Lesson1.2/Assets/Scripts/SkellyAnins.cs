// Isaac Bustad
//3/2/2023


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkellyAnins : MonoBehaviour
{
    //vars
    [SerializeField] Rigidbody rb;
    [SerializeField] Animator animator;



    // methods
    public void FixedUpdate()
    {
        CallWalkAnim();
    }

    /* protected void FixedUpdate()
     {
         CallWalkAnim();
     }*/

    protected void CallWalkAnim()
    {
        Vector3 aV3 = rb.velocity;
        aV3.y = 0;

        Debug.Log(animator);
        Debug.Log(animator.gameObject.name);
        animator.SetFloat("Speed", aV3.magnitude);
        animator.SetBool("New Bool", true);

    }

    // accessors




}
