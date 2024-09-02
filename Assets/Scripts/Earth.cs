using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    [SerializeField] GameObject sun;

    Rigidbody Earthbody;
    // Start is called before the first frame update
    void OnEnable()
    {
        Earthbody = GetComponent<Rigidbody>();   
    }

    public Vector3 getEarthDistanceFromSun
    {
        get
        {
          
            return transform.position; 
        }

    }

    public float getEarthMass
    {
        get
        {
            return Earthbody.GetComponent<Rigidbody>().mass;
        }
    }

    public Vector3 getEarthDiameter
    {
        get
        {
            return transform.localScale;
        }
    }

}
