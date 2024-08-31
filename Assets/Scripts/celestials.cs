using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class celestials
{
    
    public static List<GameObject> celestialsList = new List<GameObject>();

    public static void AddToList(GameObject celestial) 
    {
        celestialsList.Add(celestial);
    }


    public static void RemoveFromList(GameObject celestial)
    {
        celestialsList.Remove(celestial);
    }
}
