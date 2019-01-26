using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventary : MonoBehaviour
{
    public int[] items;
    Library lib;
    Equipment Equip;
    MouseItem MouseItem;
    void Start()
    {
        lib = GetComponent<Library>();
        Equip = GetComponent<Equipment>();
        
        MouseItem = GetComponent<MouseItem>();
    }
    void OnGUI()
    {      
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                if (GUI.Button(new Rect(x * 70, y * 70, 70, 70), lib.Images[items[y * 5 + x]]))
                {                 
                        int ForBase;
                        ForBase = MouseItem.MouseItems;
                         MouseItem.MouseItems = items[y * 5 + x];
                        items[y*5 +x] = ForBase;
                        ForBase = 0;
                        
                }
            }
        }
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 70, 50), lib.Images[MouseItem.MouseItems]);
    }
}