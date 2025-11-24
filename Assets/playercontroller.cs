using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{ 
    InputAction move_action;
    Rigidbody2D rb_rotate;
    SurfaceEffector2D surfaceEffector2D;
    Vector2 move_vector;
  [SerializeField]  float speed = 2f;
  [SerializeField]  float basespeed = 15f;
  [SerializeField]  float boostspeed = 25f;


    void Start()
    {
        move_action = InputSystem.actions.FindAction("Move");
        rb_rotate = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();//we can get it by serializefield also
    }

    void Update()
    {
       move_vector = move_action.ReadValue<Vector2>();
       rotate();
       boost();
    }
    void rotate()
    {
       
       
    
        if (move_vector.x < 0)
        {
            rb_rotate.AddTorque(speed);
        }
        else if (move_vector.x > 0)
        {
            rb_rotate.AddTorque(-speed);
        }
    }
    void boost()
    {
        
        
        if (move_vector.y > 0)
        {
           surfaceEffector2D.speed = boostspeed;
        }
        else
        {
           surfaceEffector2D.speed = basespeed;
        }
    }
}
