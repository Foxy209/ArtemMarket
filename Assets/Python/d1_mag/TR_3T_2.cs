using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TR_3T_2 : MonoBehaviour
{

    public Transform arte;
    public List<GameObject> fruits;
    public GameObject fefe;
    
    void Update()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject fruit = Instantiate(fruits[Random.Range(0, fruits.Count)], arte.position, Random.rotationUniform);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            fefe.active = true;
        }
    }
}
