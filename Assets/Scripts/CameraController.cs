using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;       // Reference to the player GameObject
    private Vector3 offset;         // Offset distance between the player and camera

    // Start is called before first frame update
    void Start()
    {
        // Calculate the initial offset between the camera and player
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after all Update functions have been called. We can make sure our camera is set after any other updates such as physics or animations.
    void LateUpdate()
    {
        // Update the camera translation to follow player every frame
        transform.position = player.transform.position + offset;
    }


}
