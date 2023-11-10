using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickSpawnerScript : MonoBehaviour
{
    public GameObject stick;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StickSpawn();
        }
    }

    void StickSpawn()
    {
        Instantiate(stick,transform.position, transform.rotation);
    }
}
