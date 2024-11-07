using UnityEngine;

public class Temporizador : MonoBehaviour
{
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //timer -= 1 * Time.deltaTime;

        //Debug.Log(timer);


        timer += Time.deltaTime;

        if (timer >= 5 )
        {
            Debug.Log("Hola");
            timer = 0f;
        }

    }
}
