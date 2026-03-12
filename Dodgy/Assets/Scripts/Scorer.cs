using UnityEngine;
using UnityEngine.InputSystem;

public class Scorer : MonoBehaviour
{   
    int counter = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            counter++;
            Debug.Log("You've bumped into a thing this many times: " + counter);
        }
    }
}
