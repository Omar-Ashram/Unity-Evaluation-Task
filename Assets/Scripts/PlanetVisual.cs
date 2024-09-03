using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlanetVisual : MonoBehaviour
{
    [SerializeField] GameObject PlanetTopVisual;



    public int PlanetTopVisualSize;

    private void Start()
    {
        PlanetTopVisual.transform.localScale = Vector3.one * PlanetTopVisualSize;
    }

    private void Update()
    {
        PlanetTopVisual.transform.position = transform.position;  
    }
}
