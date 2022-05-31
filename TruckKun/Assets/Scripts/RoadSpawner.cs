using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoadSpawner : MonoBehaviour
{
    public List<GameObject> roads;
    private float offset = 37f;
    private float lastZPos = 158f;

    public void SpawnRoad()
    {
        GameObject theRoad = roads[Random.Range(0, roads.Count)];

        float zPos = lastZPos + offset;

        GameObject newRoad = Instantiate(theRoad, new Vector3(0, -3.29f, zPos), theRoad.transform.rotation);

        lastZPos += offset;
    }


    // The old version that moves the roads and deletes it behind you. But it doesn't give variance it just moves the same road forward over and over

    //public List<GameObject> roads;
    //private float offset = 37f;

    //// Start is called before the first frame update
    //void Start()
    //{

    //    if (roads != null && roads.Count > 0)
    //    {
    //        roads = roads.OrderBy(r => r.transform.position.z).ToList();
    //    }
    //}
    //public void SpawnRoad()
    //{
    //    GameObject movedRoad = roads[0];
    //    roads.Remove(movedRoad);
    //    float newZ = roads[roads.Count - 1].transform.position.z + offset;
    //    movedRoad.transform.localPosition = new Vector3(0, 0, newZ);
    //    roads.Add(movedRoad);
    //}

}