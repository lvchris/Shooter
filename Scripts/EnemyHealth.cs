using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int m_health = 1;
    public int m_scoreGiven = 10;
    public float m_invincibility = 0.5f;
    public GameObject m_gameEvents;
    public GameObject m_target;
    public IntVariable m_score;

    private float _initialInvincibility;

    private void Awake()
    {
        _initialInvincibility = m_invincibility;
    }

    private void Update()
    {
        m_invincibility -= Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_target.GetComponent<PlayerHealth>().Damaged();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (m_invincibility <= 0)
        {
            m_health -= 1;
            if (m_health == 0)
            {
                m_score.value += m_scoreGiven;
                m_gameEvents.GetComponent<ManageScore>().ActualiseScore();
                m_gameEvents.GetComponent<ManageSound>().EnemyHitSound();
                m_gameEvents.GetComponent<ManageSound>().ExplosionSound();
                //if (gameObject.transform.parent != null) Destroy(gameObject.transform.parent.gameObject);
                //else Destroy(gameObject);
                Destroy(gameObject);
            }
            else m_invincibility = _initialInvincibility;
        }
    }
}
