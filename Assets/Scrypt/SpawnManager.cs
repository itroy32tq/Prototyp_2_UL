using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _animalPrefabs;
    private int _animalIndex;
    [SerializeField, Range(0, 30f)] private float _spawnRangeX = 20f;
    [SerializeField, Range(0, 30f)] private float _spawnRangeZ = 20f;
    [SerializeField] private float _startDelay = 2f;
    [SerializeField] private float _spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval);
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S)) SpawnRandomAnimal();
       
    }

    private void SpawnRandomAnimal()
    {
        Vector3 pos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnRangeZ);

        _animalIndex = Random.Range(0, _animalPrefabs.Length);

        Quaternion rot = _animalPrefabs[_animalIndex].transform.rotation;

        Instantiate(_animalPrefabs[_animalIndex], pos, rot);
    }
}

