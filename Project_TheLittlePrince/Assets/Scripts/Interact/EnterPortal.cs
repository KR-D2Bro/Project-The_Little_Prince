using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPortal : MonoBehaviour
{
    public void Interact(RaycastHit hitInfo)
    {
        // Portal 레이어에 대한 처리 코드
        Debug.Log("Entering Portal: " + hitInfo.transform.name);
    }
}
