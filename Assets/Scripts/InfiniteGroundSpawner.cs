using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteGroundSpawner : MonoBehaviour
{
    public GameObject[] groundPrefabs;
    public Transform player;
    public float spawnDistance = 10f;
    public int initialGroundCount = 5;

    private List<GameObject> activeGrounds = new List<GameObject>();
    private float zSpawn = 0f;
    private float groundlength;

    private void Start()
    {
        groundlength = groundPrefabs[0].transform.localScale.z;

        for (int i = 0; i < initialGroundCount; i++)
        {
            if (i==0)
            {
                SpawnGround(0);
            }
            else
            {
                SpawnGround(Random.Range(0, groundPrefabs.Length));
            }
        }
    }

    private void Update()
    {
        if (player.position.z - spawnDistance > zSpawn - (initialGroundCount * groundlength))
        {
            SpawnGround(Random.Range(0, groundPrefabs.Length));
            RemoveOldGround();
        }
    }

    void SpawnGround(int groundIndex)
    {
        GameObject go = Instantiate(groundPrefabs[groundIndex], transform);
        go.transform.position = new Vector3(0, 0, zSpawn);
        zSpawn += groundlength;
        activeGrounds.Add(go);
    }

    void RemoveOldGround()
    {
        Destroy(activeGrounds[0]);
        activeGrounds.RemoveAt(0);
    }
}
