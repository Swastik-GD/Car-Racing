using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject followDriver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = followDriver.transform.position + new Vector3(0, 0, -10);
    }
}
