using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement_Simple : MonoBehaviour
{
    [Header("Drone Settings")]
    public float speed = 10f;
    public float ascentSpeed = 5f;
    public float flightHeight = 10f;
    public float hoverHeight = 5f;
    public float hoverDuration = 5f;
    public float avoidanceRadius = 20f;
    public float droneAvoidanceStrength = 20f;
    public float buildingAvoidanceStrength = 15f;
    public float maxAvoidanceForce = 30f;
    public float deliveryDistanceThreshold = 0.5f;

    [Header("Layers")]
    public LayerMask droneLayerMask;
    public LayerMask buildingLayerMask;

    private Rigidbody rb;
    private Transform target;
    private Transform truck;
    private Vector3 truckPosition;
    private float hoverTimer = 0f;

    // ✅ Add this missing variable
    private bool actionStarted = false;

    private enum DroneState
    {
        AscendToFlightHeight,
        MoveToTarget,
        DescendToHover,
        Hovering,
        AscendBack,
        MoveToTruck,
        DescendBack,
        Completed
    }

    private DroneState currentState = DroneState.AscendToFlightHeight;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null) rb = gameObject.AddComponent<Rigidbody>();

        rb.useGravity = false;
        rb.isKinematic = true;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        if ((target == null && currentState < DroneState.AscendBack) ||
            (truck == null && currentState >= DroneState.MoveToTruck))
            return;

        Vector3 nextPos = transform.position;

        switch (currentState)
        {
            case DroneState.AscendToFlightHeight:
                nextPos += Vector3.up * ascentSpeed * Time.fixedDeltaTime;
                if (nextPos.y >= flightHeight)
                {
                    nextPos.y = flightHeight;
                    currentState = DroneState.MoveToTarget;
                }
                break;

            case DroneState.MoveToTarget:
                MoveToPoint(new Vector3(target.position.x, flightHeight, target.position.z), DroneState.DescendToHover, ref nextPos);
                break;

            case DroneState.DescendToHover:
                MoveToPoint(new Vector3(target.position.x, target.position.y + hoverHeight, target.position.z), DroneState.Hovering, ref nextPos);
                break;

            case DroneState.Hovering:
                hoverTimer += Time.fixedDeltaTime;
                if (hoverTimer >= hoverDuration)
                {
                    currentState = DroneState.AscendBack;
                }
                break;

            case DroneState.AscendBack:
                nextPos += Vector3.up * ascentSpeed * Time.fixedDeltaTime;
                if (nextPos.y >= flightHeight)
                {
                    nextPos.y = flightHeight;
                    currentState = DroneState.MoveToTruck;
                }
                break;

            case DroneState.MoveToTruck:
                MoveToPoint(new Vector3(truckPosition.x, flightHeight, truckPosition.z), DroneState.DescendBack, ref nextPos);
                break;

            case DroneState.DescendBack:
                MoveToPoint(truckPosition, DroneState.Completed, ref nextPos);
                break;

            case DroneState.Completed:
                if (!actionStarted)
                {
                    actionStarted = true;
                    DroneUIManager.Instance?.DroneReturned();
                    Destroy(gameObject);
                }
                break;
        }

        rb.MovePosition(nextPos);
    }

    private void MoveToPoint(Vector3 point, DroneState nextState, ref Vector3 nextPos)
    {
        Vector3 dir = (point - transform.position).normalized;
        Vector3 avoidance = CalculateAvoidance();
        Vector3 move = (dir + avoidance).normalized * speed * Time.fixedDeltaTime;
        nextPos += move;

        if (Vector3.Distance(transform.position, point) < deliveryDistanceThreshold)
        {
            currentState = nextState;
            hoverTimer = 0f;
        }
    }

    public void SetTarget(Transform newTarget, Transform truckTransform)
    {
        target = newTarget;
        truck = truckTransform;
        truckPosition = truck.position;
        currentState = DroneState.AscendToFlightHeight;
    }

    Vector3 CalculateAvoidance()
    {
        Vector3 avoidance = Vector3.zero;

        Collider[] drones = Physics.OverlapSphere(transform.position, avoidanceRadius, droneLayerMask);
        foreach (Collider drone in drones)
        {
            if (drone.gameObject != this.gameObject)
            {
                Vector3 dir = transform.position - drone.transform.position;
                float dist = dir.magnitude;
                if (dist > 0.01f)
                    avoidance += dir.normalized * Mathf.Min(droneAvoidanceStrength / (dist * dist), maxAvoidanceForce);
            }
        }

        Collider[] buildings = Physics.OverlapSphere(transform.position, avoidanceRadius, buildingLayerMask);
        foreach (Collider building in buildings)
        {
            Vector3 closest = building.ClosestPoint(transform.position);
            Vector3 dir = transform.position - closest;
            float dist = dir.magnitude;
            if (dist > 0.01f)
                avoidance += dir.normalized * Mathf.Min(buildingAvoidanceStrength / (dist * dist), maxAvoidanceForce);
        }

        return avoidance;
    }
}