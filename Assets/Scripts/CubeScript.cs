using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Rotation Animation
        transform.Rotate(new Vector3(1,0,0));
    }

    void OnTriggerEnter() {
        // Collect's object
        Destroy(gameObject);
    }
}
