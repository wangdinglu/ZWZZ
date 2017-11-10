using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	
	public static Manager instance;

	public GameObject PlayerPrefab;

	List <Player> players = new List<Player>();
	public int currentPlayerIndex=0;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () 
	{
		generatePlayers();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//players [currentPlayerIndex].TurnUpdate ();
	}

	public void nextTurn()
	{
		if (currentPlayerIndex + 1 < players.Count) {
			currentPlayerIndex++;
		} else {
			currentPlayerIndex = 0;
		}
	}

	void generatePlayers()
	{
		Player player;
		player = ((GameObject)Instantiate (PlayerPrefab, new Vector3 (0, 0, 0), Quaternion.Euler(new Vector3()))).GetComponent<Player>();
		players.Add (player);
		player = ((GameObject)Instantiate (PlayerPrefab, new Vector3 (0, 0, 0), Quaternion.Euler(new Vector3()))).GetComponent<Player>();
		players.Add (player);
		player = ((GameObject)Instantiate (PlayerPrefab, new Vector3 (0, 0, 0), Quaternion.Euler(new Vector3()))).GetComponent<Player>();
		players.Add (player);
		player = ((GameObject)Instantiate (PlayerPrefab, new Vector3 (0, 0, 0), Quaternion.Euler(new Vector3()))).GetComponent<Player>();
		players.Add (player);
	}

}
