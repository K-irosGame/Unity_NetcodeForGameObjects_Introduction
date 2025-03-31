using System.Collections.Generic;
using UnityEngine;
using DesignPatterns.Singleton;
public class ServerSpawnPoints : Singleton<ServerSpawnPoints>
{
    [SerializeField] private List<Transform> _spawnPoints;

    public Transform ConsumeNextSpawnPoint()
    {
        if (_spawnPoints.Count == 0)
            return null;
        else
        {
            Transform spawnPoint = _spawnPoints[_spawnPoints.Count - 1];
            _spawnPoints.RemoveAt(_spawnPoints.Count - 1);

            return spawnPoint;
        }
    }
}
