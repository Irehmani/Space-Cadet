
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundTile : MonoBehaviour
{

    GroundSpawn groundSpawner;

    // Start is called before the first frame update
    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawn>();
        spawnObstacle();
    }


    //Need to see if it exits
    private void OnTriggerExit(Collider other)
    {
        groundSpawner.spawnTile();
        //destry game object 2 seconds after player done
        Destroy(gameObject, 2);
    }


    // Update is called once per frame
    private void Update()
    {
        
    }

    //Variable type of game object 
    public GameObject obstaclePrefab;


    void spawnObstacle()
    {
        //Choose random point for obstacle spawn and spawn obstacle


        int obstacleSpawnIndex = Random.Range(2, 5);
        //Return transform component of obstacles
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;


        //Spawn the obstacle at the position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);



    }



}
