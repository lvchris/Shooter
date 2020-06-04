using UnityEngine;

public class BulletCharacteritics : MonoBehaviour
{
    public float m_speed = 20f;

    private Rigidbody _bullet;

    private void Awake()
    {
        _bullet = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _bullet.velocity = transform.forward * m_speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
