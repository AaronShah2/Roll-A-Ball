using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathBlock : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    // Update is called once per frame
    void Update()
    {
        // rotation animation
        transform.Rotate(new Vector3(0,1,0));
    }

    void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        GameOver();
    }

    void GameOver(){
        scoreText.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
    }
}
