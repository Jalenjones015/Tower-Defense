using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayPlace : MonoBehaviour
{ 
    [SerializeField]
        private GameObject playersprefab;


    [SerializeField]
    private KeyCode PPlayer = KeyCode.Space;
    private GameObject CurrectPlacement;

    void Update()
    {
        Newplacement();

        if (CurrectPlacement != null)
        {
            moveObj();
            PlaceObj();
        }
    }

    private void PlaceObj()
    {
        if (Input.GetMouseButtonDown(1))
        {
            CurrectPlacement = null;
        }
    }

    private void moveObj()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;
        if (Physics.Raycast(ray, out hitinfo))
        {
            CurrectPlacement.transform.position = hitinfo.point;
            CurrectPlacement.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hitinfo.normal);
        }
    }

    private void Newplacement()
    {
        if (Input.GetKeyDown(PPlayer))
        {
            if (CurrectPlacement == null)
            {
                CurrectPlacement = Instantiate(playersprefab);
            }
            else
            {
                Destroy(CurrectPlacement);
            }
        }
}
}
