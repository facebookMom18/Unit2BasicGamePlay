using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GamesMAnager : MonoBehaviour
{
    private int score = 0; 
    private int lives = 3;
    private int value;

    public void AddLives(int value)
    {
        lives += value; 
        
        if (lives <= 0) 
        { 
            Debug.Log("Game Over"); 
            lives = 0; 
        }
        Debug.Log("Lives = " + lives);
    }
    public void AddScore(int value)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        score += value; 
        Debug.Log("Score = " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
