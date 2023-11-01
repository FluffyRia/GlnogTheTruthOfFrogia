using UnityEngine;

[CreateAssetMenu(fileName = "IntroConfig", menuName = "Configs/Intro/IntroConfig")]
public class IntroConfig : ScriptableObject {
    [field: SerializeField] public Sprite[] ComicSprites { get; private set; }
    [field: SerializeField] public string[] ComicStrings { get; private set; }
}