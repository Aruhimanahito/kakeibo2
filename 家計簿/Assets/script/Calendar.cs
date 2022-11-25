using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Calendar : MonoBehaviour
{    public TextMeshProUGUI[] Day;
    private int year;
    private int month;
    private int i;
    private int days=1;
    private int Mday;//ç°åéÇÃì˙êî
    private int Fday;//ëOåé
    private int Ndays=1;
    DayOfWeek firstDate;
    // Start is called before the first frame update
    void Start()
    {
        year = DateTime.Now.Year;
        month = DateTime.Now.Month;
        DateTime firstDay = new DateTime(year, month, 1);
        firstDate = firstDay.DayOfWeek;
         Mday = DateTime.DaysInMonth(year, month);
        if (Mday == 1)
        {
            Fday = DateTime.DaysInMonth(year - 1, month);
            
        }
        else
        {
            Fday = DateTime.DaysInMonth(year, month - 1);
        }
        Debug.Log(Fday);
        switch (firstDate)
        {
            case DayOfWeek.Sunday:

                for (i = 0; i <= Mday-1; i++)
                {
                    Day[i].text = days.ToString();
                    days = days + 1;
                }
                Debug.Log("Sunday");
                    break;
            case DayOfWeek.Monday:
                for (i = 1; i<Mday; i++)
                {
                    Day[i].text = days.ToString();
                    days = days + 1;
                }
                Debug.Log("Monday");
                break;
            case DayOfWeek.Tuesday:
                
               
                for (i = 1; i >=0; i--)
                {
                    Debug.Log(i);
                    Day[i].text = Fday.ToString();
                    Fday = Fday - 1;
                }
                for (i = 2; i <= Mday+1; i++)
                {
                    Day[i].text= days.ToString();
                    days = days + 1;
                }
               for(i=Mday+2; i < 42;i++)
               {
                    Day[i].text = Ndays.ToString();
                    Ndays = Ndays + 1;

                }
                
                break;
            case DayOfWeek.Wednesday:
                for (i = 3; i <= Mday+2; i++)
                {
                    Day[i].text = days.ToString();
                    days = days + 1;
                }
                Debug.Log("Sunday");
                break;
            case DayOfWeek.Thursday:
                for (i = 4; i <= Mday+3; i++)
                {
                    Day[i].text = days.ToString();
                    days = days + 1;
                }
                Debug.Log("Monday");
                break;
            case DayOfWeek.Friday:
                
                for ( int i=5; i <= Mday+4; i++)
                {
                    Day[i].text = days.ToString();
                    days = days + 1;
                }
                for (int i = Mday+1; i <=42; i++)
                {
                    Day[i].text = days.ToString();
                    days = days + 1;
                }

                Debug.Log("Tuesday");
                break;
            case DayOfWeek.Saturday:
                for (i = 6; i <= Mday+5; i++)
                {
                    Day[i].text = days.ToString();
                    days = days + 1;
                }
                Debug.Log("Saturday");
                break;


        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
