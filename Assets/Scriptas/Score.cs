using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public float score = 0f;
    public bool unique1;
    public bool unique2;
    public bool unique3;
    public Text scoreText;
    public Text unique1Text;
    public Text unique2Text;
    public Text unique3Text;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Score1"))
        {
            score += 25;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Score2"))
        {
            score += 75;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Score3"))
        {
            score += 150;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Unique1"))
        {
            unique1 = true;
            Destroy(collision.gameObject);
            unique1Text.text = "Unique 1: Collected!";
            
        }
        if (collision.gameObject.CompareTag("Unique2"))
        {
            unique2 = true;
            Destroy(collision.gameObject);
            unique2Text.text = "Unique 2: Collected!";
          
        }
        if (collision.gameObject.CompareTag("Unique3"))
        {
            unique3 = true;
            Destroy(collision.gameObject);
            unique3Text.text = "Unique 3: Collected!";
           
        }
    }

    void Update()
    {
        scoreText.text = "Score:" + score.ToString() + "$";
    
    }

}
