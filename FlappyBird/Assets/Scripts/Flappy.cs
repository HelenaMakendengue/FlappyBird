using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flappy : MonoBehaviour {

    public GameObject playAgainButton;

    public Rigidbody rb;
    public float jumpForce;

    private void Start()
    {
        Debug.Log("Hello World!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Don't need this for play again button...
        //ScoreManger.SCORE = 0;
        //SceneManager.LoadScene(0);

        Destroy(gameObject);
        playAgainButton.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("It works!");
        ScoreManger.SCORE++;
    }
}
