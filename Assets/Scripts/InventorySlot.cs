using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{

    private GameObject _childObject;
    private string _childObjectTag;
    private GridLayoutGroup gridLayoutGroup;

    void Start()
    {



    }

    void Update()
    {

        StartCoroutine(SlotScale());
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
        }

    }

    private IEnumerator SlotScale()
    {
        if (transform.childCount > 0)
        {
            _childObjectTag = transform.GetChild(0).tag;
            _childObject = transform.GetChild(0).gameObject;
            gridLayoutGroup = GetComponent<GridLayoutGroup>();
        }

        if (_childObject != null && gridLayoutGroup != null)
        {
            if (_childObjectTag == "CyanPotion2"||
                _childObjectTag == "BluePotion1"||
                _childObjectTag == "ExtraPotion"||
                _childObjectTag == "GreenPotion2"||
                _childObjectTag == "OrangePotion1"||
                _childObjectTag == "OrangePotion2"||
                _childObjectTag == "PinkPotion1"||
                _childObjectTag == "PinkPotion2"||
                _childObjectTag == "PurplePotion1"||
                _childObjectTag == "PurplePotion2"||
                _childObjectTag == "RedPotion1"||
                _childObjectTag == "RedPotion2")
            {
                gridLayoutGroup.cellSize = new Vector2(50, 100);
            }
            else
            {
                gridLayoutGroup.cellSize = new Vector2(180, 180);
            }
            //Debug.Log("Изменение размера");
        }
        yield return null;

    }

}
