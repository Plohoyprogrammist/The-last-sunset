using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float blinckForce;
    private Vector2 movement;
    private Rigidbody2D rb2DPlayer;
    private bool isBlinck = false;


    private void Start()
    {
        rb2DPlayer = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isBlinck = true;
        }
        Debug.Log(movement + " " + isBlinck);
    }

    private void FixedUpdate()
    {
        if (isBlinck && movement != Vector2.zero)
        {
            rb2DPlayer.AddForce(movement * blinckForce * Time.fixedDeltaTime, ForceMode2D.Impulse);
            isBlinck = false;
        }
        else 
        {
            rb2DPlayer.AddForce(movement * speed * Time.fixedDeltaTime, ForceMode2D.Force);
        }

    }
}
