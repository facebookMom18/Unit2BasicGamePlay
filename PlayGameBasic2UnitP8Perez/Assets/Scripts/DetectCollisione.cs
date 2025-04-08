using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisione : MonoBehaviour
{
    private GamesMAnager gameManager;

    public GamesMAnager GamesMAnager { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            gameManager.AddLives(-1); Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GamesMAnager = GameObject.Find("GameManager").GetComponent<GamesMAnager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
