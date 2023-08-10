using UnityEngine;

public class infinte_move : MonoBehaviour
{
    public Transform playerTransform;
    public Transform cameraTransform;
    public float resetPositionX = -100f;

    void Update()
    {
        // Check if the player or camera has moved beyond the resetPositionX
        if (playerTransform.position.x < resetPositionX)
        {
            // Teleport the plane back to its original position
            Vector3 newPos = transform.position;
            newPos.x = 0f;
            transform.position = newPos;
        }
    }
}