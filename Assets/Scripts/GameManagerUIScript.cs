using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerUIScript : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
        StickScript.gameOver = false;
    }
}
