using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text scoreText;
    private float _playerSpd = 10f;
    private int _score;
    private Rigidbody rb;
    public Text wonText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetScore();
        wonText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * _playerSpd);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Destroy(other.gameObject);
            _score += 10;
        }
        if (other.gameObject.CompareTag("Pick Up1"))
        {
            Destroy(other.gameObject);
            _score += 20;
        }
        if (other.gameObject.CompareTag("Pick Up2"))
        {
            Destroy(other.gameObject);
            _score += 30;
        }
        if (other.gameObject.CompareTag("Pick Up3"))
        {
            Destroy(other.gameObject);
            _score += 40;
        }
        SetScore();
        if (_score == 170)
        {
            wonText.text = "Congratulations! Winner!";
        }
        
    }
    void SetScore()
    {
        scoreText.text = "Your Score is: " + _score.ToString();
    }
}
