using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepSunAtOrigin : MonoBehaviour
{
    private void Awake()
    {
        if(transform.position != Vector3.zero)
               transform.position = Vector3.zero;
    }
}
