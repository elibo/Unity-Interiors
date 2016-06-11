using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
    public float vel = 100;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vel * Time.deltaTime, 0, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            DestroyObject(gameObject);
        }

    }
}
