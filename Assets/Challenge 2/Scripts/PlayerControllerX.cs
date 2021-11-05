using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool cooldown = false;
    public float spawnTime = 2f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& !cooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = true;
            Invoke("EnableSpawn", spawnTime);
        }
    }
    void EnableSpawn(){
        cooldown = false;
    }
}
