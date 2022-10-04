using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wdwdw : MonoBehaviour
{
    //public GameObject checkpount;
    [SerializeField] private Text task;
    public GameObject one;
    public GameObject dwd;
    public GameObject ddw;
    void aaa()
    {
        one.active = false;
    }
    private void Update()
    {
        Invoke(nameof(aaa), 6);
        task.text = "Wash up";
        if (dwd.active == true)
        {
            fd();
        }
    }

    void fd()
    {
        ddw.active = true;
        task.text = "Go to work";
    }
}
