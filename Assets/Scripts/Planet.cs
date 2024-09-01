using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
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

    private void Update()
    {
        transform.Rotate(transform.up, 10 * Time.deltaTime);
    }
}
