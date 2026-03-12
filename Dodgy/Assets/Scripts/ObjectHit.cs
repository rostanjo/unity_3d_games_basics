using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
    }
}
