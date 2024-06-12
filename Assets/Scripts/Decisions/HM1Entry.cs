using Articy.Zombo.GlobalVariables;
using UnityEngine;

public class HM1Entry : MonoBehaviour
{
    public Transform objectToMove; // Reference to the object you want to move
    public float moveSpeed = 1.0f; // Speed at which the object moves downward
    public float targetHeight = -7.5f; // Height to which the object should fall

    void Update()
    {
        if (ArticyGlobalVariables.Default.HordeMaster1Decisions.HM1AllowEntry)
        {
            MoveObjectDownward();
        }
    }

    void MoveObjectDownward()
    {
        // Check if the object to move is assigned
        if (objectToMove != null)
        {
            // Calculate the distance to the target height
            float distanceToTarget = objectToMove.position.y - targetHeight;

            // If the object is above the target height, move it downward
            if (distanceToTarget > 0)
            {
                // Calculate the movement step
                float step = Mathf.Min(moveSpeed * Time.deltaTime, distanceToTarget);

                // Move the object downward
                objectToMove.Translate(Vector3.down * step);
            }
        }
        else
        {
            Debug.LogError("Object to move is not assigned.");
        }
    }
}
