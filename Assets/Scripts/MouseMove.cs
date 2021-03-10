using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public GameObject BuyMenu;
    public KeyCode Open = KeyCode.Space;
    RaycastHit hit;
    
    public void Start()
    {
        movemouse();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50000f))
        {
            transform.position = hit.point;
            Debug.Log("Moving");
        }
    }

    public void movemouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50000f))
        {
            transform.position = hit.point;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(Open))
        {
            BuyMenu.SetActive(true);
        }

        if (Input.GetKeyUp(Open))
        {
            BuyMenu.SetActive(false);
        }
    }
}
