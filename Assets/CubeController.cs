using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    public AudioClip se;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

       




    }

    void OnCollisionEnter2D(Collision2D other)
    {

        
        Debug.Log("衝突: " + other.gameObject.tag);


        if (other.gameObject.tag == "BlockTag")
        {

            //効果音を鳴らす関数
            GetComponent<AudioSource>().Play();

          //  Debug.Log("音有り");

        }
        else
        {

          //  Debug.Log("音無し");


        }




    }

}