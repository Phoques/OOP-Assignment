using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : Zone
{

    protected abstract void PowerUpActivate(GameObject marble);

    protected override void ZoneTrigger(GameObject marble)
    {
        if (!isDeactivating)
        {
            StartCoroutine(DisableWithDelay(gameObject, 2f, 0.5f)); // by putting gameObject in to the parameter, it is saying the gameobject that this script is
            //attached to. Instead of passing in the marble or whatever. This will disable the 'powerup' gameobject.
        }
        PowerUpActivate(marble);
        //if (isDeactivating)
        //{
        //    StartCoroutine(DontDisable(gameObject));
        //}

    }
}
