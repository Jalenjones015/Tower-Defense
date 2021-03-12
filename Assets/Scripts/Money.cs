using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    Store st;
    public int add;

    private void Start()
    {
        st = GameObject.FindWithTag("Bullet").GetComponent<Store>();
    }

    private void OnTriggerEnter(Collider obj)
        {
            if(obj.gameObject.tag == "Mud")
            {
                st.money += add;
            }
        }
}
