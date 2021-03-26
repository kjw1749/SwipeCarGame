using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCon : MonoBehaviour
{

    float speed = 0.0f;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (gameObject.tag == "wall")
        {
            Debug.Log("닿음");
            transform.Translate(this.speed, 0, 0);
            this.speed = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - startPos.x);
            this.speed = swipeLength / 500.0f;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
        
    }
}
