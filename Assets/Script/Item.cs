using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Item : MonoBehaviour
{
    public string itemName;
    public int price;

    private int _count;

    public void Use()
    {

        print("You used " + itemName);
    
    }

}
