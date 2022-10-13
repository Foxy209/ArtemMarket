using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bug : MonoBehaviour
{
    [SerializeField] private GameObject ffe;

    private void Update()
    {
        Destroy(ffe);
    }
}
