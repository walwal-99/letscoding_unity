using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMop : MonoBehaviour
{
    [SerializeField] GameObject[] Mobs;

    bool start;
    public static int temp;

    // Start is called before the first frame update
    void Start()
    {
            StartCoroutine(GenerateMobs(Mobs));
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    IEnumerator GenerateMobs(GameObject[] gameObjects) {
        int lastnumber = 1001;
        while (true) {

            temp = Random.Range(0, gameObjects.Length);
            if (lastnumber == temp)
                continue;
            gameObjects[temp].SetActive(true);

            if(temp == 0)
            {
                yield return new WaitForSecondsRealtime(9);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            else if (temp == 1)
            {
                yield return new WaitForSecondsRealtime(7);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            else if (temp == 2)
            {
                yield return new WaitForSecondsRealtime(5);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            else if (temp == 3)
            {
                yield return new WaitForSecondsRealtime(6);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            //else if (temp == 4)
            //{
            //    yield return new WaitForSecondsRealtime(9);
            //    gameObjects[temp].SetActive(false);
            //    lastnumber = temp;
            //    yield return new WaitForSecondsRealtime(1);
            //}
            else if (temp == 4)
            {
                yield return new WaitForSecondsRealtime(5);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            else if (temp == 5)
            {
                yield return new WaitForSecondsRealtime(20);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            else if (temp == 6)
            {
                yield return new WaitForSecondsRealtime(16);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            else if (temp == 7)
            {
                yield return new WaitForSecondsRealtime(10);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            else if (temp == 8)
            {
                yield return new WaitForSecondsRealtime(5);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
            else if (temp == 9)
            {
                yield return new WaitForSecondsRealtime(10);
                gameObjects[temp].SetActive(false);
                lastnumber = temp;
                yield return new WaitForSecondsRealtime(1);
            }
        } 
    }
}
