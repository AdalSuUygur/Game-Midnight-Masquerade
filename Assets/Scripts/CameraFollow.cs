using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private float followSpeed = 5f;
    private Transform target;
    private Vector3 offset;
    public float startX;
    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        Debug.Log(target);
        offset = new Vector3(0, 0, -10);
    }
    void LateUpdate()
    {
        if (!target)
        {
          var player = GameObject.FindWithTag("Player");
            if (player)
                target = player.transform;
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
