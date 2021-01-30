using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool collideElfe1 = false;
    public bool collideElfe2 = false;
    public bool collideGift = false;
    public int points = 0;
    public GameObject GrinchlObjekt;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI timeText;



    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.name.Contains("Geschenk"))
        {
            Destroy(collision.gameObject);
            collideGift = true;
            points++;
            scoreDisplay.text = points.ToString();
        }
        if (collision.name.Contains("Elfe1"))
        {
            Destroy(collision.gameObject);
            collideElfe1 = true;
            points--;
            scoreDisplay.text = points.ToString();
        }

        if (collision.name.Contains("Elfe2"))
        {
            Destroy(collision.gameObject);
            collideElfe2 = true;
            points--;
            scoreDisplay.text = points.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    { 
        if (points < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
