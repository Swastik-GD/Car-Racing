using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float steerspeed = 1f;
    [SerializeField] float movespeed = 1f;
    [SerializeField] float boostspeed = 3f;
    [SerializeField] float slowspeed = 0.8f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        movespeed = slowspeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            movespeed = boostspeed;
            Debug.Log("hey man you just hit boost");
        }
    }
}
