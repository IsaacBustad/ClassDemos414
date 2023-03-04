using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapCam : MonoBehaviour
{
    //vars
    [SerializeField] protected Transform camTF;

    // methods
    protected void FixedUpdate()
    {
        CallSnapCam();
    }

    protected void CallSnapCam()
    {
        transform.position = camTF.position;
        Vector3 aV3 = camTF.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(aV3.x, aV3.y, aV3.z);
    }

}
