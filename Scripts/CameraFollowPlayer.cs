using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        if (player == null) return;
        gameObject.transform.position = player.transform.position + Vector3.back * 12 + Vector3.up * 20;
    }
}
