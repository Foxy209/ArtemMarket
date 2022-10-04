using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_2T_6 : MonoBehaviour
{
    public GameObject task;
    public GameObject tr2;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "box")
        {
            task.active = true;
            Destroy(tr2);
        }

    }
}
