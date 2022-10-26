using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private GridManager gridManager;
    public GameObject kotak;

    private void Start()
    {
        gridManager = new GridManager(4, 2, 10f);
    }

    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }

    public static Vector3 GetMouseWorldPositionWithZ()
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
    }

    public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera)
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);
    }

    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }

    public static Vector3 GetDirToMouse(Vector3 fromPosition)
    {
        Vector3 mouseWorldPosition = GetMouseWorldPosition();
        return (mouseWorldPosition - fromPosition).normalized;
    }

    private void Update()
    {
        
        if(gridManager.GetValue(GetMouseWorldPosition()) == 1)
        {
            kotak.SetActive(true);
        }
        else
        {
            kotak.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && gridManager.GetValue(GetMouseWorldPosition()) == 1)
        {
            gridManager.SetValue(GetMouseWorldPosition(), 3);
        }
        else if (Input.GetMouseButtonDown(0) && gridManager.GetValue(GetMouseWorldPosition()) == 0)
        {
            gridManager.SetValue(GetMouseWorldPosition(), 76);
        }
        
    }
}
