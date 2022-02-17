using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public Transform start;
    public Transform end;
    private int randomNumber;

    public float speed = 0.12f;

    [Range(0,1)]
    public float t = 0.0f;

    

    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(0, 2);

        t += speed * Time.deltaTime;

        t = Mathf.MoveTowards(0, 1.0f, t);

        if (randomNumber == 1)
        {
            t = t - 0.4f;
        }

        t = Mathf.Clamp01(t);

        transform.position = Vector3.Lerp(start.position, end.position, t);
        transform.rotation = Quaternion.Slerp(start.rotation, end.rotation, t);

    }
}
