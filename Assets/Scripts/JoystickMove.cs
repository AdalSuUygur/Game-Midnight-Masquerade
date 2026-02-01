using UnityEngine;

public class JoystickMove : MonoBehaviour
{
    private Joystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rgb2d;
    PlayerController playerController;
    private void Awake()
    {
        movementJoystick = GameObject.Find("Floating Joystick").GetComponent<FloatingJoystick>();
    }
    private void Start()
    {
        rgb2d = gameObject.GetComponent<Rigidbody2D>();
        playerController = gameObject.GetComponent<PlayerController>();
    }
    private void FixedUpdate()
    {
        //if (movementJoystick.Direction.y != 0)
        //{
        //    rgb2d.linearVelocity = new Vector2(movementJoystick.Direction.x * playerSpeed, movementJoystick.Direction.y * playerSpeed);
        //}
        //else
        //{
        //    rgb2d.linearVelocity = Vector2.zero;
        //}
        Move();
    }
    public void Move()
    {
        if (movementJoystick.Direction.y != 0 && playerController.canMove)
        {
            rgb2d.linearVelocity = new Vector2(movementJoystick.Direction.x * playerSpeed, movementJoystick.Direction.y * playerSpeed);
        }
        else
        {
            rgb2d.linearVelocity = Vector2.zero;
        }
    }

}
