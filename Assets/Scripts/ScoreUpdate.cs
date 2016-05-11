using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour 
{
	public Image life1;
	public Image life2;
	public Image life3;
	public Text uiScoreText;
	public Text uiHighScoreText;
	public Text uiBonusScoreText;

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
	

	void Update () 
	{
	
	}
}