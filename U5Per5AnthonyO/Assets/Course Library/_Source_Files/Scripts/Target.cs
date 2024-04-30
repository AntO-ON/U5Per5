using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float yRange = -6;
    private Rigidbody targetrb;
    // Start is called before the first frame update
    void Start()
    {
        targetrb = GetComponent<Rigidbody>();
        targetrb.AddForce(Vector3.up * Random.RandomRange(12, 16), ForceMode.Impulse);
        targetrb.AddTorque(RandomTorque(),RandomTorque(),ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
