using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorMove : MonoBehaviour
{
    [SerializeField, Header("ˆÚ“®‘¬“x")]
    float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //“ü—Í‚ÅˆÚ“®
        InputMove();
    }

    /// <summary>
    /// ˆÚ“®
    /// </summary>
    void InputMove()
    {
        //ã•ûŒü
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        //‰º•ûŒü
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        //¶•ûŒü
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        //‰E•ûŒü
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }


    }
}
