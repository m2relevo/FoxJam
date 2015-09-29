﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectManager : MonoBehaviour
{
	public static int collect;        // The player's score.
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		collect = 0;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Collectibles: " + collect;
	}
}