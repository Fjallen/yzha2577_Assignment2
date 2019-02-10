using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float playerSpd;
    // Start is called before the first frame update
    void Start()
    {
        playerSpd = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.W)){
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A)) { 
            move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;
        }
        gameObject.transform.position = move * playerSpd + gameObject.transform.position;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
