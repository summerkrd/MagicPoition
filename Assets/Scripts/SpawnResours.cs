using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnResours : MonoBehaviour
{
    [SerializeField] private GameObject[] _resours;
    public InventorySlot Slot;



    public void SpawnRes(int _randomRes)
    {
        if (Slot.transform.childCount == 0)
        {
            _randomRes = Random.Range(0, _resours.Length);
            Vector3 resPosition = Slot.transform.position;
            GameObject resultPotion = Instantiate(_resours[_randomRes], resPosition, Quaternion.identity);
            resultPotion.transform.SetParent(Slot.transform);
        }
    }
}
