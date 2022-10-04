using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tt5 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("dom4");
        }
    }
}
