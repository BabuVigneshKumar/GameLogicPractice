using UnityEngine;

public class SignedAngleExample : MonoBehaviour
{
    [SerializeField] private Transform enemy;
    [SerializeField] private float maxRange = 10f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        /// signed angle practice ///
        Vector3 directionToTarget = (enemy.position - transform.position).normalized;
        Vector3 currentForward = transform.forward;

        Debug.Log($"Direction With Normalize {directionToTarget} and enemy poisiton  {enemy.position} and my position {transform.position} ");
        Debug.Log($"Direction Without normalize {(enemy.position - transform.position)} and enemy poisiton  {enemy.position} and my position {transform.position} ");


        // Compute signed angle on Y axis (horizontal plane)
        float angle = Vector3.SignedAngle(currentForward, directionToTarget, Vector3.up);

        // Rotate a little each frame toward the target
        float rotationSpeed = 90f; // degrees per second
        float step = Mathf.Clamp(angle, -rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up, step);



        ///ray cast detection ///
        Vector3 direction = (enemy.position - transform.position).normalized;
        Debug.DrawLine(transform.position, transform.position + direction * maxRange, Color.yellow);


        if (Physics.Raycast(transform.position, direction, out RaycastHit hit, maxRange))
        {
            Debug.Log("Ray hit: " + hit.collider.name);
            Debug.DrawLine(transform.position, hit.point, Color.magenta);
        }


    }

    //public void OnDrawGizmos()
    //{
    //    if (enemy == null) return;

    //    Vector3 playerPos = transform.position;
    //    Vector3 enemyPos = enemy.position;

    //    Vector3 direction = enemyPos - playerPos;
    //    Vector3 normalized = direction.normalized;

    //    // Raw direction (red)
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawLine(playerPos, playerPos + direction);

    //    // Normalized direction (green, scaled to 2 units)
    //    Gizmos.color = Color.green;
    //    Gizmos.DrawLine(playerPos, playerPos + normalized * 5f);

    //    //// Optional: to enemy (blue)
    //    //Gizmos.color = Color.blue;
    //    //Gizmos.DrawLine(playerPos, enemyPos);

    //    // Mark endpoints
    //    Gizmos.color = Color.yellow;
    //    Gizmos.DrawSphere(playerPos + normalized * 5f, 0.2f); ;
    //}
}
