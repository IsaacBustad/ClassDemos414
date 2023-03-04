using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotate : MonoBehaviour
{
    // Vars
    [SerializeField] protected float rotSpeed = 10;
    [SerializeField] protected Transform pTF;


    // methods
    public void RotatePlayer(InputAction.CallbackContext context)
    {
        float xRot = context.ReadValue<Vector2>().x;
        Vector3 aV3 = new Vector3(0, xRot, 0);
        pTF.Rotate(aV3);
    }


    // accessors
    

}
