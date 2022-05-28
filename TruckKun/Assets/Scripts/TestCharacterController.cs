using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour
{

    [SerializeField] public float movementSpeed = 1f;
    public float speedMultiplier = 1f; // Potentially have this go up over time to make the game harder.
    public SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = speedMultiplier * movementSpeed; // disable to Only let them move back and forth. move the map
        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
