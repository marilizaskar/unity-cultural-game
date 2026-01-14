using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushAletriMeAlogo : MonoBehaviour
{
    public float pushstrength = 6.0f;
    
        
    // Start is called before the first frame update
     void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
        {
            return;
        }
        if (hit.moveDirection.y<-0.3f)
        {
            return;
        }
        
        Vector3 direction = new Vector3(hit.moveDirection.x,0,hit.moveDirection.z);
        body.velocity=direction * pushstrength;
       
    }

    private Vector3 Vector3(float x, int v, float z)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {
       
    }
}
