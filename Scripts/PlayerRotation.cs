using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float m_rotate_speed = 5f;
    private Rigidbody _player;

    private void Awake()
    {
        _player = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        /*
        // Other way to rotate
        if (Input.GetAxis("Horizontal_Right") > 0)
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(rb.rotation, Quaternion.LookRotation(Vector3.right, Vector3.up), rotateSpeed);
        }
        if (Input.GetAxis("Horizontal_Right") < 0)
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(rb.rotation, Quaternion.LookRotation(Vector3.left, Vector3.up), rotateSpeed);
        }
        if (Input.GetAxis("Vertical_Right") > 0)
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(rb.rotation, Quaternion.LookRotation(Vector3.forward, Vector3.up), rotateSpeed);
        }
        if (Input.GetAxis("Vertical_Right") < 0)
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(rb.rotation, Quaternion.LookRotation(Vector3.back, Vector3.up), rotateSpeed);
        }
        */


        if (Input.GetKey(KeyCode.D))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.right, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(_player.rotation, Quaternion.LookRotation(Vector3.right, Vector3.up), m_rotate_speed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.left, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(_player.rotation, Quaternion.LookRotation(Vector3.left, Vector3.up), m_rotate_speed);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(_player.rotation, Quaternion.LookRotation(Vector3.forward, Vector3.up), m_rotate_speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(_player.rotation, Quaternion.LookRotation(Vector3.back, Vector3.up), m_rotate_speed);
        }

        if (Input.GetAxis("Horizontal_Right") != 0 || Input.GetAxis("Vertical_Right") != 0)
        {
            Debug.Log("a");
            Vector3 rotation = new Vector3(Input.GetAxis("Horizontal_Right"), 0, Input.GetAxis("Vertical_Right"));
            transform.rotation = Quaternion.LookRotation(rotation, Vector3.up);
        }
    }
}
