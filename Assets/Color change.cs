using UnityEngine;

public class Colorchange : MonoBehaviour
{
    [SerializeField ] private float changeInterval = 2.0f;
    private Renderer cubeRenderer;
    private float timer;
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        timer = changeInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            change();
            timer = changeInterval;
        }
          
    }

    void change() 
    {
        cubeRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
