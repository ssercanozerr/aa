using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject rotatingCircle;
    public GameObject spawnLocation;
    
    public void GameOver()
    {
        rotatingCircle.GetComponent<RotatingCircleScript>().enabled= false;
        spawnLocation.GetComponent<StickSpawnerScript>().enabled= false;
    }
}
