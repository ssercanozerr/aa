using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIScript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
        StickScript.gameOver = false;
    }
}
