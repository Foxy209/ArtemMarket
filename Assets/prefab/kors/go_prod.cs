using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_prod : MonoBehaviour
{
   private void Start()
   {
      left = GameObject.Find("contr").transform;
   }

   public Transform left;
   public int ede;
   public GameObject t3;
   
   private void Update()
   {
      if (Input.GetKey(KeyCode.F))
      {
         transform.position = Vector3.Lerp(transform.position, left.position, Time.deltaTime * 1);
      }

      if (ede == 10)
      {
         t3.active = false;
      }
   }
   private void OnTriggerEnter(Collider other)
   {
      Destroy(gameObject);
      ede++;
   }
   
}
