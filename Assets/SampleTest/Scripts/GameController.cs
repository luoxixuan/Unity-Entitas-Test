using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var contexts = new Contexts();

        var e = contexts.game.CreateEntity();

        e.AddHealth(100);
    }
    
}
