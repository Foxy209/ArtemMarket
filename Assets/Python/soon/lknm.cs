using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lknm : MonoBehaviour
{
    //public GameObject checkpount;
    [SerializeField] private Text task;

    private void Update()
    {
        task.text = "GO";
    }

}
