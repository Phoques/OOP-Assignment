using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseZone : TheZone
{

    public GameObject lossPanel;
    public int marbleCount;
    

    protected override void TriggerZone(GameObject marble) // This is required to inheret the behaviour from the 'TheZone' class.
    {

        marbleCount++;

        if(marbleCount== 5) 
        { 
            lossPanel.SetActive(true);

        }

    }


    private void Start()
    {
        
        lossPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyUp(KeyCode.Alpha1)) 
        //{
        //    lossPanel.SetActive(true); ;
        //}
    }
}
