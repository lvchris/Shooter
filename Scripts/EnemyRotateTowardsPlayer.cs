using UnityEngine;

public class EnemyRotateTowardsPlayer : MonoBehaviour
{
    public float m_rotateSpeed = 2f;
    private GameObject _player;
    private Rigidbody _enemy;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player");
        _enemy = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_player == null) return;
        Vector3 direction = _player.transform.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(_enemy.rotation, Quaternion.LookRotation(direction, Vector3.up), m_rotateSpeed);
    }
}
