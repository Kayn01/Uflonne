using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalInventoryItem : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem UfloneAmount;
    [SerializeField] private InventoryItem thisItem;

    

    void Awake()
    {
        if(thisItem.destroyed == true)
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !other.isTrigger )
        {
            AddItemToInventory();
            thisItem.destroyed = true;
            Destroy(this.gameObject);
        }
        //this.SetActive(false);
        }
    

    void AddItemToInventory()
    {
        if (playerInventory && thisItem)
        {
            if (playerInventory.myInventory.Contains(UfloneAmount))
            {
                UfloneAmount.numberHeld += 1;
            }
            else
            {
                playerInventory.myInventory.Add(UfloneAmount);
                UfloneAmount.numberHeld += 1;
            }
        }
    }
}
