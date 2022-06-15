using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maker_control : MonoBehaviour
{
    [SerializeField]
    GameObject maker;

    [SerializeField]
    GameObject control;

    [SerializeField]
    GameObject back;

    [SerializeField]
    GameObject gamebutton;

    [SerializeField]
    GameObject makerbutton;

    [SerializeField]
    GameObject backbutton;

    [SerializeField]
    GameObject controlbutton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Maker()
    {
        gamebutton.SetActive(false);
        makerbutton.SetActive(false);
        controlbutton.SetActive(false);
        backbutton.SetActive(true);

        back.SetActive(false);
        maker.SetActive(true);
        control.SetActive(false);
        
    }
    public void Control()
    {
        gamebutton.SetActive(false);
        makerbutton.SetActive(false);
        controlbutton.SetActive(false);
        backbutton.SetActive(true);

        back.SetActive(false);
        maker.SetActive(false);
        control.SetActive(true);
    }
    public void Back()
    {
        gamebutton.SetActive(true);
        makerbutton.SetActive(true);
        controlbutton.SetActive(true);
        backbutton.SetActive(false);

        back.SetActive(true);
        maker.SetActive(false);
        control.SetActive(false);
    }
}
