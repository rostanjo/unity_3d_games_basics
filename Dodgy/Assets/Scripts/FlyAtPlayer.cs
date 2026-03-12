using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 0.2f;
    Vector3 playerPosition;
    

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {   
        if (Time.time % 3 <= 0.1)
        {
            playerPosition = player.transform.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed);
    }
}
