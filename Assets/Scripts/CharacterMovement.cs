using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject player;
    [SerializeField] float _speed;
    [SerializeField] float _speedBoost;
    //GameObject armCatcher;
    bool isCatching = false;



    void Update()
    {
        MoveCharacter();
    if (Input.GetKey(KeyCode.LeftShift))
        {
            if (!isCatching)
            {
                StartCoroutine(ArmCatcher());
            }
        }
    }


    void MoveCharacter()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDir, 0f, zDir);

        transform.position += moveDirection * _speed * Time.deltaTime;
    }


    IEnumerator ArmCatcher()
    {
        isCatching = true;
        player.transform.localScale = new Vector3(3f, 0.71482f, 0.2492986f);
        yield return new WaitForSeconds(2f);
        player.transform.localScale = new Vector3(1.6501f, 0.71482f, 0.2492986f);
        yield return new WaitForSeconds(10f);
        isCatching= false;
        
    }
}
