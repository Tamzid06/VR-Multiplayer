using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Network_Manager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        ConnectToServer();
    }
	
	void ConnectToServer()
	{
		PhotonNetwork.ConnectUsingSettings();
		Debug.Log("try connecting to the server...");
	}
	
	public override void OnConnectedToMaster()
	{
        Debug.Log("Connected To Server.");
		base.OnConnectedToMaster();
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.MaxPlayers = 10;
		roomOptions.IsVisible = true;
		roomOptions.IsOpen = true;

		PhotonNetwork.JoinOrCreateRoom("Room 1", roomOptions, TypedLobby.Default);
	}

	public override void OnJoinedRoom()
    {
		Debug.Log("Joined a Room");
		base.OnJoinedRoom();
    }

	public override void OnPlayerEnteredRoom(Player newPlayer)
    {
		Debug.Log("A new player joined the room");
		base.OnPlayerEnteredRoom(newPlayer);
    }
	
    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
