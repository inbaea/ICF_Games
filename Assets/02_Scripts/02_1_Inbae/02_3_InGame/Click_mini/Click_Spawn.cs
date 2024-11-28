using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Spawn : MonoBehaviour
{
    public GameObject[] prefabs;
    public int count = 200;

    private List<GameObject> gameObject_ = new List<GameObject>();

    public void Start()
    {
        for (int i = 0; i < count; ++i)
        {
            Spawn();
        }

    }

    private Vector2 GetRandomPosition()
    {
        Vector2 basePosition = transform.position;

        float posX = basePosition.x + Random.Range(-1800 / 2f, 1800 / 2f);
        float posY = basePosition.y + Random.Range(-980 / 2f, 980 / 2f);

        Vector2 spawnPos = new Vector2(posX, posY);

        return spawnPos;
    }

    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);

        GameObject selectedPrefab = prefabs[selection];

        Vector2 spawnPos = GetRandomPosition();//랜덤위치함수

        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        instance.transform.SetParent(transform);
        instance.name = selectedPrefab.name;
        gameObject_.Add(instance);
    }
}
