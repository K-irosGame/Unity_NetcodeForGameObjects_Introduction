using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class HostJoinUI : MonoBehaviour
{
    [SerializeField] private Button _startHost;
    [SerializeField] private Button _startClient;
    [SerializeField] private Button _startServer;


    private void Awake()
    {
        _startHost.onClick.AddListener(() => 
        {
            NetworkManager.Singleton.StartHost();
            ToggleOff();
        });

        _startClient.onClick.AddListener(() => 
        {
            NetworkManager.Singleton.StartClient();
            ToggleOff();
        });

        _startServer.onClick.AddListener(() => 
        {
            NetworkManager.Singleton.StartServer();
            ToggleOff();
        });

    }

    private void ToggleOff() => gameObject.SetActive(false);
}
