using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject m_projectile;
    public GameObject m_spawn;
    public float m_cooldown = 0.5f;

    private float _initialCooldown;

    private void Awake()
    {
        _initialCooldown = m_cooldown;
    }

    private void Update()
    {
        m_cooldown -= Time.deltaTime;

        if ( m_cooldown <= 0 )
        {
            Instantiate(m_projectile, m_spawn.transform.position, transform.rotation);
            m_cooldown = _initialCooldown;
        }
    }
}
