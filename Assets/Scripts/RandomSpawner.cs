using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] GameObject [] prefabToSpawn;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")] [SerializeField] float maxYDistance = 0.5f;

    void Start() {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine() {
        while (true) {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            int r = Random.Range(0, 4);
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y + Random.Range(-maxYDistance, +maxYDistance),
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn[r].gameObject, positionOfSpawnedObject, Quaternion.identity);
        }
    }
}
