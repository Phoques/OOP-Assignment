using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostZone : TheZone
{
    [SerializeField] protected float _speed;
    protected override void TriggerZone(GameObject marble)
    {
        Rigidbody rb = marble.GetComponent<Rigidbody>();

        if (!rb) return;

        rb.AddForce(rb.velocity.normalized * _speed, ForceMode.VelocityChange);
    }



   //public BoostZone(float speed)
   // {

   //     _speed = speed;
   // }

   // public BoostZone()
   // {

   // }
}
