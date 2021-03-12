using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsHealth : MonoBehaviour
{
    public int maxHP = 20;
    public int curHP;
    public HealthBar healthBar;
    public GameObject lose;
    bool isdead = false;

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

    void Lose()
    {
        if (curHP <= 0)
        {
            if (isdead)
            {
                lose.SetActive(false);
                Time.timeScale = 1;
                isdead = false;
                Debug.Log("unpause");
            }
            else
            {
                lose.SetActive(true);
                Time.timeScale = 0;
                isdead = true;
                Debug.Log("unpause");
            }
        }
    }
}
