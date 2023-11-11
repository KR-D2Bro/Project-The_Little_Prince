using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    public float interactionDistance = 2.0f;
    [SerializeField] private LayerMask layerMask;
 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TryInteract();
        }
    }

    void TryInteract()
    {
      RaycastHit hitInfo;
      Vector3 rayStart = this.transform.position - new Vector3(0f, 1f, 0f);

      // 시각적으로 레이를 표시 (레이가 충돌하지 않을 때 red)
      //Debug.DrawRay(rayStart, transform.forward * interactionDistance, Color.red, 2.0f);

      if(Physics.Raycast(rayStart, this.transform.forward, out hitInfo, interactionDistance, layerMask))
      {
        int hitLayer = hitInfo.transform.gameObject.layer;
        string layerName = LayerMask.LayerToName(hitLayer);

        // 시각적으로 레이를 표시 (레이가 충돌할 때 green)
        //Debug.DrawRay(rayStart, transform.forward * interactionDistance, Color.green, 2.0f);

        switch (layerName)
        {
            case "Object":
                InteractWithObject(hitInfo);
                break;
            case "NPC":
                InteractWithNPC(hitInfo);
                break;
            case "Portal":
                EnterPortal(hitInfo);
                break;
            default:
                Debug.Log("Unhandled layer: " + layerName);
                break;
        }
      }

    }

    void InteractWithObject(RaycastHit hitInfo)
    {
        // Object 레이어에 대한 처리 코드
        Debug.Log("Interacting with Object: " + hitInfo.transform.name);
    }

    void InteractWithNPC(RaycastHit hitInfo)
    {
        // NPC 레이어에 대한 처리 코드
        Debug.Log("Interacting with NPC: " + hitInfo.transform.name);
    }

    void EnterPortal(RaycastHit hitInfo)
    {
        // Portal 레이어에 대한 처리 코드
        Debug.Log("Entering Portal: " + hitInfo.transform.name);
    }
}