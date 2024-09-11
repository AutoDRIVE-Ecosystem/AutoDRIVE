using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimer : MonoBehaviour
{
    public Text txtLapTime;
    public Text txtLastLap;
    public Text txtBestLap;
    public Text txtLapCount;

    public string RacetrackName; // Exact name of the racetrack gameobject
    public Transform[] Checkpoints; // Array of transforms of all checkpoints
    public int currentCheckpoint = 0;
    public int previousCheckpoint = 0;
    public float CollisionCount = 0f; // Collision count
    public int CheckpointCount = 0; // Checkpoint count

    public int LapCount = 0; // Measure lap count
    public float LapTime = 0; // Measure lap time
    public float LastLapTime = 1e+6f; // Holds last lap time
    public float BestLapTime = 1e+6f; // Holds best lap time

    private Rigidbody VehicleRigidbody; // Vehicle rigid body component
    private Transform SavedCheckpoint; // Transform of latest saved checkpoint
    private bool FinishLineFlag = false; // Finish line flag
    private bool CheckpointFlag = false; // Checkpoint flag

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == RacetrackName) Respawn(); // Collision detected with racetrack
    }

    // Reset lap time and update lap count when crossing start line
    private void OnTriggerEnter(Collider collider)
    {   
        // Redundancy in checking lap completion (Either Finish Line A or Finish Line B are NOT checkpoints)
        if ((collider.tag == "Finish Line A") && !FinishLineFlag && (CheckpointCount >= (Checkpoints.Length-1)))
        {
            // Update only on positive edge of trigger
            LapCount += 1;
            if (LapCount < 10) txtLapCount.text = "0" + LapCount.ToString();
            else txtLapCount.text = LapCount.ToString();
            LastLapTime = LapTime;
            if (LapTime < 10) txtLastLap.text = "0" + LapTime.ToString("f1");
            else txtLastLap.text = LapTime.ToString("f1");
            if (LapTime < BestLapTime)
            {
                BestLapTime = LapTime;
                if (BestLapTime < 10) txtBestLap.text = "0" + BestLapTime.ToString("f1");
                else txtBestLap.text = BestLapTime.ToString("f1");
            }
            LapTime = 0;
            FinishLineFlag = true;
            CheckpointCount = 0;
        }
        else if (collider.tag == "Checkpoint" && !CheckpointFlag)
        {
            CheckpointFlag = true;
            currentCheckpoint = int.Parse(collider.name);
            if (currentCheckpoint == previousCheckpoint+1) CheckpointCount = currentCheckpoint;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        FinishLineFlag = false;
        CheckpointFlag = false;
        previousCheckpoint = currentCheckpoint;
    }

    void Respawn()
    {
        // Reset momentum
        VehicleRigidbody.velocity = Vector3.zero;
        VehicleRigidbody.angularVelocity = Vector3.zero;

        // Get latest passed checkpoint
        SavedCheckpoint = Checkpoints[CheckpointCount%Checkpoints.Length];

        // Reset pose
        gameObject.transform.position = SavedCheckpoint.position;
        gameObject.transform.rotation = SavedCheckpoint.rotation;

        // Update clooision flag and count
        CollisionCount = CollisionCount + 1f; // Update collision count
    }

    public void Start()
    {
        VehicleRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Update lap time on GUI
        if (LapTime < 10) txtLapTime.text = "0" + LapTime.ToString("f1");
        else txtLapTime.text = LapTime.ToString("f1");
    }

    public void FixedUpdate()
    {
        LapTime += Time.fixedDeltaTime; // Update lap time
    }
}