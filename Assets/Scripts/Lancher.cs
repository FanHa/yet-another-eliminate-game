using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancher : MonoBehaviour
{
    public GameObject capsulePrefab; // Capsule预制体
    private float spawnInterval = 1f; // 生成间隔
    private float mapWidth = 10f; // 地图宽度
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCapsules());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnCapsules()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            float spawnPosX = 0f;
            Vector3 spawnPos = new Vector3(spawnPosX, transform.position.y, 0);

            Instantiate(capsulePrefab, spawnPos, Quaternion.identity);
        }
    }
}
