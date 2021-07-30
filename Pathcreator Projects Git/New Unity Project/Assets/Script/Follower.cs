using UnityEngine;
using PathCreation;
using UnityEngine.SceneManagement;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 0.05f;
    float distanceTravelled;
    public GameObject player;

    void Start()
    {
        player = transform.GetChild(0).gameObject;
       // player.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    void FixedUpdate()
    {
        //transform.rotation = Quaternion.Euler(0, 0, 0);
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
