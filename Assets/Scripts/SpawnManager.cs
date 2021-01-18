using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject spherePrefab;
    private float rangeX = 5;
    private float rangeZ = 5;
    private float y = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnSphere();
        
    }
    
    void SpawnSphere()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float x = Random.Range(-rangeX, rangeX);
            float z = Random.Range(-rangeZ, rangeZ);
            Vector3 newPosition = new Vector3(x, y, z);
            Instantiate(spherePrefab, newPosition, spherePrefab.transform.rotation);
        }

    }
}
