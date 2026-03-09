using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;

    public AudioClip moveSound;

    private Vector3 startPos;
    private AudioSource audioSource;

    void Start()
    {
        startPos = transform.position;

        audioSource = GetComponent<AudioSource>();

        if(moveSound != null)
        {
            audioSource.clip = moveSound;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = new Vector3(startPos.x + movement, startPos.y, startPos.z);
    }
}