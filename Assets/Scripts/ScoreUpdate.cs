using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour 
{
	public Image uilife1;
	public Image uilife2;
	public Image uilife3;
	public Text uiScore;
	public Text uiHighScore;
	public Text uiBonusScore;

	private int score;
	private bool haslife1;
	private bool haslife2;
	private bool haslife3;



	void Awake () 
	{
		score = 0;

		haslife1 = true;
		haslife2 = true;
		haslife3 = true;	
	}
	

	void UpdateUIScore () 
	{
		uiScore.text = score.ToString ();
	}

	private void UpdateLife()
	{
		uilife1.enabled = haslife1;
		uilife2.enabled = haslife2;
		uilife3.enabled = haslife3;
	}

	/*private void UpdateHighScore()
	{
	}*/

	/*private void UpdateBonusScore()
	{
	}*/
}