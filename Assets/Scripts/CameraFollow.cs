using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 camOffset;


    private void Update()
    {
        transform.position = player.position + camOffset;
    }

}
