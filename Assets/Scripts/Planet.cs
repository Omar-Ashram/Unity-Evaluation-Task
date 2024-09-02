using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PlanetNameUI;
    public Vector3 FollowOffset;

    [Range(0,200)]
    public int textOffsetX = 0;


    [Range(0, 200)]
    public int textOffsetZ = 0;

    public float rotateSpeed; 


    private void OnEnable()
    {
        if (celestials.celestialsList == null)
        {
            celestials.celestialsList = new List<GameObject>();
        }
        celestials.AddToList(this.gameObject);
        PlanetNameUI.text = name;
    }

   

    private void OnDisable()
    {
        celestials.RemoveFromList(this.gameObject);
    }

    private void Update()
    {
        transform.Rotate(transform.up, rotateSpeed * Time.deltaTime);
        PlanetNameUI.transform.position = transform.position + new Vector3(textOffsetX, 0, textOffsetZ);
    }
}
