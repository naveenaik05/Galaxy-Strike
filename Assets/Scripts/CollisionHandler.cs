using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;

    GameScenceManager gameScenceManager;
    void Start()
    {
        gameScenceManager = FindFirstObjectByType<GameScenceManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        gameScenceManager.ReloadLevel();    
        Instantiate(destroyedVFX,transform.position,destroyedVFX.transform.rotation);
        Destroy(gameObject);
        
    }
}
