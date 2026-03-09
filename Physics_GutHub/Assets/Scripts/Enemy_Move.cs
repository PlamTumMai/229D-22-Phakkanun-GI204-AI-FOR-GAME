using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = new Vector3(startPos.x + movement, startPos.y, startPos.z);
    }
}
