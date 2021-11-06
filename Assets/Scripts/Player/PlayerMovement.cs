using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [ Range( 0.0f, 20.0f ) ]
    public float speed;

    public bool MoveLeft = false;
    public bool MoveRight = false;
    public bool MoveUp = false;
    public bool MoveDown = false;

    // Start is called before the first frame update
    void Start( )
    {
        
    }

    // Update is called once per frame
    void Update( )
    {
        if ( Input.GetKey( KeyCode.W ) )
        {
            transform.Translate( new Vector2( 0, speed * Time.deltaTime ) );
            MoveUp = true;
        }
        else
        {
            MoveUp = false;
        }
        if ( Input.GetKey( KeyCode.S ) )
        {
            transform.Translate( new Vector2( 0, - speed * Time.deltaTime ) );
            MoveDown = true;
        }
        else
        {
            MoveDown = false;
        }
        if ( Input.GetKey( KeyCode.D ) )
        {
            transform.Translate( new Vector2( speed * Time.deltaTime, 0 ) );
            MoveRight = true;
        }
        else
        {
            MoveRight = false;
        }
        if ( Input.GetKey( KeyCode.A ) )
        {
            transform.Translate( new Vector2( - speed * Time.deltaTime, 0 ) );
            MoveLeft = true;
        }
        else
        {
            MoveLeft = false;
        }
    }
}
