using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootingMeteor : MonoBehaviour
{

    public float maxSize;
    public float minSize;
    float SpawnSize;

    [Space]
    public float maxPosX;
    public float minPosX;
    float SpawnPosX;
    [Space]
    public float maxPosY;
    public float minPosY;
    float SpawnPosY;
    [Space]
    public float maxPosZ;
    public float minPosZ;
    float SpawnPosZ;
    Vector3 SpawnPos;
    [Space]
    public float maxSpeed;
    public float minSpeed;
    float MeteorSpeed;
    Vector3 force;
    [Space]

    public GameObject MeteorPrefb;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPosX = Random.Range(maxPosX, minPosX);
            SpawnPosY = Random.Range(maxPosY, minPosY);
            SpawnPosZ = Random.Range(maxPosZ, minPosZ);

            SpawnPos = new Vector3(SpawnPosX, SpawnPosY, SpawnPosZ);

            MeteorSpeed = Random.Range(maxSpeed, minSpeed);

            SpawnSize = Random.Range(minSize, maxSize);
            force = SpawnPos.normalized;

           GameObject m = Instantiate(MeteorPrefb, SpawnPos, Quaternion.identity);
            
            m.transform.localScale = Vector3.one * SpawnSize;

            Rigidbody MeteorRb = m.GetComponent<Rigidbody>();
            MeteorRb.mass = (SpawnSize / 8);
            MeteorRb.AddForce(force * MeteorSpeed, ForceMode.Impulse);

            Destroy(m.gameObject, 10f);
        }
        
    }
    private void FixedUpdate()
    {

       
    }

        
}


