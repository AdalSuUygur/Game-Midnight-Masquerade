using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;
using static Assets.Constants;

public class PlayerController : MonoBehaviour
{
    
    public bool canMove = true;
    string maskName = string.Empty;
    float minSpeed = 0.5f;
    GameController gameController;
    Rigidbody2D rgb2d;
    ZoneType currentZone;
    void Start()
    {
        rgb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        switch (currentZone){
            case ZoneType.RedZone:
                MoveWithRedMask(maskName);
                break;
            case ZoneType.BlueZone:
                MoveWithBlueMask(maskName);
                break;
            case ZoneType.GreenZone:
                MoveWithGreenMask(maskName);
                break;
        }
        if (!canMove)
        {
            Debug.Log(canMove);
            rgb2d.linearVelocity = Vector2.zero;
            return;
        }
       
    }
    private void FixedUpdate()
    {
        float speed = rgb2d.linearVelocity.magnitude;
        bool isMoving = speed >= minSpeed;


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case TileMapNameAristocrat:
                SetZoneType(ZoneType.RedZone);
                break;
            case TileMapNameMaid:
                SetZoneType(ZoneType.BlueZone);
                break;
            case TileMapNameMusician:
                SetZoneType(ZoneType.GreenZone);
                break;
            case TileMapNameGround:
                SetZoneType(ZoneType.Ground);
                break;
        }


    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case TileMapNameAristocrat:
                SetZoneType(ZoneType.RedZone);
                break;
            case TileMapNameMaid:
                SetZoneType(ZoneType.BlueZone);
                break;
            case TileMapNameMusician:
                SetZoneType(ZoneType.GreenZone);
                break;
            case TileMapNameGround:
                SetZoneType(ZoneType.Ground);
                break;
        }
    }
    public void SetZoneType(ZoneType zoneType)
    {
        currentZone = zoneType;
    }
    public void MoveWithRedMask(string maskName)
    {
        if (maskName != RedMask)
        {
            gameController.IncreaseAware();
        }
        else
        {
            StartCoroutine(SetCanMove());
        }

    }
    public void MoveWithBlueMask(string maskName)
    {
        if (maskName != BlueMask)
        {
            gameController.IncreaseAware();
        }
        else
        {

        }
    }
    public void MoveWithGreenMask(string maskName)
    {
        if (maskName != GreenMask)
        {
            gameController.IncreaseAware();
        }
        else
        {

        }
    }

    public IEnumerator SetCanMove()
    {
        canMove = false;
        yield return new WaitForSeconds(1.5f);
        canMove = true;
    }
}
