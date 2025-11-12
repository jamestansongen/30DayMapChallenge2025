using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckDroneDeployment_Simple : MonoBehaviour
{
    [Header("Drone Settings")]
    public GameObject dronePrefab;          
    public Transform droneMarkersParent;    
    
    [Header("Deployment Settings")]
    public float deploymentDelay = 10f;
    public float spawnHeight = 5f;

    private List<Transform> targets = new List<Transform>();

    void Start()
    {
        // Collect all red box targets from the parent
        if (droneMarkersParent != null)
        {
            foreach (Transform child in droneMarkersParent)
            {
                targets.Add(child);
            }
        }
        else
        {
            Debug.LogError("DroneMarkersParent is not assigned!");
            return;
        }

        if (targets.Count == 0)
        {
            Debug.LogWarning("No target markers found in droneMarkersParent!");
            return;
        }

        Debug.Log($"Truck initialized with {targets.Count} targets.");

        // Start deploying drones
        StartCoroutine(DeployDronesEndless());
    }

    IEnumerator DeployDronesEndless()
    {
        while (true)
        {
            // Wait before deploying next drone
            yield return new WaitForSeconds(deploymentDelay);

            // Select random target
            int index = Random.Range(0, targets.Count);
            Transform target = targets[index];

            // Instantiate drone at spawn height above truck
            Vector3 spawnPos = transform.position + Vector3.up * spawnHeight;
            GameObject drone = Instantiate(dronePrefab, spawnPos, Quaternion.identity);
            DroneUIManager.Instance?.DroneLaunched(); // ✅ count this launch

            Debug.Log($"Drone deployed to target: {target.name}");

            // Set drone to the correct layer
            drone.layer = LayerMask.NameToLayer("Drone");

            // Assign target and truck reference
            DroneMovement_Simple droneScript = drone.GetComponent<DroneMovement_Simple>();
            if (droneScript != null)
            {
                droneScript.SetTarget(target, transform);
            }
            else
            {
                Debug.LogError("DroneMovement_Simple script not found on drone prefab!");
                Destroy(drone);
            }
        }
    }
}