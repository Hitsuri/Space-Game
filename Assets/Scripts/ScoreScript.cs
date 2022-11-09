using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
	//score
    public static int score;
	//score display
    public TextMeshProUGUI scoreText;
	//win screen
    public GameObject youWin;
    
    
	// Start is called before the first frame update
	//resets score to 0
    void Start()
    {
        score = 0;
    }

	//updates the score display and displays win screen if score reaches a treshold
    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();

        if (score == 26)
        {
            youWin.SetActive(true);
            Time.timeScale = 0.1f;
        }
    }
}
