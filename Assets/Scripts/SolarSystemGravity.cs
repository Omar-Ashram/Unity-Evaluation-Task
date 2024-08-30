using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class SolarSystemGravity : MonoBehaviour
{
    GameObject[] celestials;
    const float g = 6.6743f;


   // public static List<GameObject> celestials;


    // Start is called before the first frame update
    void Start()
    {
        celestials = GameObject.FindGameObjectsWithTag("celestial");
        instialVelocity();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Gravity();
    }

    void Gravity()
    {
        foreach (GameObject a in celestials)
        {
            foreach (GameObject b in celestials)
            {
                if (!a.Equals(b))
                {

                    float m1 = a.GetComponent<Rigidbody>().mass;
                    float m2 = b.GetComponent<Rigidbody>().mass;

                    Vector3 dir = (b.transform.position - a.transform.position);
                    float dist = dir.magnitude;

                    float gforce =( g * (m1 * m2) / (dist*dist));
                    Vector3 force = dir.normalized * gforce;

                  a.GetComponent<Rigidbody>().AddForce(force);

                }

            }

        }

    }

    void instialVelocity()
    {
        foreach (GameObject a in celestials)
        {
            foreach (GameObject b in celestials)
            {
                if (!a.Equals(b))
                {
                    float m2 = b.GetComponent<Rigidbody>().mass;

                    float dist = Vector3.Distance(a.transform.position, b.transform.position);
                    a.transform.LookAt(b.transform.position);

                    float instantVelocity = Mathf.Sqrt((g * m2) / dist);
                    a.GetComponent<Rigidbody>().velocity += a.transform.right * instantVelocity;
                }
            }
        }


    }
}
