using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CalClick : MonoBehaviour
{ 
    public int day;
    int AN=3;
    Calendar Cal;
//  public GameObject[] DB;
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
        Debug.Log("Click");
         AN=Array.IndexOf(Cal.Day,9);
       

    }
}
