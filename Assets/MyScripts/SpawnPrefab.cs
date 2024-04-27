using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{

    public GameObject myPrefab;
    public GameObject myParent;
    public string myPrefabName;
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
        currentWalls = GameObject.Find(myPrefabName);
        if (currentWalls == null)
        {
            currentWalls = GameObject.Find(myPrefabName + "(Clone)");
        }
        
        if (currentWalls != null)
        {
        Destroy(currentWalls);
        Instantiate(myPrefab, myParent.transform);
        }
    }
}
