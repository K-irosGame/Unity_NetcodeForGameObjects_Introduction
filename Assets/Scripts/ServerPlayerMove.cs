using UnityEngine;
using Unity.Netcode;

[DefaultExecutionOrder(0)]
public class ServerPlayerMove : NetworkBehaviour
{
    public override void OnNetworkSpawn()
    {
        if (!IsServer)
        {
            enabled = false; 
            return;
        }
        ApplySpawnPoint();

        base.OnNetworkSpawn();
    }

    private void ApplySpawnPoint()
    {
        Transform spawnPoint = ServerSpawnPoints.Instance.ConsumeNextSpawnPoint();
        Vector3 spawnPointPosition = spawnPoint.position;

        transform.position = spawnPointPosition;

    }
}
