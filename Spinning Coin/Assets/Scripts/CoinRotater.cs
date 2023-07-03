using UnityEngine;

public class CoinRotater : MonoBehaviour
{

    [SerializeField] private float _rotationSpeed = 10f;

    private void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        float newRotation = currentRotation.y + _rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(currentRotation.x, newRotation, currentRotation.z);
    }

}
