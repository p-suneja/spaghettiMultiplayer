using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

[RequireComponent(typeof(NetworkTransform))]
public class NetworkSpaceship : NetworkBehaviour
{

    [SyncVar]
    public int score;

    void Start()
    {

    }


    [ClientCallback]
    void Update()
    {
    }
}
