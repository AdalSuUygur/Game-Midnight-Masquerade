using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private float followSpeed = 5f;
    private Transform target;
    private Vector3 offset;
    public float startX;
    private void Start()
    {
        offset = new Vector3(0, -2f, -10);
        var player = GameObject.FindWithTag("Player");
        if (player)
        {
            target = player.transform;
            // Snap immediately to avoid lerp delay, respecting bounds
            float targetX = Mathf.Max(target.position.x + offset.x, startX);
            transform.position = new Vector3(targetX, target.position.y + offset.y, offset.z);
        }
    }
    void LateUpdate()
    {
        if (!target)
        {
          var player = GameObject.FindWithTag("Player");
            if (player)
            {
                target = player.transform;
                // Snap immediately to avoid lerp delay, respecting bounds
                float targetX = Mathf.Max(target.position.x + offset.x, startX);
                transform.position = new Vector3(targetX, target.position.y + offset.y, offset.z);
            }
            else
            {
                return;
            }
        }

        if (target == null) return;
       
        Vector3 desiredPosition = target.position + offset;
        Vector3 newPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);
        newPosition.x = newPosition.x < startX ? startX : newPosition.x;
        transform.position = newPosition;
    }
}
