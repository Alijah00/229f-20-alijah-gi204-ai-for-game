using UnityEngine;

public class flying : MonoBehaviour
{
    public GameObject endpoint;
    public GameObject spacecruiser;
    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spacecruiser.transform.position = Vector3.MoveTowards(spacecruiser.transform.position, endpoint.transform.position, speed * Time.deltaTime);
    }
}
