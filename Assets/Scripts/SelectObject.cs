using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [SerializeField] private GameObject _interface;
    //[SerializeField] private GameObject _object;
    private bool _selected;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OpenInterface();
        }
    }

    public void OnMouseOver()
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        _selected = true;
        //_object.SetActive(true);
    }

    public void OnMouseExit()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
        _selected = false;
        //_object.SetActive(false);
    }

    public void OpenInterface()
    {
        if (_selected == true)
        {
            _interface.SetActive(true);

        }
    }
}
