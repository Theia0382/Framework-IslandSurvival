using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMovement : MonoBehaviour
{
    Transform playerTransform;

    void Awake( )
    {
        playerTransform = GameObject.Find( "Player" ).GetComponent<Transform>( );
    }

    // Start is called before the first frame update
    void Start( )
    {
        
    }

    // Update is called once per frame
    void Update( )
    {
        float playerX = playerTransform.position.x;
        float playerY = playerTransform.position.y;
        float cameraZ = transform.position.z;

        transform.position = new Vector3( playerX, playerY, cameraZ );
    }
}
