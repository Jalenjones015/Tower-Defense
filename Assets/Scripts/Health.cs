using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image Healthbar;
    HandsHealth Hands;
    public Slider slider;
    //public int curhp;
    //public float maxhp;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if (slider.value<= slider.minValue)
        {
            Healthbar.enabled = false;
            
        }
        if (slider.value > slider.minValue && !Healthbar.enabled)
        {
            Healthbar.enabled = true;
        }

    }
}
