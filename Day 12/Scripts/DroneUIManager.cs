using UnityEngine;
using TMPro;

public class DroneUIManager : MonoBehaviour
{
    public static DroneUIManager Instance;

    public TextMeshProUGUI dronesInFlightText;
    public TextMeshProUGUI deliveriesCompletedText;

    private int dronesInFlight = 0;
    private int deliveriesCompleted = 0;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void DroneLaunched()
    {
        dronesInFlight++;
        UpdateUI();
    }

    public void DroneReturned()
    {
        dronesInFlight--;
        deliveriesCompleted++;
        UpdateUI();
    }

    void UpdateUI()
    {
        dronesInFlightText.text = $"Drones in Flight: {dronesInFlight}";
        deliveriesCompletedText.text = $"Deliveries Completed: {deliveriesCompleted}";
    }
}
