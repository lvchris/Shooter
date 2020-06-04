using UnityEngine;

public class EnemyMultipleShoot : MonoBehaviour
{
    public GameObject m_projectile;
    public Transform[] m_spawns;
    public float m_cooldown = 0.2f;

    private float _initialCooldown;

    private void Awake()
    {
        _initialCooldown = m_cooldown;
    }

    private void Update()
    {
        m_cooldown -= Time.deltaTime;
        if (m_cooldown <= 0)
        {
            foreach(Transform spawn in m_spawns) Instantiate(m_projectile, spawn.position, spawn.rotation);
            m_cooldown = _initialCooldown;
        }
    }
}
