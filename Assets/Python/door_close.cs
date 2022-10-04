using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_close : MonoBehaviour
{
    public GameObject doorclose;
    public GameObject dooropen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorclose.active = true;
            dooropen.active = false;
        }
    }
}
