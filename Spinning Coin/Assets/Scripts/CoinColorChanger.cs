using UnityEngine;

public class CoinColorChanger : MonoBehaviour
{
    private Renderer _coinRenderer;

    void Start()
    {
        _coinRenderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        _coinRenderer.material.color = Random.ColorHSV();
    }

}
