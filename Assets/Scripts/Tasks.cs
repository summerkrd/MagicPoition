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
    [SerializeField] private int _maxTasks = 12;
    private int _index = 0;
    
    public void SubmitTask()
    {
        RefreshTask(0, "CyanPotion2");
        RefreshTask(1, "PinkPotion1");
        RefreshTask(2, "OrangePotion2");
        RefreshTask(3, "RedPotion2");
        RefreshTask(4, "PinkPotion2");
        RefreshTask(5, "OrangePotion1");
        RefreshTask(6, "BluePotion1");
        RefreshTask(7, "RedPotion1");
        RefreshTask(8, "PurplePotion2");
        RefreshTask(9, "PurplePotion1");
        RefreshTask(10, "GreenPotion2");
        RefreshTask(11, "ExtraPotion");
    }

    public void RefreshTask(int TaskIndex, string PotionTag)
    {
        
        if (Slot.transform.childCount > 0)
        {
            if (GameTask[TaskIndex].gameObject.activeSelf && Slot.transform.GetChild(0).tag == PotionTag && CounterTasks._currentTask != _maxTasks)
            {
                
                GameObject Potion = Slot.transform.GetChild(0).gameObject;
                Debug.Log("�� ����� �������");
                Destroy(Potion);
                Audio[1].Play();

                GameTask[_index].SetActive(false);
                _index++;
                GameTask[_index].SetActive(true);

                CounterTasks._currentTask++;
                
            }
            //else Audio[0].Play();
        }
        else Audio[0].Play();
    }

}
