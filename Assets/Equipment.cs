using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public int[] items;
    Library lib;
    MouseItem MouseItem;
    Inventary inv;
    Upgrader upgrade;
    void Start()
    {
        lib = GetComponent<Library>();
        inv = GetComponent<Inventary>();
        upgrade = GetComponent<Upgrader>();
        MouseItem = GetComponent<MouseItem>();
    }
    void OnGUI()
    {                
        if (GUI.Button(new Rect(700, 180, 70, 70), lib.Images[items[0]]))
        {
            int ForBase;
            ForBase = MouseItem.MouseItems;
            MouseItem.MouseItems = items[0];
            items[0] = ForBase;
            ForBase = 0;
            
        }
        if (GUI.Button(new Rect(900, 180, 70, 70), lib.Images[items[1]]) && MouseItem.MouseItems == 1)
        {
            int ForBase;
            ForBase = MouseItem.MouseItems;
            MouseItem.MouseItems = items[1];
            items[1] = ForBase;
            ForBase = 0;
            
        }
        if (GUI.Button(new Rect(800, 230, 70, 70), lib.Images[items[2]]) && MouseItem.MouseItems == 2)
        {
            int ForBase;
            ForBase = MouseItem.MouseItems;
            MouseItem.MouseItems = items[2];
            items[2] = ForBase;
            ForBase = 0;
            
        }
        if (GUI.Button(new Rect(800, 350, 70, 70), lib.Images[items[3]]) && MouseItem.MouseItems == 3)
        {
            int ForBase;
            ForBase = MouseItem.MouseItems;
            MouseItem.MouseItems = items[3];
            items[3] = ForBase;
            ForBase = 0;
           
        }
    }
}