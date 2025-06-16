using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Inventory : MonoBehaviour
{
    public Item item1;
    public Item item2;
    public Item item3;

    private int _itemCount;

    private void Start()
    {
        print("Item 1: " + item1.itemName);
        print("Item 2: " + item2.itemName);
        if (item3 != null)
        {
            print("Item 3: " + item3.itemName);
        }
        
        item1.Use();
        item2.Use();
        item3.Use();
    }

}
