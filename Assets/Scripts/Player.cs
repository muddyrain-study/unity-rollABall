using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    public int score = 0;
    public Text scoreText;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");
        rd.AddForce(new Vector3(h, jump, v));
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            this.score += 1;
            this.scoreText.text = "·ÖÊý: " + this.score;
            if (this.score == 30)
            {
                this.winText.SetActive(true);
            }
        }

    }
}
