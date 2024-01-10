using UnityEngine;

namespace Movement {
    [CreateAssetMenu(fileName = "MovementConfig", menuName ="Configs/Movement/CharacterMovementConfig")]
    public class CharacterMovementConfig : ScriptableObject {
        [field: SerializeField] public float Speed { get; private set; } = 0;
    }
}