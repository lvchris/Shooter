using UnityEngine;

public class ManageSound : MonoBehaviour
{
    public AudioSource m_EnemyHitSound;
    public AudioSource m_explosionSound;

    public void EnemyHitSound()
    {
        m_EnemyHitSound.Play();
    }

    public void ExplosionSound()
    {
        m_explosionSound.Play();
    }
}
