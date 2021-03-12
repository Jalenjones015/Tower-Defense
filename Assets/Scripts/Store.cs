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
        money = 50;
        Money1 = GameObject.Find("Money Text").GetComponent<Text>();
    }

    void Update()
    {
        Money1.text = "" + money.ToString();
    }

    public int Money()
    {
        return money;
    }

    public void add (int _money)
    {
        money += _money;
        Money1.text = money.ToString();
    }

    public void used (int usedmoney)
    {
        if (money - usedmoney < 0)
        {
            Debug.Log("not enough");
        }
        else
        {
            money -= usedmoney;
            Money1.text = money.ToString();
        }
    }
}
