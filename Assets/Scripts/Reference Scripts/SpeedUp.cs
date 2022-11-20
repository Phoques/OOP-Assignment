using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Powerup
{

    [SerializeField] protected float _speed;
    protected override void PowerUpActivate(GameObject marble)
    {
        Rigidbody rb = marble.GetComponent<Rigidbody>();

        if (!rb) return;

        rb.AddForce(rb.velocity.normalized * _speed, ForceMode.VelocityChange); // this wont work if te marble isnt moving, because velocity would be zero.
        //Addforce (to thedirection the marble is heading, in this circumstance the velocity which points in the way the marble is heading.
        //Normalise creates a vector magnitude, so that regardless of marble speed, the force added will always be the same.
        //forcemode.velocitychange is a particular force mode, in this circumstance it Adds instant velocity to the rigid body, but ignores mass.

        //Unity API FORCEMODE for good physics info.
    }

}
