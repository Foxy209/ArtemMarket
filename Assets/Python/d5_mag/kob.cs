using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kob : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                Application.LoadLevel("end");
            }
        }
}
