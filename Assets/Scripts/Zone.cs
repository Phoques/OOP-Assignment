using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //Abstract means, we cant create an instance of this class / componenet of this class, as in this cannot be added to anything at all.
public abstract class Zone : MonoBehaviour
{//Zone class base class  ---> WinZone
 //                       ---> LoseZone
 //                      -->Powerup
 //This is polymorphism as we are inhereting a class, then changing things.
    protected abstract void ZoneTrigger(GameObject marble); // abstract means that this function is not going to be created here.
    //Code for tis funcytion is going to be written in child / derived classes.

    protected bool isDeactivating = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!gameObject.activeSelf) return; // The gameobject.activeself checks to see if the game object is active, e.g below 'setactive = false' it will return.
        if (other.tag == "Marble")
        {
        ZoneTrigger(other.gameObject);
        }
    }

    protected IEnumerator DisableWithDelay(GameObject go, float delay, float returnDelay) // go is the variable set, can be called anything
    {//The reason we can have two coroutines / functins with the same name is because they have different parameters. this is called OVERLOADING

        isDeactivating = true;
        
        yield return new WaitForSeconds(delay);
        go.SetActive(false);

        yield return new WaitForSeconds(returnDelay);
        go.SetActive(true);

        isDeactivating = false;

        //yield break; will stop a coroutine, so you could set a bool trigger, to yield break out of the coroutine.
    }

    protected IEnumerator DisableWithDelay(GameObject go, float delay = 1f) // go is the variable set, can be called anything
    {
        isDeactivating = true;

        yield return new WaitForSeconds(delay);

        go.SetActive(false);

        isDeactivating = false;

    }

}
