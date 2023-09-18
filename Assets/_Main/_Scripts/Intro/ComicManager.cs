using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Intro {
    public class ComicManager : MonoBehaviour {
        [field: SerializeField] public List<Sprite> ComicSprites { get; private set; }

        [Inject]
        private void InitSprites (IntroConfig config){
            ComicSprites = new List<Sprite>();

            for (int i = 0; i < config.ComicSprites.Length; i++) {
                ComicSprites.Add(config.ComicSprites[i]);
            }
        }
    }
}