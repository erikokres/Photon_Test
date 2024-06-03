using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{

    public Text input_Create;
    public Text input_join;

    public void CreateRoom()
    {
        //PhotonNetwork.CreateRoom(input_Create.text, new RoomOptions() { MaxPlayers = 4, IsVisible = true, IsOpen = true }, TypedLobby.Default, null) ;
        PhotonNetwork.JoinOrCreateRoom(input_Create.text, new RoomOptions() { MaxPlayers = 4 }, TypedLobby.Default, null);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(input_join.text);
    }

    public void JoinRoomInList(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Gameplay");
    }
}
