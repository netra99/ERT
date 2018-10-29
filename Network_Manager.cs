using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Network_Manager : MonoBehaviour
{

    public GameObject player;
    public GameObject RightController;
    public GameObject LeftController;

    // Use this for initialization
    public virtual void Start()
    {
        Debug.Log("Network manager reached");
        PhotonNetwork.ConnectUsingSettings("1.0");
    }

    public virtual void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster() was called by PUN. Now this client is connected and can join a room");
        PhotonNetwork.JoinRandomRoom();
    }

    public virtual void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList().");
        PhotonNetwork.JoinRandomRoom();
    }

    //joining room 
    public virtual void OnPhotonRandomJoinFailed()
    {
        Debug.Log("OnPhotonRandomJoinFailed() was called by PUN. No random room available, se we create one. ");
        PhotonNetwork.CreateRoom(null, new RoomOptions() { MaxPlayers = 4 }, null);
    }

    //for context
    public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        Debug.LogError("Cause: " + cause);
    }

    public void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom(). Now this client is in a room. From here on, the game will be running.");
        Debug.Log(player.name);
        PhotonNetwork.Instantiate(player.name, Vive_Manager.Instance.head.transform.position, Vive_Manager.Instance.head.transform.rotation, 0);
        PhotonNetwork.Instantiate(RightController.name, Vive_Manager.Instance.rightHand.transform.position, Vive_Manager.Instance.rightHand.transform.rotation, 0);
        PhotonNetwork.Instantiate(LeftController.name, Vive_Manager.Instance.leftHand.transform.position, Vive_Manager.Instance.leftHand.transform.rotation, 0);


    }

}
