using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;
    private Vector2 movementVec;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move() {
        float forceX = speed * movementVec.x;
        float forceY = speed * movementVec.y;
        rb.AddForce( new Vector2(forceX, forceY) );
    }

    public void OnMove(InputAction.CallbackContext ctx) => movementVec = ctx.ReadValue<Vector2>();
}
