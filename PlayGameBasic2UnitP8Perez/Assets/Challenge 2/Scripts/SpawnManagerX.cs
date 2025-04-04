using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //initialize the time that must pass before the spawn
    private float delayBeforeSpawn = 3f;

    //We will use Update because it is more suitable for solving than InvokeRepeating. Don't worry, the result will be the same.

    private void Update()
    {
        //checking if our time to spawn ball is passed
        if (delayBeforeSpawn <= 0)
        {
            //If true spawn a ball and generate a random time
            SpawnRandomBall();
            delayBeforeSpawn = Random.Range(3, 5);
        }
        else
        {
            //If false reducing the time before spawn. Using Time.deltaTime because it can simulate a real countdown.
            delayBeforeSpawn -= Time.deltaTime;
        }
    }
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);
    }

}