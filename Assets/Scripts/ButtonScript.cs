using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    
	//restarts the game
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
