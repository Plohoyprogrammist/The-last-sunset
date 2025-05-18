using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 movement;
    private Rigidbody2D rb2DPlayer;


    private void Start()
    {
        rb2DPlayer = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        rb2DPlayer.AddForce(movement * speed * Time.fixedDeltaTime, ForceMode2D.Force);
    }
}
