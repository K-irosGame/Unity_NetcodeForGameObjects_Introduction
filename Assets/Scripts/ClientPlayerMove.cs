using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Netcode;
public class ClientPlayerMove : NetworkBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private ThirdPersonController _thirdPersonController;
    [SerializeField] private StarterAssetsInputs _starterAssetsInputs;

    private void Awake()
    {
        _playerInput.enabled = false;
        _thirdPersonController.enabled = false;
        _starterAssetsInputs.enabled = false;
    }

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        enabled = IsClient;
        
        if (IsOwner)
        {
            _playerInput.enabled = true;
            _starterAssetsInputs.enabled = true;
            _thirdPersonController.enabled = true;
        }

       
    }

}
