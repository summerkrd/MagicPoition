using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{

    //private GameObject childObject;
    //private GridLayoutGroup gridLayoutGroup;

    /*void Start()
    {
        if (transform.childCount > 0)
        {
            childObject = transform.GetChild(0).gameObject;
            gridLayoutGroup = GetComponentInParent<GridLayoutGroup>();
        }
    }

    void Update()
    {
        if (childObject != null && gridLayoutGroup != null)
        {
            if (childObject.CompareTag("CyanPotion2"))
            {
                gridLayoutGroup.cellSize = new Vector2(100, 150);
            }
            else
            {
                gridLayoutGroup.cellSize = new Vector2(180, 180);
            }
        }
    }*/

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
        }

    }

}
