using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlace : MonoBehaviour
{

    public GameObject Players1;

    public void Spawn()
    {
        Instantiate(Players1);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<MouseMove>().movemouse();
        }

    }

    private Vector3 mOffset;
    private float mZCoord;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = new Vector3(GetMouseAsWorldPoint().x + mOffset.x, transform.position.y, GetMouseAsWorldPoint().z + mOffset.z);
    }
}
