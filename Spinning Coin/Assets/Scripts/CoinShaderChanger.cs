using UnityEngine;

public class CoinShaderChanger : MonoBehaviour
{
    [SerializeField] private Material[] _coinMaterials;

    private Renderer _coinRenderer;
    void Start()
    {
        _coinRenderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        _coinRenderer.material = GetNewMaterial();   
    }

    private Material GetNewMaterial()
    {
        var newMaterial = _coinMaterials[Random.Range(0, _coinMaterials.Length)];
        return newMaterial;
    }
}
