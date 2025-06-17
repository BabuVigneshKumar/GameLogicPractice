using UnityEngine;

public class BobbleAnimatiion : MonoBehaviour
{
    [SerializeField] private Transform head;

    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float frequency = 1f;

    [SerializeField] private Vector3 startPos;

    private void Start()
    {
        startPos = head.position;
    }

    private void Update()
    {
        float y = Mathf.Sin(Time.time * frequency) * amplitude;

        Debug.Log(y);
       head.position = startPos + new Vector3 (0, y,0);  
    }
}
