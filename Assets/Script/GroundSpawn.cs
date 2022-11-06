
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{

    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void spawnTile()
    {
        //How to spawn object in Unity
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

    }
    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i < 50; i++)
        {
            spawnTile();
        }


    }


}
