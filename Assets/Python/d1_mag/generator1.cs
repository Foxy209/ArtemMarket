using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class generator1 : MonoBehaviour
{
    public List<GameObject> fruits;

    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject fruit = Instantiate(fruits[Random.Range(0, fruits.Count)], transform.position, Random.rotationUniform);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.3f));
            fruit.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
