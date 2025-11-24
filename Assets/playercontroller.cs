using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{ 
    InputAction move_action;
    Rigidbody2D rb_rotate;
    float speed = 1f;
    void Start()
    {
        move_action = InputSystem.actions.FindAction("Move");
        rb_rotate = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 move_vector = move_action.ReadValue<Vector2>();
    
        if (move_vector.x < 0)
        {
            rb_rotate.AddTorque(speed);
        }
        else if (move_vector.x > 0)
        {
            rb_rotate.AddTorque(-speed);
        }
    }
}
