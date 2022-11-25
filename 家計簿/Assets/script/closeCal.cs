using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class closeCal : MonoBehaviour
{

    public GameObject[] ui;
    public GameObject[] OpUI;
    public GameObject[] CB;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    { 

    for(int a=0;a<3; a++){
            ui[a].SetActive(false);
           
        }
        for (int b =0; b < 5; b++)
        {
           
            OpUI[b].SetActive(true);
        }
        this.gameObject.SetActive(false);
        for (int b = 0; b < 42; b++)
        {

           CB[b].SetActive(true);
        }

    }
}
