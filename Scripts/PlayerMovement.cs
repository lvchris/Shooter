using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float m_speed = 500f;

    private Rigidbody _player;
    private Vector3 _direction;

    private void Awake()
    {
        _player = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        _direction = Vector3.zero;

        // Other ways to move the player :
        //
        // Way 1
        // transform.Translate(Vector3.right * Time.deltaTime * m_speed);
        //
        // Way 2
        // Vector3 pos = rb.position;
        // Vector3 velocity = direction * m_speed * Time.deltaTime;
        // Vector3 newPos = pos + velocity;
        // rb.MovePosition(newPos);
        //
        // Way 3
        // Vector3 velocity = direction * m_speed * Time.deltaTime;
        // rb.velocity = velocity;
        //
        // Way 4
        // rb.AddForce(Vector3.right * m_force);

        // Keyboard
        if ( Input.GetKey(KeyCode.RightArrow) )
        {
            _direction += Vector3.right;
        }
        if ( Input.GetKey(KeyCode.LeftArrow) )
        {
            _direction += Vector3.left;
        }
        if ( Input.GetKey(KeyCode.UpArrow) )
        {
            _direction += Vector3.forward;
        }
        if ( Input.GetKey(KeyCode.DownArrow) )
        {
            _direction += Vector3.back;
        }

        // Gamepad
        if (Input.GetAxis("Horizontal_Left") > 0)
        {
            _direction += Vector3.right;
        }
        if (Input.GetAxis("Horizontal_Left") < 0)
        {
            _direction += Vector3.left;
        }
        if (Input.GetAxis("Vertical_Left") > 0)
        {
            _direction += Vector3.back;
        }
        if (Input.GetAxis("Vertical_Left") < 0)
        {
            _direction += Vector3.forward;
        }
    }

    private void FixedUpdate()
    {
        _player.velocity = _direction.normalized * m_speed * Time.deltaTime;
    }
}
