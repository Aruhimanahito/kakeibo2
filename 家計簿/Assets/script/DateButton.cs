using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
public class DateButton : MonoBehaviour
{
    public TextMeshProUGUI Button;
    public GameObject Fl;
   public GameObject[] Cal;
    public GameObject[] ui;
    private int D=0;
    public GameObject date;
    public GameObject closeBtn;

    DateTime Today;
    // Start is called before the first frame update
    void Start()
    {
        date.SetActive(false);

        Fl.SetActive(false);
        closeBtn.SetActive(false);
        for (int b = 0; b < 42; b++)
        {

           Cal[b].SetActive(false);
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        Today = DateTime.Now;
        Button.text = Today.Year.ToString() + "”N" + Today.Month.ToString() + "ŒŽ" + Today.Day.ToString() + "“ú";
    }
    public void OnClick() { 
     D=0;
    for (int del = 0; del < 5;del++) { ui[D].SetActive(false);
            D = D + 1;
        }
        date.SetActive(true);
        Fl.SetActive(true);
       
        Debug.Log(DateTime.Now.DayOfWeek);
        closeBtn.SetActive(true);
        for (int b = 0; b < 42; b++)
        {

            Cal[b].SetActive(true);
        }
    }
    
   
}
