using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpawnElfe : MonoBehaviour
{

    public GameObject elfePrefab;
    public GameObject elfenSpawnGo;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;

    void Start()
    {
        ElfenSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            ElfenSpawner();
        }
    }

    private void ElfenSpawner()
    {
        var clones = Instantiate(elfePrefab);
        clones.GetComponent<Transform>().SetParent(elfenSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-100, 100), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }
}