using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    Store St;

    public void Start()
    {
        St = GetComponent<Store>();
    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Mud"))
    //    {
    //        St.mod(5);
    //        Debug.Log("Money");
    //    }
  
    //}

}
