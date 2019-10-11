using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int PinCount;
	public Text text;

	void Start ()
	{
		PinCount = 0;
	}

	void Update ()
	{
        Debug.Log(" Rounds: " + keepData.RoundsPlayed.ToString());
        keepData.PlayerScore = PinCount; // cannot use PanelScore because text not declared at top 
		text.text = PinCount.ToString();
	}

}
