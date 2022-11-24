using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TheZone : MonoBehaviour
{

    protected abstract void TriggerZone(GameObject marble); // This is setting up a GameObject variable to be checked.

    private void OnTriggerEnter(Collider other)
    {
        if (!gameObject.activeSelf) return; // The gameobject.activeself checks to see if the game object is active, e.g below 'setactive = false' it will return.
        if (other.tag == "Marble") // If the tag is Marble, when colliding,
        {
            TriggerZone(other.gameObject); // Set the variable here to be passed on as the 'marble' variable in other zone derived classes.
        }
    }

}