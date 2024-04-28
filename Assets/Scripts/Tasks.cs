using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    public GameObject[] GameTask;
    public InventorySlot Slot;
    public AudioSource[] Audio;

    
    public void SubmitTask()
    {
        RefreshTask(0, "CyanPotion2");
        RefreshTask(1, "PinkPotion1");
        RefreshTask(2, "OrangePotion2");
        RefreshTask(3, "RedPotion2");
        RefreshTask(4, "PinkPotion2");
        RefreshTask(5, "OrangePotion1");
        RefreshTask(6, "BluePotion");
        RefreshTask(7, "RedPotion1");
        RefreshTask(8, "PurplePotion2");
        RefreshTask(9, "PurplePotion1");
        RefreshTask(10, "GreenPotion2");
        RefreshTask(11, "ExtraPotion");
    }

    public void RefreshTask(int TaskIndex, string PotionTag)
    {
        int index = 0;
        if (Slot.transform.childCount > 0)
        {
            if (GameTask[TaskIndex].gameObject.activeSelf && Slot.transform.GetChild(0).tag == PotionTag)
            {

                GameObject Potion = Slot.transform.GetChild(0).gameObject;
                Debug.Log("Вы сдали задание");
                Destroy(Potion);
                Audio[1].Play();

                GameTask[index].SetActive(false);
                index++;
                GameTask[index].SetActive(true);

            }
        }
            
        else Audio[0].Play();
        
    }

    
}
