using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeToGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;

        Player.player_health = 5;
    }

    public void ChangeToMain() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }

    public void Shutdown()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
