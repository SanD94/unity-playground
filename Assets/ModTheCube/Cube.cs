using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float scale = 1.3f;
    private Vector3 position = new Vector3(3, 4, 1);
    private Color color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    private float range = 0.2f;
    
    private Material material;
    
    void Start()
    {
        transform.position = position;
        transform.localScale = Vector3.one * scale;
        
        material = Renderer.material;
        
        material.color = color;
        InvokeRepeating("ChangeEverything", 0.1f, 0.2f);
    }
    
    void ChangeEverything()
    {
        float r = Random.Range(-range, range);
        scale += r;
        position += Vector3.one * r;
        color.r = Mathf.Min(1.0f, Mathf.Max(0.0f, color.r + r));
        color.g = Mathf.Min(1.0f, Mathf.Max(0.0f, color.g + r));
        color.b = Mathf.Min(1.0f, Mathf.Max(0.0f, color.b + r));
        color.a = Mathf.Min(1.0f, Mathf.Max(0.0f, color.a + r));

        transform.localScale = Vector3.one * scale;
        transform.position = position;
        material.color = color;
        transform.Rotate(0, r * 100, 0);
    }
}
