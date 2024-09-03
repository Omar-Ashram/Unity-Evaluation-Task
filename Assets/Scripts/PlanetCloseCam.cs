using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetCloseCam : MonoBehaviour
{
    public Vector3 FollowOffset;

    public float RotateSpeed;

    private void Update()
    {
        

        transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);
    }

}
