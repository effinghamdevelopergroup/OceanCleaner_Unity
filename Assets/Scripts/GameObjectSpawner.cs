using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
    public int NumberOfGameObjectsToSpawn = 15;
    public int MaximumDistance = 15;
    public int MinimumDistance = 1;
    public List<GameObject> ListOfObjectsToSpawn;
    public float TargetTime = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TargetTime -= Time.deltaTime;

        if (TargetTime <= 0.0f)
        {
            if (this.transform.childCount < NumberOfGameObjectsToSpawn)
            {
                //Spawn Game Object From List
                int NumberOfGameObjectsToSpawn = ListOfObjectsToSpawn.Count;
                int GameObjectListElementId = UnityEngine.Random.Range(0, NumberOfGameObjectsToSpawn);
                GameObject toSpawnGameObject = ListOfObjectsToSpawn[GameObjectListElementId];
                toSpawnGameObject.transform.position = new Vector3(
                    this.transform.position.x + UnityEngine.Random.Range(MinimumDistance, MaximumDistance),
                    this.transform.position.y,
                    this.transform.position.z + UnityEngine.Random.Range(MinimumDistance, MaximumDistance));
                Instantiate(toSpawnGameObject, this.transform);
            }
            TargetTime = 60.0f;
        }
    }
}
