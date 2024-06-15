using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
     Vector3 SpawnPoint = new Vector3(21.12f, 7.09f, 6.84f);
     [SerializeField] GameObject player;
     [SerializeField] Vector3 SpawnerPosition;
     [SerializeField] GameObject Bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SpawnerPosition =  player.transform.position + SpawnPoint;
    }
    IEnumerator SpawnBirds()
    {
         SpawnerPosition.z = Random.Range(-5, 5);
         
         Instantiate(Bird,  SpawnerPosition, Quaternion.Euler(0, 90, 0));

          yield return new WaitForSeconds(Random.Range(3,6));
    }
}
