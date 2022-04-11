using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Network_Player_Spawner : MonoBehaviourPunCallbacks
{
    private GameObject spawnPlayerPrefab;

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        spawnPlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnPlayerPrefab);
    }

}
