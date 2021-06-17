using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour
{
    public GameObject item;
    public int Id;
    public string type;
    public string description;

    public bool empty;
    public Sprite icon;

    public Transform slotIconGameObject;

    private void Start()
    {
        slotIconGameObject = transform.GetChild(0);
    }

    public void updateSlot()
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
    }

    public void useItem()
    {
        item.GetComponent<Item>().itemUsage();
        
    }

    public void onPointerClick(PointerEventData pointerEventData)
    {
        useItem();
        Destroy(item);
    }
}
