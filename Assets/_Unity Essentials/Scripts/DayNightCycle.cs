using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Number of real-time seconds for a full in-game day.")]
    public float secondsPerDay = 120f; // Default: 2 minutes per day

    private float rotationSpeed; // Degrees per second

    void Start()
    {
        // 360 degrees in a full day
        rotationSpeed = 360f / secondsPerDay;
    }

    void Update()
    {
        // Rotate around the X axis to simulate sun movement
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
