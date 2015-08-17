using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	const string VERSION = "v0.0.1";
	public string roomName = "VVR";

	SpawnSpot[] spawnSpots;
	// private const string roomName = "RoomName";
	// private RoomInfo[] roomsList;
	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings(VERSION); //Matches with people with same game version

		spawnSpots = GameObject.FindObjectsOfType<SpawnSpot> ();
	}

 	void OnGUI()
	{

		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString ());
	}
	/*	if (PhotonNetwork.room == null)
		{
			// Create Room
			if (GUI.Button(new Rect(100, 100, 250, 100), "Start Server"))
				PhotonNetwork.CreateRoom(roomName + System.Guid.NewGuid().ToString("N"), true, true, 5);
			
			// Join Room
			if (roomsList != null)
			{
				for (int i = 0; i < roomsList.Length; i++)
				{
					if (GUI.Button(new Rect(100, 250 + (110 * i), 250, 100), "Join " + roomsList[i].name))
						PhotonNetwork.JoinRoom(roomsList[i].name);
				}
			}
		}
		*/
//	}
	

	void OnJoinedLobby(){
		Debug.Log (" Joined Lobby");
		RoomOptions roomOptions = new RoomOptions () {isVisible = false, maxPlayers = 4};
		PhotonNetwork.JoinOrCreateRoom (roomName, roomOptions, TypedLobby.Default);
	}

	/* void OnPhotonRandomJoinFailed(){
		//Debug.Log ("OnJoinedLobby");
		// PhotonNetwork.CreateRoom (null);
	}
	*/

	void OnJoinedRoom(){
		Debug.Log ("Joined Room");
		//Stuff only on your system, use regular instantiate, photonnetwork.instatiate for everyone
		SpawnMyPlayer ();

	}
	void SpawnMyPlayer(){
		if (spawnSpots == null) {
			Debug.Log ("There are no spawn spots");
			return;
		}
		SpawnSpot mySpawnSpot = spawnSpots [Random.Range (0, spawnSpots.Length)];

		GameObject myPlayerGO = (GameObject)PhotonNetwork.Instantiate ("Player", mySpawnSpot.transform.position, mySpawnSpot.transform.rotation, 0);  //end number sets it for groups (n/a in photon cloud)
		myPlayerGO.transform.Find ("FirstPersonController").gameObject.SetActive (true);
		myPlayerGO.transform.FindChild ("FirstPersonCharacter").gameObject.SetActive(true);
	}


}
