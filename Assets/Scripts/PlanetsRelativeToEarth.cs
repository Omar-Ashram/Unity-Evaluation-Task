using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsRelativeToEarth : MonoBehaviour
{

    [SerializeField] Earth earth;

   
    [SerializeField]float DistanceFromSunRatio;
    [SerializeField]float MassRatio;
    [SerializeField]float DiameterRatio;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position =  earth.getEarthDistanceFromSun * DistanceFromSunRatio;
        transform.localScale = earth.getEarthDiameter * DiameterRatio;
        rb.mass = earth.getEarthMass * MassRatio;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
