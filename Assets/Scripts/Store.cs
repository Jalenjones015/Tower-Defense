using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public int money;
    public Text Money1;
    Store St;

    void Start()
    {
        Money1 = GameObject.Find("Money Text").GetComponent<Text>();
    }

    void Update()
    {
        Money1.text = "5" + money.ToString();
    }

    public int Money()
    {
        return money;
    }

    public void mod(int _money)
    {
        money += _money;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mud"))
        {
            St.mod(5);
            Debug.Log("Money");
        }

    }
}
