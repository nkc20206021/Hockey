using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller1 : MonoBehaviour
{

    public float speed = 6.0f;
    private Vector3 pos;
    bool start;
    // Start is called before the first frame update
    void Start()
    {
        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Space))
        {
            start = true;
        }
        if(start)
        {
            if(Input.GetKey("d"))
            {
                transform.position += transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                transform.position -= transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey("w"))
                {
                    transform.position += transform.forward * 9f * Time.deltaTime;
                }
                if (Input.GetKey("s"))
                {
                    transform.position -= transform.forward * 9f * Time.deltaTime;
                }
                if (Input.GetKey("d"))
                {
                    transform.position += transform.right * 9f * Time.deltaTime;
                }
                if (Input.GetKey("a"))
                {
                    transform.position -= transform.right * 9f * Time.deltaTime;
                }
            }
        }
        Clamp();
        // 追加
        // プレーヤーの移動できる範囲を制限する命令ブロック
        void Clamp()
        {
            // プレーヤーの位置情報を「pos」という箱の中に入れる。
            pos = transform.position;

            pos.x = Mathf.Clamp(pos.x, -9.5f, -0.6f);
            pos.z = Mathf.Clamp(pos.z, -4, 4);

            transform.position = pos;
        }
    }

    
}
