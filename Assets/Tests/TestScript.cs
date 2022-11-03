using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    GameObject _gameGO;
    [SetUp] // This is where you can instantiate or add you references for ALL TESTS
    
    //Before the TEST
    public void Setup()
    {
        _gameGO = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Gameworld"));
    }

    [TearDown]

    //Teardown runs AFTER the test and destroys everything so SETUP can setup a fresh test 
    public void TearDown()
    {
        Object.Destroy(_gameGO);
    }


    [UnityTest]
    public IEnumerator MarbleIsAboveDeathZone()
    {
        // Because this scrip does not inheret from monobehaviour we need to call it below so we can Instantiate

        //This is following the folders


        Rigidbody marble = MonoBehaviour.FindObjectOfType<Rigidbody>();

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSeconds(10f); // This is how long the test runs for. If the test doesnt run long enough to trigger what
        //you're looking for e.g (The ball goes below death zone, then it wont trigger or will PASS.

        //This is doing a check to see if the marble goes below the death zone (Which is at -16f) meaning it PASSED the test.
        //Assert.Less(marble.transform.position.y, -20f);

        //This is doing a check to see if the marble says above the death zone (Which is at -16f) meaning it FAILED the test if it goes below.
        Assert.Greater(marble.transform.position.y, -20f);
    }


    [UnityTest]
    public IEnumerator MarbleFalls()
    {
        //Grabs the reference for the marble
        Rigidbody marble = MonoBehaviour.FindObjectOfType<Rigidbody>();
        //Grabs the marbles current / starting position.
        float yPos = marble.transform.position.y;
        
        yield return new WaitForSeconds(0.5f);


        // Checks to see if marbles position is now LESS than its starting position.
        Assert.Less(marble.transform.position.y, yPos);


    }

}
