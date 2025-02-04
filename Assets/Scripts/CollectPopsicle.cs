using UnityEngine;
using System.Collections;


/// <summary>
/// Collects popsicle. And tell spawner to create bears
/// </summary>
public class CollectPopsicle : MonoBehaviour {
	
	public GameObject Spawner;	
	public GameRuler GameRuler;
	
	void DoCollect(Collider collider)
	{
		if(!enabled) return;
		
		if(collider.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			GameRuler.setGoal();
//			Spawner.GetComponent<Spawner>().BeginSpawning();
		}
	}
	
	void OnTriggerStay(Collider collider)
	{
		DoCollect (collider);
	}
	
	void OnTriggerEnter(Collider collider)
	{
		DoCollect (collider);
	}
}
