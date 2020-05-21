using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //Player speed.
    public float speed;

    //Jump vars.
    public float jumpSpeed;
    private bool isJumping;

    //Pick-ups number.
    public int PickUpsNum;

    //Vector3 to save init position.
    private Vector3 initPosition;

    //Pick-ups retrieved counter.
    private int count;

    //UI texts.
    public Text countText; //Counter text.
    public Text winText; //Win text.

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        initPosition = transform.position; //Save init position.

        //Bool to know if player is jumping.
        isJumping = false;

        //Counter
        count = 0;
        setCountText();
        winText.text = "";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        if(transform.position.y < 0)
        {
            returnToInitPosition();
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKey(KeyCode.Space) && !isJumping)
        {
            Jump();
        }
    }

    void Jump()
    {
        isJumping = true;
        rb.AddForce(new Vector3(0.0f, 1f, 0.0f)*jumpSpeed, ForceMode.Impulse);

    }

    void returnToInitPosition()
    {
        transform.SetPositionAndRotation(initPosition, transform.rotation);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            returnToInitPosition();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= PickUpsNum)
        {
            winText.text = "You Win";
        }
    }
}
