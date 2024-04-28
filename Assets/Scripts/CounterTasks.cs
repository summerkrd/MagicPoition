using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterTasks : MonoBehaviour
{
    [SerializeField] private TMP_Text _ollTasks;
    public static int _currentTask;

    void Update()
    {
        _ollTasks.text = _currentTask.ToString() + "/11";
    }
}
