using UnityEngine;
using System.Collections;

public class Scorer : MonoBehaviour {

	private int score = 0;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddScore() {
		score ++;
		Debug.Log("score " + score);
	}
}
