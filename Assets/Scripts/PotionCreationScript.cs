using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCreationScript : MonoBehaviour
{
    //public GameObject[] Material;
    public GameObject[] Potion;
    public InventorySlot[] Slot;
    public AudioSource[] AudioSources;

    public void CreateObject()
    {
        if (Slot[0].transform.childCount > 0
         && Slot[1].transform.childCount > 0
         && Slot[2].transform.childCount > 0)
        {
            if (CompareForCraft("GreenWater", "Eye", "Feather"))
            {
                CraftPotionIndex(5);
                //DeleteMaterials();
            }
            else if (CompareForCraft("PinkPlazma", "Candles", "Gross"))
            {
                CraftPotionIndex(2);
                //DeleteMaterials();
            }
            else if (CompareForCraft("GreenWater", "Spider", "Skull"))
            {
                CraftPotionIndex(7);
                //DeleteMaterials();
            }
            else if (CompareForCraft("Gross", "FirePlazma", "EvilGross"))
            {
                CraftPotionIndex(10);
                //DeleteMaterials();
            }
            else if (CompareForCraft("Feather", "Bat", "Spider"))
            {
                CraftPotionIndex(8);
                //DeleteMaterials();
            }
            else if (CompareForCraft("Spider", "LeavePlazma", "Skull"))
            {
                CraftPotionIndex(1);
                //DeleteMaterials();
            }
            else if (CompareForCraft("HornSkull", "LeavePlazma", "Hand"))
            {
                CraftPotionIndex(0);
                //DeleteMaterials();
            }
            else if (CompareForCraft("Skull", "OldGross", "OldGross"))
            {
                CraftPotionIndex(4);
                //DeleteMaterials();
            }
            else if (CompareForCraft("Hand", "Lizard", "Horn"))
            {
                CraftPotionIndex(9);
                //DeleteMaterials();
            }
            else if (CompareForCraft("Lizard", "FirePlazma", "EvilGross"))
            {
                CraftPotionIndex(3);
                //DeleteMaterials();
            }
            else if (CompareForCraft("Lizard", "Spider", "Hand"))
            {
                CraftPotionIndex(6);
                //DeleteMaterials();
            }
            else if (CompareForCraft("FirePlazma", "LeavePlazma", "PinkPlazma"))
            {
                CraftPotionIndex(11);
                //DeleteMaterials();
            }
            else
            {
                AudioSources[0].Play();
                Debug.Log("ErrorSound");
            }
        }
        else AudioSources[0].Play();

    }

    public bool CompareForCraft(string materialTag1, string materialTag2, string materialTag3)
    {
        return Slot[0].transform.GetChild(0).tag == materialTag1
        && Slot[1].transform.GetChild(0).tag == materialTag2
        && Slot[2].transform.GetChild(0).tag == materialTag3;
    }
    public void CraftPotionIndex(int potionIndex)
    {
        Vector3 resultPosition = Slot[3].transform.position;
        if (Slot[3].transform.childCount == 0)
        {
            GameObject resultPotion = Instantiate(Potion[potionIndex], resultPosition, Quaternion.identity);
            resultPotion.transform.SetParent(Slot[3].transform);
            AudioSources[1].Play();
            DeleteMaterials();
        }
        else AudioSources[0].Play();
        
    }
    public void DeleteMaterials()
    {
        var material1 = Slot[0].transform.GetChild(0);
        var material2 = Slot[1].transform.GetChild(0);
        var material3 = Slot[2].transform.GetChild(0);

        Destroy(material1.gameObject);
        Destroy(material2.gameObject);
        Destroy(material3.gameObject);
    }

}

