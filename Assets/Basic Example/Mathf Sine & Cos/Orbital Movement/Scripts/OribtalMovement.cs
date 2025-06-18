using UnityEngine;

public class OribtalMovement : MonoBehaviour
{
    [SerializeField] private Transform centerObj; //example Sun
    [SerializeField] private Transform EarthObj; 

    [SerializeField] private float radius = 3f;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float angle = 0f;


    private void Update()
    {
        OribitMovement();
    }

    private void OribitMovement()
    {
        angle += speed * Time.deltaTime;

        float x = centerObj.position.x + Mathf.Cos(angle) * radius;
        float z = centerObj.position.z + Mathf.Sin(angle) * radius;

        EarthObj.position = new Vector3(x, EarthObj.position.y, z);
    }
}
