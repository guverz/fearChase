using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemCounter : MonoBehaviour
{
    //public GameObject[] items;
    //public Inventory inventory;
    //public GameObject fuse;


    //void Update()
    //{
    //    int count = 0;
    //    foreach (GameObject item in items)
    //    {
    //        if (!item.activeSelf)
    //        {
    //            count++;
    //        }
    //    }

    //    inventory.ChessPieces = count;

    //    if (!fuse.activeSelf)
    //    {
    //        inventory.HaveFuse = true;
    //    }
    //}
    public Inventory inventory;
    public void CollectItem()
    {
        inventory.ChessPieces++;
    }
    public void CollectFuse()
    {
        inventory.HaveFuse = true;
    }
}

