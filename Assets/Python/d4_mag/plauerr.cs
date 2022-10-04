using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plauerr : MonoBehaviour
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
        public GameObject t2;
        public GameObject spot;
        public GameObject box;
    
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
                txt.text = "Lay out";
                txxt.text = "the products";
            }
            if (ts.active == true)
            {
                task = 3;
                Destroy(t2);
            }
    
            if (task == 3)
            {
                txt.text = "wash";
                txxt.text = "the floors";
                task3tr.active = true;
                Destroy(box);
            }
    
            if (tt4.active == true)
            {
                task = 4;
            }
    
            if (task == 4)
            {
                txt.text = "Wipe";
                txxt.text = "windows";
                t4.active = true;
            }
            if (ef.active == true)
            {
                task = 5;
            }
    
            if (task == 5)
            {
                txt.text = "Turn off";
                txxt.text = "light";
                txxxt.text = "and go home";
                t5.active = true;
            }
        }
}
