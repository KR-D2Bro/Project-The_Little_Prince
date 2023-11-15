using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
    public void Interact(RaycastHit hitInfo)
    {
        // Object 레이어에 대한 처리 코드
        Debug.Log("Interacting with Object: " + hitInfo.transform.name);
    }
}
