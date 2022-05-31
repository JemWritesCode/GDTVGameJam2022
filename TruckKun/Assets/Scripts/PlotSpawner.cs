using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 5;
    private float plotSize = 40f;
    private float xPosLeft = -26.1f;
    private float xPosRight = 25.72f;
    private float lastZPos = 15f;

    public List<GameObject> plots;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnPlot();
        }
    }

    public void SpawnPlot()
    {
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        Instantiate(plotLeft, new Vector3(xPosLeft, 0, zPos), plotLeft.transform.rotation);
        Instantiate(plotLeft, new Vector3(xPosRight, 0, zPos), new Quaternion(0, 180, 0, 0));

        lastZPos += plotSize;

    }
}
