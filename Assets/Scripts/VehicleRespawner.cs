using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleRespawner : MonoBehaviour
{
    public Transform[] Checkpoints; // Array of transforms of all checkpoints
    public float CollisionCount = -1f; // Collision count

    private Rigidbody VehicleRigidbody; // Vehicle rigid body component
    private Transform closestCheckpoint; // Transform of closest checkpoint
    private bool CollisionFlag = false; // Collision flag

    void OnCollisionEnter(Collision collision)
    {
        CollisionFlag = true; // Collision detected
    }

    Transform GetClosestCheckpoint(Transform[] checkpoints)
    {
        Transform ClosestCheckpoint = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialCheckpoint in checkpoints)
        {
            Vector3 distanceToCheckpoint = potentialCheckpoint.position - currentPosition;
            float distanceToCheckpointSqr = distanceToCheckpoint.sqrMagnitude;
            if (distanceToCheckpointSqr < closestDistanceSqr)
            {
                closestDistanceSqr = distanceToCheckpointSqr;
                ClosestCheckpoint = potentialCheckpoint;
            }
        }
        return ClosestCheckpoint;
    }

    void Respawn()
    {
        // Reset momentum
        VehicleRigidbody.velocity = Vector3.zero;
        VehicleRigidbody.angularVelocity = Vector3.zero;

        // Get closest checkpoint
        closestCheckpoint = GetClosestCheckpoint(Checkpoints);

        // Reset pose
        gameObject.transform.position = closestCheckpoint.position;
        gameObject.transform.rotation = closestCheckpoint.rotation;

        // Update clooision flag and count
        CollisionFlag = false; // Reset collision flag
        CollisionCount = CollisionCount + 0.5f; // Update clooision count
    }

    void Start()
    {
        VehicleRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (CollisionFlag) Respawn();
    }

}
