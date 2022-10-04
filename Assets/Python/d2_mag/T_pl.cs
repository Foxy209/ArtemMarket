using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class T_pl : MonoBehaviour
{
    [SerializeField] private int task = 1;
    [SerializeField] private Text txt;
    [SerializeField] private Text txxt;
    [SerializeField] private Text txxxt;
    public GameObject light;
    public GameObject ts;
    public GameObject task3tr;
    public GameObject tt4;
    public GameObject ef;
    public GameObject t4;
    public GameObject t5;
    public GameObject spot;

    private void Update()
    {
        if (task == 1)
        {
            txt.text = "Turn on";
            txxt.text = "the light";
        }

        if (light.active == true)
        {
            task = 2;
            Destroy(spot);
        }

        if (task == 2)
        {
            txt.text = "Remove";
            txxt.text = "delay";
        }
        if (ts.active == true)
        {
            task = 3;
        }

        if (task == 3)
        {
            txt.text = "Go to";
            txxt.text = "entrance";
        }

        if (tt4.active == true)
        {
            task = 4;
        }

        if (task == 4)
        {
            txt.text = "wash";
            txxt.text = "the floors";
            t4.active = true;
        }

        if (task3tr.active == true)
        {
            task = 5;
        }
        
        
        if (task == 5)
        {
            txt.text = "Sell";
            txxt.text = "product";
            txxxt.text = "to customers";
        }
        
        
        if (ef.active == true)
        {
            txt.text = "Turn off";
            txxt.text = "light";
            txxxt.text = "and go home";
            t5.active = true;
        }
    }
}
