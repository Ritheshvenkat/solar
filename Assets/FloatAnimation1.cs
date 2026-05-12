using UnityEngine;
public class FloatAnimation : MonoBehaviour
{
    public float floatSpeed = 1.5f;
    public float floatHeight = 0.02f;
    private Vector3 startPos;
    void Start() { startPos = transform.localPosition; }
    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.localPosition = new Vector3(startPos.x, newY, startPos.z);
    }
}
