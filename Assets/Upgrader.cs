using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrader : MonoBehaviour
{
    public int[] items;
    Library lib;
    
    Inventary inv;
    Equipment Equip;
    MouseItem MouseItem;
    void Start()
    {
        lib = GetComponent<Library>();
        inv = GetComponent<Inventary>();
        Equip = GetComponent<Equipment>();
        MouseItem = GetComponent<MouseItem>();

    }
     void Update()
    {
        if(items[0] == items[1] && items[2]== items[1])
        {
            items[1] = 0;
            items[2] = 0;
            items[0] = items[0] + 10;
        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(700, 30, 70, 70), lib.Images[items[0]]))
        {
            int ForBase;
            ForBase = MouseItem.MouseItems;
            MouseItem.MouseItems = items[0];
            items[0] = ForBase; 
            ForBase = 0;
            
        }
        if (GUI.Button(new Rect(770, 30, 70, 70), lib.Images[items[1]]))
        {
            int ForBase;
            ForBase = MouseItem.MouseItems;
            MouseItem.MouseItems = items[1];
            items[1] = ForBase;
            ForBase = 0;
            
        }
        if (GUI.Button(new Rect(840, 30, 70, 70), lib.Images[items[2]]))
        {
            int ForBase;
            ForBase = MouseItem.MouseItems;
            MouseItem.MouseItems = items[2];
            items[2] = ForBase;
            ForBase = 0;
           
        }
        
    }
}