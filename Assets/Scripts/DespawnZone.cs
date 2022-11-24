using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnZone : TheZone
{
    protected override void TriggerZone(GameObject marble)
    {
        marble.SetActive(false);
    }

}
