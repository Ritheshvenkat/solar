using UnityEngine;
public class Rotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0f, 30f * Time.deltaTime, 0f);
    }
}