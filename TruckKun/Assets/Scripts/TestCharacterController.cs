using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour
{

    [SerializeField] public float movementSpeed = 1f;
    public float speedMultiplier = 1f; 

    void Update()
    {
        speedMultiplier += .0003f; // Gets faster over time
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2 * speedMultiplier;
        float vMovement = speedMultiplier * movementSpeed; // disable to Only let them move back and forth. move the map
        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escaping button pressed, exiting game.");
            Application.Quit();
        }
    }

    public void StopTheTruck()
    {
        Debug.Log("Stopping the Truck.");
        movementSpeed = 0;
    }
}
