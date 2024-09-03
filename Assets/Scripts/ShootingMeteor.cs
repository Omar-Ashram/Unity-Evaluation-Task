using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootingMeteor : MonoBehaviour
{

    public float maxSpawnSize;
    public float minSpawnSize;
    float SpawnSize;
    [Space]

    public float maxSpawnPosX;
    public float minSpawnPosX;
    float SpawnPosX;
    [Space]

    public float maxSpawnPosY;
    public float minSpawnPosY;
    float SpawnPosY;
    [Space]

    public float maxSpawnPosZ;
    public float minSpawnPosZ;
    float SpawnPosZ;
    Vector3 SpawnPos;
    [Space]

    public float maxMass;
    public float minMass;
    float MeteorMass;
    [Space]

    float maxDir = 1f;
    float minDir = -1f;
    Vector3 MeteorforceDir;
    [Space]
    public float MeteorLifeTime = 10;
    public GameObject MeteorPrefb;

    [Space]
    float speed;
    public float multiplyer = 100;



    public void ShootMeteor()
    {
        SpawnPosX = Random.Range(maxSpawnPosX, minSpawnPosX);
        SpawnPosY = Random.Range(maxSpawnPosY, minSpawnPosY);
        SpawnPosZ = Random.Range(maxSpawnPosZ, minSpawnPosZ);

        SpawnPos = new Vector3(SpawnPosX, SpawnPosY, SpawnPosZ);

        GameObject m = Instantiate(MeteorPrefb, SpawnPos, Quaternion.identity);

        Rigidbody meteorRb = m.GetComponent<Rigidbody>();
        
        MeteorMass = Random.Range(minMass,maxMass);
        meteorRb.mass = MeteorMass;
        speed = MeteorMass * multiplyer;
        MeteorforceDir = new Vector3(Random.Range(minDir,maxDir),
                                     Random.Range(minDir,maxDir),
                                     Random.Range(minDir,maxDir));
        meteorRb.AddForce(MeteorforceDir * speed, ForceMode.Impulse);

        SpawnSize = Random.Range(minSpawnSize, maxSpawnSize);
        m.transform.localScale = Vector3.one * SpawnSize;

        Destroy(m.gameObject, MeteorLifeTime);
    }


}


