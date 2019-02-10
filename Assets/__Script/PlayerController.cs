using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text scoreText;
    private float _playerSpd = 0.1f;
    private int _score;
    public Text wonText;
    // Start is called before the first frame update
    void Start()
    {
        SetScore();
        wonText.text = "";
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
        gameObject.transform.position = move * _playerSpd + gameObject.transform.position;
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
        if (_score == 150)
        {
            wonText.text = "Congratulations! Winner!";
        }
    }
    void SetScore()
    {
        scoreText.text = "Your Score is: " + _score.ToString();
    }
}
