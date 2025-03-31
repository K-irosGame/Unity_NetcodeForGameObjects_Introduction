using UnityEngine;
using Unity.Netcode;

public class ColorTrigger : NetworkBehaviour
{
    private NetworkVariable<Color> _networkColor  = new NetworkVariable<Color>(Color.gray);

    private Material _instanceMaterial;

    public override void OnNetworkSpawn()
    {
        _networkColor.OnValueChanged += OnChangeColor;

        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        if (meshRenderer != null)
        {
            _instanceMaterial = new Material(meshRenderer.material);

            meshRenderer.material = _instanceMaterial;
            UpdateMaterialColor(_networkColor.Value);
        }
    }

    public override void OnNetworkDespawn()
    {
       _networkColor.OnValueChanged -= OnChangeColor;
    }

    private void OnChangeColor(Color previousColor, Color newColor)
    {
        UpdateMaterialColor(newColor);
    }

    private void UpdateMaterialColor(Color targetColor)
    {
        if (_instanceMaterial != null)
            _instanceMaterial.color = targetColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        NetworkObject networkObject = other.GetComponent<NetworkObject>();

        if (IsClient && networkObject != null && networkObject.IsOwner)
            ChangeColorServerRpc(networkObject.OwnerClientId);
    }


    [Rpc(SendTo.Server)]
    private void ChangeColorServerRpc(ulong clientId)
    {
        _networkColor.Value = clientId % 2 == 0 ? new Color(255, 0, 0, 0.5f) : new Color(0, 0, 255, 0.5f) ;
    }
}
