using UnityEngine;

public class EnemySpin : MonoBehaviour
{
    public float m_rotate_speed = 10f;

    private Vector3 _angle;

    private void Awake()
    {
        _angle = transform.eulerAngles;
    }

    private void Update()
    {
        transform.eulerAngles += _angle * Time.deltaTime * m_rotate_speed;
        //transform.Rotate(Vector3.up, m_rotate_speed * Time.deltaTime, Space.Self);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, transform.rotation, m_rotate_speed);
    }
}
