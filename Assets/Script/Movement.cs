using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    bool alive = true;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedBoost = 1f;
    [SerializeField] private float turnSpeed = 200f;

    private int steerValue;
    

    // Update is called once per frame
    void Update()
    {

        if (!alive) return;

        speed += speedBoost * Time.deltaTime;

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime,0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //if fallen down
        if (transform.position.y < -5)
        {
            Die();
        }
    }



    //private void OnCollisionEnter(Collision collision)
    //{
        
    //    if(collision.collider.name == "Obstacle")
    //    {

    //        Application.Quit();
    //    }
    //}

   


    public void steer(int value)
    {
        steerValue = value;
    }
  




public void Die()
{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}
