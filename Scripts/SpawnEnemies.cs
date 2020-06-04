using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float m_delay = 5f;
    public Transform[] m_spawns;
    public GameObject[] m_enemies;
    public ParticleSystem m_spawningParticles;
    public GameObject m_target;

    private float _initialDelay;

    private void Awake()
    {
        _initialDelay = m_delay;
    }

    private void Update()
    {
        m_delay -= Time.deltaTime;
        if (m_delay <= 0)
        {
            int spawnPoint = Random.Range(0, m_spawns.Length);
            int enemyType = Random.Range(0, m_enemies.Length);
            m_spawningParticles.Play();
            GameObject enemy = Instantiate(m_enemies[enemyType], m_spawns[spawnPoint].position, Quaternion.identity);
            enemy.GetComponent<EnemyMoveTowardsPlayer>().m_target = m_target;
            enemy.GetComponent<EnemyHealth>().m_target = m_target;
            enemy.GetComponent<EnemyHealth>().m_gameEvents = gameObject;
            m_delay = _initialDelay;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(m_spawns[0].transform.position, 2);
        Gizmos.DrawWireSphere(m_spawns[1].transform.position, 2);
    }
}
