using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class NowDate : MonoBehaviour
{
    DateTime Today;
    public TextMeshProUGUI A;
    // Start is called before the first frame update
    void Start()
    {
        Today = DateTime.Now;
        A.text = Today.Year.ToString() + "”N" + Today.Month.ToString() + "ŒŽ" + Today.Day.ToString() + "“ú";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
