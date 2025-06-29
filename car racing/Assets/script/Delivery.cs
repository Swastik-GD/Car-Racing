using UnityEngine;
using static UnityEngine.Rendering.ReloadAttribute;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float DestroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Got Hit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("picked up package");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, DestroyDelay);
        }

        if (other.tag == "Coustomer" && hasPackage)
        {
            Debug.Log("package dilivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
