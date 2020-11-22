using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Ball Speed
    public float speed = 10f;
    // Player's Score
    private int score = 0;
    // UI Score Text
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // Adding force to our ball when game begins
        GetComponent<Rigidbody>().AddForce(new Vector3(50, 500,50));
    }

    // Update is called once per frame
    void Update()
    {
        // Varieables that handle User input
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        // Apply direction to ball using variables we created above
        GetComponent<Rigidbody>().AddForce(new Vector3(horizontalMove*speed,0, verticalMove*speed));
    }

    void OnTriggerEnter() {
        score = score + 10;
        scoreText.text = "Score:" + score;
    }
}
