using UnityEngine;
using System.Collections;

public class GameRuler : MonoBehaviour {

	enum GameStatus {
		InGame = 0,
		Goal,
		GameOver,
	};
	GameStatus mStatus = GameStatus.InGame;

	// Use this for initialization
	void Start () {
		mStatus = GameStatus.InGame;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool isGoal() {
		return mStatus == GameStatus.Goal;
	}

	public bool isGameOver() {
		return mStatus == GameStatus.GameOver;
	}

	public bool isInGame() {
		return mStatus == GameStatus.InGame;
	}
		
	public void setGoal() {
		mStatus = GameStatus.Goal;
	}

	public void setGameOver() {
		mStatus = GameStatus.GameOver;
	}

	public void setInGame() {
		mStatus = GameStatus.InGame;
	}
}
