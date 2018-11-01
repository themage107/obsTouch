using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsTouch : MonoBehaviour {

    public BoxCollider2D thisBox;
    float xValue;

    void Start()
    {
        thisBox = this.gameObject.GetComponent<BoxCollider2D>();
        xValue = thisBox.transform.position.x;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wallCheck")
        {
            moveJohnnyUpdated obsTouchInstance = collision.gameObject.transform.parent.GetComponent<moveJohnnyUpdated>();
            obsTouchInstance.obsTouching = true;
            obsTouchInstance.obsX = xValue;
        }
        if (collision.gameObject.name == "JohnnyHitBox")
        {
            moveJohnnyUpdated obsTouchInstanceJ = collision.gameObject.transform.parent.GetComponent<moveJohnnyUpdated>();
            obsTouchInstanceJ.obsTouchingJohnny = true;
            obsTouchInstanceJ.obsX = xValue;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wallCheck")
        {
            moveJohnnyUpdated obsTouchInstance = collision.gameObject.transform.parent.GetComponent<moveJohnnyUpdated>();
            obsTouchInstance.obsTouching = false;
            obsTouchInstance.obsX = 0;
        }
        if (collision.gameObject.name == "JohnnyHitBox")
        {
            moveJohnnyUpdated obsTouchInstanceJ = collision.gameObject.transform.parent.GetComponent<moveJohnnyUpdated>();
            obsTouchInstanceJ.obsTouchingJohnny = false;
            obsTouchInstanceJ.obsX = xValue;
        }
    }
}
