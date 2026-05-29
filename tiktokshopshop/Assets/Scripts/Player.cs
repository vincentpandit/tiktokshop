using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 0f;
    public float distanceToAdd = 1f;
    
    [SerializeField] float xLimitLeft;
    [SerializeField] float xLimitRight;

    


    private void Update()
    {
        Clamp();
        

    }

    private void Clamp()
    {
        float positionX = transform.position.x;
        
        positionX = Mathf.Clamp(positionX, xLimitLeft, xLimitRight);
        
        Vector3 newPosition = new Vector3(positionX, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }

    public void GoRight()
    {
        Debug.Log("Droite");
        transform.Translate( distanceToAdd * speed *  Time.deltaTime, 0f, 0f );
    }

    public void GoLeft()
    {
        Debug.Log("Gauche");
        transform.Translate( -distanceToAdd * speed *  Time.deltaTime, 0f, 0f );
    }
    
    
}
