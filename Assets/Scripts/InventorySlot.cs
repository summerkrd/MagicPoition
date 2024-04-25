using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    //public Image Image;
    //public Color SelectedColor, NotSelectedColor;

   /* private void Awake()
    {
        Deselect();
    }
    public void Select()
    {
        Image.color = SelectedColor;
    }
    public void Deselect()
    {
        Image.color = NotSelectedColor;
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
