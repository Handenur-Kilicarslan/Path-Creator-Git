using UnityEngine;
using PathCreation;
using UnityEngine.SceneManagement;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 0.05f;
    float distanceTravelled;

    void Update()
    {
        distanceTravelled += speed + Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled); //objenin konumunu yola eşledik
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Finish")
        {
            Debug.Log("çarpıştı");
            SceneManager.LoadScene("Ara Scene");
        }
    }


}
