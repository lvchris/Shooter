using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int m_health = 1;
    public GameObject m_gameEvent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("EnemyProjectile")) Damaged();
    }

    public void Damaged()
    {
        if (m_health <= 0)
        {
            m_gameEvent.GetComponent<ManageSound>().ExplosionSound();
            Destroy(gameObject);
        }
        else m_health -= 1;
    }
}
