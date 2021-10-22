using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab = null;
    [Range(1, 200)]
    [SerializeField] private int cubeSpawnAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            this.SpawnXCubes(this.cubeSpawnAmount);
        }
    }

    private void SpawnXCubes(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            // Verteilung streuen
            GameObject.Instantiate(this.cubePrefab);
        }
    }
}
