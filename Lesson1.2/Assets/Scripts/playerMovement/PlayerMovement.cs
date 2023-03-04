// Isaac Bustad

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // vars
    [SerializeField] protected float maxMoveSpeed;
    
    [SerializeField] protected float accel = 50;
    [SerializeField] protected Rigidbody rb;
    protected Vector2 moveIn;
    protected Vector3 moveDir;
    
    protected float limit = 6f;


    // methods
    private void Start()
    {
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    


    public void ReadInMove(InputAction.CallbackContext context)
    {
        moveIn = context.ReadValue<Vector2>();
    }

    // move
    protected void MovePlayer()
    {
        Vector3 aV3 = new Vector3();
        aV3.x = moveIn.x;
        aV3.z = moveIn.y;
        moveDir = aV3;

        rb.AddForce(moveDir * 50, ForceMode.Force);
        VelocityLimmiter();
    }

    public void RotPlayer(InputAction.CallbackContext context)
    {
        if(context.started == true)
        {
            Vector3 aV3 = new Vector3(10f, 0f, 0f);
            transform.Rotate(aV3);
        }
        
    }

    #region Vel
    //limmit vel
    protected void VelocityLimmiter()
    {
        Vector3 aV3 = new Vector3();
        if (rb.velocity.x > maxMoveSpeed) { aV3.x = maxMoveSpeed; }
        if (rb.velocity.z > maxMoveSpeed) { aV3.z = maxMoveSpeed; }
        if (rb.velocity.y > limit) { aV3.y = limit; }
        aV3.y = rb.velocity.y;

        rb.velocity = aV3;
    }
    #endregion


}
