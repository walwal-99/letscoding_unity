using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField]
    public static float player_health = 5;
    bool star;
    bool isAttacked;
    float time = 0;

    /// life
    [SerializeField]
    TextMeshProUGUI Life;

    [SerializeField]
    GameObject UserPanel;

    // Start is called before the first frame update
    void Start()
    {
        UserPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SetPlayer();
        SetText();
    }

    void SetText()
    {
        Life.text = "Life : " + (player_health).ToString();

    }

    void SetPlayer()
    {
        IsDead();
        if (isAttacked)
        {
            star = true;
            IsAttacked();
        }
    }

    /// 공격을 받을 경우 3초동안 무적
    void IsAttacked()
    {

        if (time >= 2)
        {
            star = false;
            time = 0;
            isAttacked = false;
        }
        time += Time.deltaTime;
    }


    /// 플레이어 hp가 0이 될 경우 사망
    void IsDead()
    {

        if (player_health <= 0)
        {
            Destroy(gameObject);
            GameManager.endGame = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mob") && star != true)
        {
            Debug.Log("아야");
            player_health--;
            isAttacked = true;
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        int countTime = 0;

        while (countTime <= 10)
        {
            if (countTime % 2 == 0)
            {
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 90);
            }
            else
            {
                transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            yield return new WaitForSecondsRealtime(0.2f);
            countTime++;
        }
        transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
        yield return null;
    }
}

