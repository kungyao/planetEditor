/*using UnityEngine;
using System.Collections;

public class move_circle : MonoBehaviour
{
	// Use this for initialization
	void Start () {
         
    }
	
	// Update is called once per frame
	void Update () {
       Vector3 point = gameObject.transform.parent.transform.position;
        //float distance = Vector3.Distance(transform.position, point);
        gameObject.transform.RotateAround(point,transform.position,60*Time.deltaTime);
       // obj.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
    }
}*/
using UnityEngine;
using System.Collections;

public class move_circle : MonoBehaviour
{
    public Transform sun;
    public float r; //半径
    public float w; //角度
    public float speed;
    public float x;
    public float z;
    void Awake()
    {
        //transform.position = new Vector3(10 * Random.value, 10 * Random.value, 0); //重置做圆周的开始位置

        GameObject sun = GameObject.FindGameObjectWithTag("sun"); //取得圆点 我用一个sphere 表示
        r = Vector3.Distance(transform.position, sun.transform.position); //两个物品间的距离
        w = 0.3f; // ---角速度
        speed = 1 * Random.value; // 这个应该所角速度了
    }
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //下面的概念有点模糊了
        w += speed * Time.deltaTime; // 
        x = Mathf.Cos(w) * r;
        z = Mathf.Sin(w) * r;

        transform.position = new Vector3(x, transform.position.y, z);
    }
}