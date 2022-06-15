using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject Player;

    [SerializeField]
    GameObject Mobs;

    [SerializeField]
    TextMeshProUGUI CountNumber;

    [SerializeField]
    GameObject GameOverUI;

    [SerializeField]
    GameObject GameStopUI;

    [SerializeField]
    TextMeshProUGUI Score;

    [SerializeField]
    TextMeshProUGUI LastScore;

    float score = 0;

    float lastscore = 0;

    bool startGame = false;

    bool esc = false;
    bool checkCount = false;

    public static bool endGame = false;

    // Start is called before the first frame update
    void Start()
    {
        esc = false;
        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        Dead();
        SetText();
        Stop();
        if (startGame)
            score += Time.deltaTime;
    }

    void SetText() {
        Score.text = "SCORE : " + string.Format("{0 : 0.00}", score);
        LastScore.text = "SCORE : " + string.Format("{0 : 0.00}", lastscore);
    }

    void Stop()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && esc == false)
        {
            esc = true;
            lastscore = score;
            Time.timeScale = 0;
            GameStopUI.SetActive(true);
            if (CountNumber.gameObject.activeSelf)
            {
                CountNumber.gameObject.SetActive(false);
                checkCount = true;

            }


        }
        else if (Input.GetKeyDown(KeyCode.Escape) && esc)
        {
            esc = false;
            GameStopUI.gameObject.SetActive(false);
            if (checkCount)
            {
                CountNumber.gameObject.SetActive(true);
                checkCount = false;
            }
            Time.timeScale = 1;
        }
    }

    void Dead() {
        if (endGame == true) {
            lastscore = score;
            startGame = false;
            score = 0;
            Time.timeScale = 0;
            GameOverUI.SetActive(true);
            endGame = false;
        }
    }

    void OffScripts()
    {
        Player.GetComponent<PlayerMove>().enabled = false;
        Player.GetComponent<Player>().enabled = false;
        Mobs.GetComponent<GenerateMop>().enabled = false;
    }


    void SetScripts() {
        Player.GetComponent<PlayerMove>().enabled = true;
        Player.GetComponent<Player>().enabled = true;
        Mobs.GetComponent<GenerateMop>().enabled = true;
    }

    IEnumerator StartGame() {
        CountNumber.gameObject.SetActive(true);
        GameOverUI.SetActive(false);
        GameStopUI.SetActive(false);
        CountNumber.text = "3";
        yield return new WaitForSeconds(1f);
        CountNumber.text = "2";
        yield return new WaitForSeconds(1f);
        CountNumber.text = "1";
        yield return new WaitForSeconds(1f);
        CountNumber.text = "START!";
        yield return new WaitForSeconds(1f);
        startGame = true;
        CountNumber.gameObject.SetActive(false);
        SetScripts();
        yield return null;

    }

}
