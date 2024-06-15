using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
     Vector3 SpawnPoint = new Vector3(0, 3, 31.46f);
     [SerializeField] GameObject player;
     [SerializeField] Vector3 SpawnerPosition;
     [SerializeField] GameObject Bird;
     [SerializeField] bool GameisActive = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBirds());
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SpawnerPosition =  player.transform.position + SpawnPoint;
        transform.position = SpawnerPosition;
    }
    IEnumerator SpawnBirds()
    {
        while(GameisActive)
        {
            SpawnerPosition.x = Random.Range(-2, 2);
         
            Instantiate(Bird,  SpawnerPosition, Quaternion.Euler(0, 180, 0));

            yield return new WaitForSeconds(Random.Range(3,6));
        }
         
    }
}
