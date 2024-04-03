using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour
{
    [SerializeField] GameObject[] items;
    int i;

    void Start()
    {
        i = 2;
        ChangeItem(-1);
    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0.1)
        {
            ChangeItem(1);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < -0.1)
        {
            ChangeItem(-1);
        }
    }

    private void ChangeItem(int v)
    {
        items[i].SetActive(false);

        i += v;

        if (i > items.Length - 1)
        {
            i = 0;
        }

        if (i < 0)
        {
            i = items.Length - 1;
        }

        items[i].SetActive(true);
    }
}
