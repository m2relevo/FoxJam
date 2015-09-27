using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour 
{
	private Transform cTrans;
	private GameObject[] deathArr;
	private Death death;

	void Start()
	{
		cTrans = this.transform;
		deathArr = GameObject.FindGameObjectsWithTag("Death");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		for (int i =0; i < deathArr.Length; i++) 
		{
			deathArr[i].GetComponent<Death>().Setcheckpoint(cTrans);
		}   
	}
}
