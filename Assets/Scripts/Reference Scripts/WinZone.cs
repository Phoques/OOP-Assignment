using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZone : Zone
{
    [SerializeField] protected Text _winnerText;
    protected List<GameObject> _winners;
    
    protected void Start() // making everythig protected is so that if we want to make changes later we can override in other classes, keeps it open
    {
        if(_winners == null)
        {
        _winners = new List<GameObject>();
        _winnerText.text = "";
        }

    }

    protected void DisplayWinningText(string marbleName)
    {
        _winnerText.text += marbleName + "\n";
    }

    protected override void ZoneTrigger(GameObject marble)
    {
        if (!_winners.Contains(marble))
        {
        _winners.Add(marble);
        }
        DisplayWinningText(marble.name);
        StartCoroutine(DisableWithDelay(marble)); // marble is 'go' we can pass any gameobject in through here.
        //Coroutines only run once, unless you do a loop. Never put coroutines into update as it will run many instances.
        //You can have the same Coroutine run on many different objects, they are independant.

        //We can run this coroutine, because it inherets from Zone, and the coroutine is in Zone.
    }

    

}
