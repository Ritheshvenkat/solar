using UnityEngine;

public class OrbitPlanet : MonoBehaviour
{
    public Transform sun;
    public float orbitRadius = 1f;
    public float orbitSpeed = 2f;
    public float selfRotateSpeed = 30f;

    private float currentAngle = 0f;

    void Start()
    {
        // set random starting position
        currentAngle = Random.Range(0f, 360f);
    }

    void Update()
    {
        // orbit around sun
        currentAngle += orbitSpeed * Time.deltaTime;
        float x = sun.position.x + Mathf.Cos(currentAngle) * orbitRadius;
        float z = sun.position.z + Mathf.Sin(currentAngle) * orbitRadius;
        transform.position = new Vector3(x, sun.position.y, z);

        // self rotation
        transform.Rotate(0f, selfRotateSpeed * Time.deltaTime, 0f);
    }
}