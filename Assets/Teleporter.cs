using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportSource; // The object you want to teleport from
    public Transform teleportDestination; // The object you want to teleport to

    void Update()
    {
        // Check for input, such as a key press or button click
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Teleport the object from the source to the destination
            TeleportObject();
        }
    }

    void TeleportObject()
    {
        // Make sure both the source and destination are assigned
        if (teleportSource != null && teleportDestination != null)
        {
            // Calculate the teleportation offset
            Vector3 teleportOffset = teleportDestination.position - teleportSource.position;

            // Apply the offset to move the object to the destination
            transform.position += teleportOffset;
        }

    }

}
