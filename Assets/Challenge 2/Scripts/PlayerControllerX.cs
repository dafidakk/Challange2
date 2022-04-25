using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool has_pressed = false;
    private float startDelay = 1.0f;
    private float spawnInterval;

    void Start()
    {
        spawnInterval = Random.Range(3, 5);
        InvokeRepeating("HasPressed", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (has_pressed)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
        
    }

    void HasPressed()
    {
        has_pressed = true;
    }
}
