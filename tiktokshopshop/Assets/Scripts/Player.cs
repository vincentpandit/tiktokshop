using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0;
    
    [SerializeField] float xLimitLeft;
    [SerializeField] float xLimitRight;

    
    void Start()
    {
        
    }

    void Update()
    {
        float positionX = transform.position.x;
        
        positionX = Mathf.Clamp(positionX, xLimitLeft, xLimitRight);
        
        Vector3 newPosition = new Vector3(positionX, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
    
    
}
