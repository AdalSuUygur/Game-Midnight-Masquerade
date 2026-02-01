using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public Tilemap groundTilemap;
    public TileBase patienceTile;
    public TileBase maidTile;
    public TileBase musicianTile;
    public TileBase groundTile;

    TileBase momentTile;
    public bool canMove=true;
    Vector3 previousPosition, momentPosition;
    string maskName = string.Empty;
    float minSpeed = 0.5f;
    Rigidbody2D rgb2d;
    void Start()
    {
        rgb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!canMove)
        {
            Debug.Log(canMove);
            rgb2d.linearVelocity = Vector2.zero;
            return;
        }
        Vector3Int cell = groundTilemap.WorldToCell(transform.position);
        momentTile = groundTilemap.GetTile(cell);
        previousPosition = transform.position;
        
        if (momentTile == patienceTile )
        {
            StartCoroutine(SetCanMove());
        }
        else if (momentTile == musicianTile && maskName == "Green Mask")
        {
            //momentPosition = transform.position;
            if (momentPosition == previousPosition)
            {
                Debug.Log("Canýn azaldý");
            }
        }
        else if (momentTile == maidTile && maskName == "Blue Mask")
        {
            Debug.Log("Maid");
        }
        else if(momentTile==groundTile)
        {
            Debug.Log("Ground");
        }
        else
        {
            //can azaldý
        }
    }
    private void FixedUpdate()
    {
        float speed = rgb2d.linearVelocity.magnitude;
        bool isMoving = speed >= minSpeed;


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            GameManager.PrepareScene();
        }
        if (collision.gameObject.tag == "Mask")
        {
            maskName = collision.gameObject.name;
            Destroy(collision.gameObject);
        }

    }
    public IEnumerator SetCanMove()
    {
        canMove = false;
        yield return new WaitForSeconds(1.5f);
        canMove = true;
    }

}
