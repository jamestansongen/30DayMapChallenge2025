using UnityEngine;

public class FreeFlyCamera : MonoBehaviour
{
    public float speed = 10f;
    public float mouseSensitivity = 3f;

    float yaw = 0f;
    float pitch = 0f;

    void Update()
    {
        // Mouse look
        yaw += mouseSensitivity * Input.GetAxis("Mouse X");
        pitch -= mouseSensitivity * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -90f, 90f);
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);

        // Movement
        Vector3 forward = transform.forward;
        Vector3 right = transform.right;
        Vector3 move = (forward * Input.GetAxis("Vertical") + right * Input.GetAxis("Horizontal"));
        if (Input.GetKey(KeyCode.Space)) move += Vector3.up;
        if (Input.GetKey(KeyCode.LeftShift)) move -= Vector3.up;

        transform.position += move * speed * Time.deltaTime;
    }
}
