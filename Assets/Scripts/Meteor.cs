using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
