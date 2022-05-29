using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{

    public SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainC")
        {
            Debug.Log("Hit the MC");
            Debug.Log("Destroying: "+ other);
            Destroy(other.gameObject);
        }
        else
        {
            spawnManager.SpawnTriggerEntered();
        }
    }
}
