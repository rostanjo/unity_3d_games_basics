using System.Xml.Schema;
using UnityEngine;

public class Spinner : MonoBehaviour
{   
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 1f;
    [SerializeField] float zValue = 0f;
    [SerializeField] float speed = 100f;

    void Update()
    {
        transform.Rotate(xValue * Time.deltaTime * speed, yValue * Time.deltaTime * speed, zValue * Time.deltaTime * speed);
    }
}
