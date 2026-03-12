using UnityEngine;

public class Dropper : MonoBehaviour
{   
    [SerializeField] float timeToWait = 3f;
    
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    void Start()
    {
        myMeshRenderer = gameObject.GetComponent<MeshRenderer>();
        myRigidBody = gameObject.GetComponent<Rigidbody>();
        
        myRigidBody.useGravity = false;
        myMeshRenderer.enabled = false;
    }
    void Update()
    {
        DropObject();
    }

    void OnCollisionEnter(Collision collision)
    {
        myRigidBody.useGravity = false;
    }

    void DropObject()
    {
        if(Time.time > timeToWait)
        {
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}
