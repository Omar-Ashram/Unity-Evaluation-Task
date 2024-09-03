using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlanetToList : MonoBehaviour
{
    private void OnEnable()
    {
        if (celestials.celestialsList == null)
        {
            celestials.celestialsList = new List<GameObject>();
        }
        celestials.AddToList(this.gameObject);

    }

    private void OnDisable()
    {
        celestials.RemoveFromList(this.gameObject);
    }
}
