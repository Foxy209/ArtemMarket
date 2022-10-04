using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class T2_2 : MonoBehaviour
{
    public GameObject task;
    public GameObject B;
    public GameObject DOOR;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "box")
        {
            task.active = true;
            B.active = true;
            DOOR.active = true;
        }

    }
}