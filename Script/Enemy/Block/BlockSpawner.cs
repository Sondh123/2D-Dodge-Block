using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab;
    public GameObject superBlockPrefab;

    public float TimeSpawnBetweenWave = 2f; // đỗ trễ giữa những lần sinh block

    private float timeToSpawn = 2f; // thời gian cần để block tiếp tục sinh ra

 

    
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            spawnBlock();
            timeToSpawn = Time.time + TimeSpawnBetweenWave;
        }

    }

    void spawnBlock()
    {
        float timeNow = Time.timeSinceLevelLoad;
        int randomIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
                if (timeNow > 15 )
                {
                    int RandomBlock1 = Random.Range(0, spawnPoints.Length);
                    Instantiate(blockPrefab, spawnPoints[RandomBlock1].position, Quaternion.identity);
                }
                if (timeNow > 30)
                {
                    int RandomBlock11 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock111 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock1110 = Random.Range(0, spawnPoints.Length);
                    Instantiate(blockPrefab, spawnPoints[RandomBlock11].position, Quaternion.identity);
                    Instantiate(blockPrefab, spawnPoints[RandomBlock111].position, Quaternion.identity);
                    Instantiate(blockPrefab, spawnPoints[RandomBlock1110].position, Quaternion.identity);
                }
                if (timeNow > 60)
                {
                    int RandomBlock2 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock21 = Random.Range(0, spawnPoints.Length);
                    Instantiate(blockPrefab, spawnPoints[RandomBlock2].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock21].position, Quaternion.identity);
                }
                if (timeNow > 90)
                {
                    int RandomBlock22 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock221 = Random.Range(0, spawnPoints.Length);
                    Instantiate(blockPrefab, spawnPoints[RandomBlock22].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock221].position, Quaternion.identity);
                    
                }
                if (timeNow > 120)
                {
                    int RandomBlock222 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock2222 = Random.Range(0, spawnPoints.Length);
                    Instantiate(blockPrefab, spawnPoints[RandomBlock222].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock2222].position, Quaternion.identity);
                }
                if (timeNow > 150)
                {
                     int RandomBlock3 = Random.Range(0, spawnPoints.Length);
                     int RandomBlock33 = Random.Range(0, spawnPoints.Length);
                     int RandomBlock333 = Random.Range(0, spawnPoints.Length);
                     Instantiate(blockPrefab, spawnPoints[RandomBlock3].position, Quaternion.identity);
                     Instantiate(superBlockPrefab, spawnPoints[RandomBlock33].position, Quaternion.identity);
                     Instantiate(superBlockPrefab, spawnPoints[RandomBlock333].position, Quaternion.identity);
                }
                if (timeNow > 180)
                {
                    int RandomBlock22 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock223 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock224 = Random.Range(0, spawnPoints.Length);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock22].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock223].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock224].position, Quaternion.identity);

                }
                if (timeNow > 240)
                {
                    int RandomBlock22 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock223 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock224 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock225 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock226 = Random.Range(0, spawnPoints.Length);
                    int RandomBlock227 = Random.Range(0, spawnPoints.Length);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock22].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock223].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock224].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock225].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock226].position, Quaternion.identity);
                    Instantiate(superBlockPrefab, spawnPoints[RandomBlock227].position, Quaternion.identity);
                    

                }

            }
        }
    }
    
}