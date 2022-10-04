using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1 : MonoBehaviour
{
    public GameObject eda;
    public GameObject tr;
    public GameObject box;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            eda.active = false;
            box.active = true;
            Destroy(tr);
        }
    }
}
