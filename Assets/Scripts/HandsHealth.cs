using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsHealth : MonoBehaviour
{
    public int maxHP = 20;
    public int curHP;
    public HealthBar healthBar;

    private void Start()
    {
        curHP = maxHP;
        healthBar.SetHP(maxHP);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mud"))
        {
            TakeHP(2);
        }

        else if(other.gameObject.CompareTag("Dirt Hand"))
        {
            TakeHP(1);
        }
    }

    void TakeHP(int damage)
    {
        curHP -= damage;
        healthBar.SetHP(curHP);
    }
}
