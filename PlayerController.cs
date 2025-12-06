using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // player movement input variable
    public float playerHorizontalInput;

    // player movement speed
    public float playerSpeed = 10.0f;

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

    }
}
