using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _hook;

    private float _timer;

    private void Start()
    {
        SpawnHook();
    }

    private void Update()
    {
        if(_timer > _maxTime)
        {
            SpawnHook();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnHook()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject hook = Instantiate(_hook, spawnPos, Quaternion.identity);

        Destroy(hook, 10f);
    }
}
