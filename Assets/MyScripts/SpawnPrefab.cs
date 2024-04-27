using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{

    public GameObject myPrefab;
    public GameObject myParent;
    public Vector3 myPosition;
    GameObject currentWalls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        currentWalls = GameObject.Find("DoorHolder");
        if (currentWalls = null)
        {
            currentWalls = GameObject.Find("DoorHolder(Clone)");
        }
        
        if (currentWalls != null)
        {
        Destroy(currentWalls);
        Instantiate(myPrefab, myParent.transform);
        }
    }
}
