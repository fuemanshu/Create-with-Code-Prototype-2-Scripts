using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // player movement input variable
    public float playerHorizontalInput;

    // player movement speed
    public float playerSpeed = 10.0f;

    // boundary variable
    public float xRange = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move player left/right based on user input
        playerHorizontalInput = Input.GetAxis("Horizontal");

        // translate input to actually move player
        transform.Translate(Vector3.right * playerHorizontalInput * Time.deltaTime * playerSpeed);

        // keep player inbounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


    }
}
