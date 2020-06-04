using UnityEngine;

public class EnemyMoveTowardsPlayer : MonoBehaviour
{
    public float m_speed = 350f;
    public GameObject m_target;

    private Rigidbody _enemy;
    private Vector3 direction;

    private void Awake()
    {
        _enemy = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (m_target == null) return;
        direction = m_target.transform.position - transform.position;
    }

    private void FixedUpdate()
    {
        _enemy.velocity = direction.normalized * m_speed * Time.deltaTime;
    }

}
