using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float m_cooldown = 0.25f;
    public GameObject m_spawn;
    public GameObject m_projectile;
    public AudioSource m_shooting_sound;

    private float _initial_cooldown;

    private void Awake()
    {
        _initial_cooldown = m_cooldown;
        m_cooldown = 0;
    }

    private void Update()
    {
        m_cooldown -= Time.deltaTime;

        if (m_cooldown <= 0)
        {
            if (Input.GetAxis("Fire1") > 0 || Input.GetKey(KeyCode.Space))
            {
                Instantiate(m_projectile, m_spawn.transform.position, transform.rotation);
                m_shooting_sound.Play();
                m_cooldown = _initial_cooldown;
            }
        }
    }
}
